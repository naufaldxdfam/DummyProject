using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace Bis_Mania_Ticketing
{
    public partial class frRoute : Form
    {
        BMTDataContext dc = new BMTDataContext();
        Validation val;
        Route rt;
        List<Control> skip;
        public int Page { get; set; }

        public frRoute()
        {
            InitializeComponent();
            val = new Validation(this.Controls);
            skip = new List<Control> { tbSearch, cbLoadItem, lbIdValue };
            this.cbLoadItem.SelectedIndex = 0;
            this.Page = 0;
            LoadGrid(this.Page);
            
        }

        private void DisableButton()
        {
            if (dgRoute.SelectedRows.Count < 1)
            {
                bDelete.Enabled = false;
                bEdit.Enabled = false;
            }
            else
            {
                bDelete.Enabled = true;
                bEdit.Enabled = true;
            }
        }

        private void LoadGrid(int page)
        {
            int selected = Convert.ToInt32(this.cbLoadItem.SelectedItem.ToString());
            var get = (from r in dc.Routes
                      join dp in dc.Venues
                      on r.RouteDeparture equals dp.Id
                      join ds in dc.Venues
                      on r.RouteDestination equals ds.Id
                      where (dp.VenueName + " (" + dp.VenueLocation + ")" + " - " + ds.VenueName + " (" + ds.VenueLocation + ")").Contains(tbSearch.Text)
                      select new
                      {
                          ID = r.Id,
                          RouteBus = dp.VenueName + " (" + dp.VenueLocation + ")" + " - " + ds.VenueName + " (" + ds.VenueLocation + ")"
                      });
            if (get.Count() <= selected)
                this.Page = 0;

            int skip = selected;
            int totalskip = page * skip;
            int take = selected;
            int currentpage;

            var loadsource = get.Skip(totalskip).Take(take);
            this.dgRoute.DataSource = loadsource.ToList();

            int totalPage = get.Count() / take;
            int modtotalPage = get.Count() % take;

            if (loadsource.Count() == 0)
            {
                currentpage = 0;
                totalPage = 0;
            }
            else
            {
                currentpage = this.Page + 1;
            }

            if (modtotalPage != 0)
                totalPage += 1;


            lbPage.Text = currentpage.ToString() + " / " + totalPage.ToString();

            if (currentpage <= 1)
                bPrevious.Enabled = false;
            else
                bPrevious.Enabled = true;

            if (currentpage == totalPage)
                bNext.Enabled = false;
            else
                bNext.Enabled = true;

        }

        private bool action(string act)
        {
            try
            {
                if (tbDeparture.Text.Trim() != tbDestination.Text.Trim())
                {
                    var check = dc.Routes.Where(i => i.RouteDeparture == Convert.ToInt32(tbDeparture.Text.Trim()) && i.RouteDestination == Convert.ToInt32(tbDestination.Text.Trim())).ToList();
                    if (check.Count == 0)
                    {
                        using (TransactionScope ts = new TransactionScope())
                        {
                            rt = act == "insert" ? new Route() : dc.Routes.FirstOrDefault(id => id.Id == Convert.ToInt32(lbIdValue.Text));
                            rt.RouteDeparture = Convert.ToInt32(tbDeparture.Text.Trim());
                            rt.RouteDestination = Convert.ToInt32(tbDestination.Text.Trim());
                            if (act == "insert")
                                dc.Routes.InsertOnSubmit(rt);
                            dc.SubmitChanges();
                            ts.Complete();
                            if (act != "insert")
                            {
                                lbIdValue.Text = "";
                                lbIdValue.Visible = false;
                                lbID.Visible = false;
                                bCancel.Visible = false;
                            }
                            tbDeparture.ResetText();
                            tbDepartureNameLocation.ResetText();
                            tbDestination.ResetText();
                            tbDestinationNameLocation.ResetText();
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The route is already exists", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Departure and Destination must be different", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }

        private bool DeleteRoute()
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this Route ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    rt = dc.Routes.Single(x => x.Id == Convert.ToInt32(dgRoute.CurrentRow.Cells[0].Value));
                    using (TransactionScope ts = new TransactionScope())
                    {
                        if (rt != null)
                        {
                            dc.Routes.DeleteOnSubmit(rt);
                            dc.SubmitChanges();
                            ts.Complete();
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void UpdateState()
        {
            if (lbIdValue.Visible == false)
            {
                if (dgRoute.SelectedRows.Count > 0)
                {
                    lbID.Visible = true;
                    int tmpId = Convert.ToInt32(dgRoute.CurrentRow.Cells[0].Value);
                    lbIdValue.Visible = true;
                    bCancel.Visible = true;
                    lbIdValue.Text = dgRoute.CurrentRow.Cells[0].Value.ToString();
                    var RouteEdit = from r in dc.Routes
                                    join dp in dc.Venues
                                    on r.RouteDeparture equals dp.Id
                                    join ds in dc.Venues
                                    on r.RouteDestination equals ds.Id
                                    where r.Id == tmpId
                                    select new
                                    {
                                        r.RouteDeparture,
                                        r.RouteDestination,
                                        mergedp = dp.VenueName + " (" + dp.VenueLocation + ")",
                                        mergeds = ds.VenueName + " (" + ds.VenueLocation + ")"
                                    };
                    tbDeparture.Text = RouteEdit.FirstOrDefault().RouteDeparture.ToString() ;
                    tbDepartureNameLocation.Text = RouteEdit.FirstOrDefault().mergedp;
                    tbDestination.Text = RouteEdit.FirstOrDefault().RouteDestination.ToString();
                    tbDestinationNameLocation.Text = RouteEdit.FirstOrDefault().mergeds;
                    bDelete.Enabled = false;
                    bEdit.Enabled = false;
                }
            }
            else
            {
                lbID.Visible = false;
                lbIdValue.Text = "";
                lbIdValue.Visible = false;
                bCancel.Visible = false;
                tbDeparture.ResetText();
                tbDepartureNameLocation.ResetText();
                tbDestination.ResetText();
                tbDestinationNameLocation.ResetText();
                bDelete.Enabled = true;
                bEdit.Enabled = true;
            }
        }

        private void tbSearch_ButtonClick(object sender, EventArgs e)
        {
            this.Page = 0;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void cbLoadItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Page = 0;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (val.Validate(skip) == true)
            {
                if (lbID.Visible == true)
                {
                    DialogResult dr = MessageBox.Show("Are you sure to change this data?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                        return;
                }
                bool state = lbIdValue.Visible;
                var aksi = action(lbIdValue.Visible == false ? "insert" : "update");
                tbSearch.ResetText();
                if (aksi == true && state == true)
                    MessageBox.Show("Data successfully saved.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.None);

                this.Page = 0;
                LoadGrid(this.Page);
                DisableButton();
            }
        }

        private void tbDeparture_ButtonClick(object sender, EventArgs e)
        {
            frLookup frLook = new frLookup(this.tbDeparture, "Venue");
            frLook.ShowDialog();
        }

        private void tbDestination_ButtonClick(object sender, EventArgs e)
        {
            frLookup frLook = new frLookup(this.tbDestination, "Venue");
            frLook.ShowDialog();
        }

        private void tbDeparture_Leave(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbDeparture.Text.Trim()) == false)
                {
                    var getdeparture = dc.Venues.Where(i => i.Id == Convert.ToInt32(this.tbDeparture.Text.Trim()));
                    if (getdeparture.Count() != 0)
                        tbDepartureNameLocation.Text = getdeparture.Select(i => new { merge = (((i.VenueName + " (") + i.VenueLocation) + ")") }).FirstOrDefault().merge;
                    else
                        tbDepartureNameLocation.ResetText();
                }
                else
                    tbDepartureNameLocation.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tbDepartureNameLocation.ResetText();
            }
        }

        private void tbDestination_Leave(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbDestination.Text.Trim()) == false)
                {
                    var getdestination = dc.Venues.Where(i => i.Id == Convert.ToInt32(this.tbDestination.Text.Trim()));
                    if (getdestination.Count() != 0)
                        tbDestinationNameLocation.Text = getdestination.Select(i => new { merge = (((i.VenueName + " (") + i.VenueLocation) + ")") }).FirstOrDefault().merge;
                    else
                        tbDestinationNameLocation.ResetText();
                }
                else
                    tbDestinationNameLocation.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tbDestinationNameLocation.ResetText();
            }
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            this.Page += 1;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            this.Page -= 1;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void frRoute_Load(object sender, EventArgs e)
        {
            DisableButton();
        }

        private void tbDestination_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbDeparture_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (DeleteRoute() == true)
            {
                MessageBox.Show("Data successfully deleted", Application.ProductName);
                this.Page = 0;
                LoadGrid(this.Page);
                DisableButton();
            }
        }
    }
}
