using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Transactions;
namespace Bis_Mania_Ticketing
{
    public partial class frPricing : Form
    {
        frMain frM;
        BMTDataContext dc = new BMTDataContext();
        OtobusTicketTypeRoute ottp;
        public int Page { get; set; }
        Validation val;
        List<Control> skip;
        public frPricing(Form owner)
        {
            InitializeComponent();
            frM = owner as frMain;
            val = new Validation(this.Controls);
            skip = new List<Control> { tbSearch, cbLoadItem, lbIdValue };
            this.cbLoadItem.SelectedIndex = 0;
            this.Page = 0;
            LoadGrid(this.Page);
        }

        private void DisableButton()
        {
            if (dgPrice.SelectedRows.Count < 1)
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

        private bool DeletePricing()
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this Ticket Type ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    ottp = dc.OtobusTicketTypeRoutes.FirstOrDefault(x => x.Id == Convert.ToInt32(dgPrice.CurrentRow.Cells[0].Value));
                    using (TransactionScope ts = new TransactionScope())
                    {
                        if (ottp != null)
                        {
                            dc.OtobusTicketTypeRoutes.DeleteOnSubmit(ottp);
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

        private bool action(string act)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    ottp = act == "insert" ? new OtobusTicketTypeRoute() : dc.OtobusTicketTypeRoutes.FirstOrDefault(id => id.Id == Convert.ToInt32(lbIdValue.Text));

                    ottp.IdOtobus = Convert.ToInt32(tbOtobus.Text.Trim());
                    ottp.IdTicketType = Convert.ToInt32(tbTicketType.Text.Trim());
                    ottp.IdRoute = Convert.ToInt32(tbRoute.Text.Trim());
                    string formatprice = tbPrice.Text.Trim().Replace(".", "");
                    ottp.Price = Convert.ToDecimal(formatprice);
                    if (act == "insert")
                        dc.OtobusTicketTypeRoutes.InsertOnSubmit(ottp);
                    dc.SubmitChanges();
                    ts.Complete();
                    if (act != "insert")
                    {
                        lbIdValue.Text = "";
                        lbIdValue.Visible = false;
                        lbID.Visible = false;
                        bCancel.Visible = false;
                    }
                    tbOtobus.ResetText();
                    tbOtobusName.ResetText();
                    tbTicketType.ResetText();
                    tbTicketTypeName.ResetText();
                    tbRoute.ResetText();
                    tbRouteDeparture.ResetText();
                    tbRouteDestination.ResetText();
                    tbPrice.ResetText();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }

        private void UpdateState()
        {
            if (lbIdValue.Visible == false)
            {
                if (dgPrice.SelectedRows.Count > 0)
                {
                    lbID.Visible = true;
                    int tmpId = Convert.ToInt32(dgPrice.CurrentRow.Cells[0].Value);
                    lbIdValue.Visible = true;
                    bCancel.Visible = true;
                    lbIdValue.Text = dgPrice.CurrentRow.Cells[0].Value.ToString();
                    var PricingEdit = (from q in dc.OtobusTicketTypeRoutes
                                     join o in dc.Otobus
                                     on q.IdOtobus equals o.Id
                                     join t in dc.TicketTypes
                                     on q.IdTicketType equals t.Id
                                     join r in dc.Routes
                                     on q.IdRoute equals r.Id
                                     join dp in dc.Venues
                                     on r.RouteDeparture equals dp.Id
                                     join ds in dc.Venues
                                     on r.RouteDestination equals ds.Id
                                     where q.Id == tmpId
                                     select new
                                     {
                                         q.Id,
                                         q.IdOtobus,
                                         q.IdTicketType,
                                         q.IdRoute,
                                         o.OtobusName,
                                         t.TicketName,
                                         mergedp = dp.VenueName + " (" + dp.VenueLocation + ")",
                                         mergeds = ds.VenueName + " (" + ds.VenueLocation + ")",
                                         q.Price
                                     });
                    tbOtobus.Text = PricingEdit.FirstOrDefault().IdOtobus.ToString();
                    tbOtobusName.Text = PricingEdit.FirstOrDefault().OtobusName;
                    tbTicketType.Text = PricingEdit.FirstOrDefault().IdTicketType.ToString();
                    tbTicketTypeName.Text = PricingEdit.FirstOrDefault().TicketName;
                    tbRoute.Text = PricingEdit.FirstOrDefault().IdRoute.ToString();
                    tbRouteDeparture.Text = PricingEdit.FirstOrDefault().mergedp;
                    tbRouteDestination.Text = PricingEdit.FirstOrDefault().mergeds;
                    string formatprice = string.Format("{0:n0}", double.Parse(PricingEdit.FirstOrDefault().Price.ToString())).Replace(",", ".");
                    tbPrice.Text = formatprice.ToString();
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
                tbOtobus.ResetText();
                tbOtobusName.ResetText();
                tbTicketType.ResetText();
                tbTicketTypeName.ResetText();
                tbRoute.ResetText();
                tbRouteDeparture.ResetText();
                tbRouteDestination.ResetText();
                tbPrice.ResetText();
                bDelete.Enabled = true;
                bEdit.Enabled = true;
            }
        }

        private void LoadGrid(int page)
        {
            int selected = Convert.ToInt32(this.cbLoadItem.SelectedItem.ToString());
            var get = (from q in dc.OtobusTicketTypeRoutes
                       join o in dc.Otobus
                       on q.IdOtobus equals o.Id
                       join t in dc.TicketTypes
                       on q.IdTicketType equals t.Id
                       join r in dc.Routes
                       on q.IdRoute equals r.Id
                       join dp in dc.Venues
                       on r.RouteDeparture equals dp.Id
                       join ds in dc.Venues
                       on r.RouteDestination equals ds.Id
                       where o.OtobusName.Contains(tbSearch.Text) ||
                       t.TicketName.Contains(tbSearch.Text) ||
                       (dp.VenueName + " (" + dp.VenueLocation + ") - " + ds.VenueName + " (" + ds.VenueLocation + ")").Contains(tbSearch.Text) ||
                       q.Price.ToString().Contains(tbSearch.Text)
                       select new
                       {
                           q.Id,
                           o.OtobusName,
                           t.TicketName,
                           Route = dp.VenueName + " (" + dp.VenueLocation + ") - " + ds.VenueName + " (" + ds.VenueLocation + ")",
                           Price = q.Price
                       });

            if (get.Count() <= selected)
                this.Page = 0;

            int skip = selected;
            int totalskip = page * skip;
            int take = selected;
            int currentpage;

            var loadsource = get.Skip(totalskip).Take(take);
            this.dgPrice.DataSource = loadsource.ToList();

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


        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;                
        }

        private void tbPrice_Leave(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbPrice.Text))
                {
                    return;
                }
                string number = string.Format("{0:n0}", double.Parse(tbPrice.Text));
                string changeformat = number.Replace(',', '.');
                tbPrice.Text = changeformat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }   
        }

        private void tbPrice_Enter(object sender, EventArgs e)
        {
            try
            {
                string replace = tbPrice.Text.Replace(".", "");
                tbPrice.Text = replace;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void frPricing_Load(object sender, EventArgs e)
        {
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
                var aksi = action(lbID.Visible == true ? "update" : "insert");
                tbSearch.ResetText();
                if (aksi == true && state == true)
                    MessageBox.Show("Data successfully saved.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.None);

                this.Page = 0;
                LoadGrid(this.Page);
                DisableButton();
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
            this.Page += 1;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void cbLoadItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Page = 0;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void tbSearch_ButtonClick(object sender, EventArgs e)
        {
            this.Page = 0;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void tbOtobus_Leave(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbOtobus.Text.Trim()) == false)
                {
                    var getOtobus = dc.Otobus.Where(i => i.Id == Convert.ToInt32(this.tbOtobus.Text.Trim()));
                    if (getOtobus.Count() != 0)
                        tbOtobusName.Text = getOtobus.FirstOrDefault().OtobusName;
                    else
                        tbOtobusName.ResetText();
                }
                else
                    tbOtobusName.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tbOtobusName.ResetText();
            }
        }

        private void tbTicketType_Leave(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbTicketType.Text.Trim()) == false)
                {
                    var getTicketType = dc.TicketTypes.Where(i => i.Id == Convert.ToInt32(this.tbTicketType.Text.Trim()));
                    if (getTicketType.Count() != 0)
                        tbTicketTypeName.Text = getTicketType.FirstOrDefault().TicketName;
                    else
                        tbTicketTypeName.ResetText();
                }
                else
                    tbTicketTypeName.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tbTicketTypeName.ResetText();
            }
        }

        private void tbRoute_Leave(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbRoute.Text.Trim()) == false)
                {
                    var getRoute = from r in dc.Routes
                                   join dp in dc.Venues
                                   on r.RouteDeparture equals dp.Id
                                   join ds in dc.Venues
                                   on r.RouteDestination equals ds.Id
                                   where r.Id == Convert.ToInt32(tbRoute.Text.Trim())
                                   select new
                                   {
                                       r.RouteDeparture,
                                       r.RouteDestination,
                                       mergedp = dp.VenueName + " (" + dp.VenueLocation + ")",
                                       mergeds = ds.VenueName + " (" + ds.VenueLocation + ")"
                                   };
                    if (getRoute.Count() != 0)
                    {
                        tbRouteDeparture.Text = getRoute.FirstOrDefault().mergedp;
                        tbRouteDestination.Text = getRoute.FirstOrDefault().mergeds;
                    }
                    else
                    {
                        tbRouteDeparture.ResetText();
                        tbRouteDestination.ResetText();
                    }
                }
                else
                {
                    tbRouteDeparture.ResetText();
                    tbRouteDestination.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tbTicketTypeName.ResetText();
            }
        }

        private void dgPrice_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int x = 1;
            int y = dgPrice.Columns.Count;
            foreach (DataGridViewColumn i in dgPrice.Columns)
            {
                if (x < y)
                    i.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                else
                    i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                x++;
            }
            dgPrice.AutoResizeColumns();
        }

        private void tbRoute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;  
        }

        private void tbTicketType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;  
        }

        private void tbOtobus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;  
        }

        private void tbOtobus_ButtonClick(object sender, EventArgs e)
        {
            frLookup frLook = new frLookup(this.tbOtobus, "Otobus");
            frLook.ShowDialog();
        }

        private void tbTicketType_ButtonClick(object sender, EventArgs e)
        {
            frLookup frLook = new frLookup(this.tbTicketType, "TicketType");
            frLook.ShowDialog();
        }

        private void tbRoute_ButtonClick(object sender, EventArgs e)
        {
            frLookup frLook = new frLookup(this.tbRoute, "Route");
            frLook.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (DeletePricing() == true)
            {
                MessageBox.Show("Data successfully deleted", Application.ProductName);
                this.Page = 0;
                LoadGrid(this.Page);
                DisableButton();
            }
        }
    }
}
