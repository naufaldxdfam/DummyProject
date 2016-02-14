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
    public partial class frBusStation : Form
    {
        BMTDataContext dc = new BMTDataContext();
        Venue vn;
        Validation val;
        List<Control> skip;
        public int Page { get; set; }
        
        public frBusStation()
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
            if (dgBusStation.SelectedRows.Count < 1)
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
            int selected = Convert.ToInt16(cbLoadItem.SelectedItem.ToString());
            var get = dc.Venues
                        .Where(i => i.VenueName.Contains(this.tbSearch.Text) || i.VenueLocation.Contains(this.tbSearch.Text))
                        .Select(i => new
                                {
                                    ID = i.Id,
                                    Name = i.VenueName,
                                    Location = i.VenueLocation
                                }
                               );
            if (get.Count() <= selected)
                this.Page = 0;

            int skip = selected;
            int totalskip = page * skip;
            int take = selected;
            int currentpage;

            var loadsource = get.Skip(totalskip).Take(take);
            this.dgBusStation.DataSource = loadsource.ToList();

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

        private bool action(String act)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    vn = act == "insert" ? new Venue() : dc.Venues.Single(id => id.Id == Convert.ToInt16(lbIdValue.Text));

                    vn.VenueName = tbBusStation.Text.Trim();
                    vn.VenueLocation = tbLocation.Text.Trim();
                    if (act == "insert")
                        dc.Venues.InsertOnSubmit(vn);
                    dc.SubmitChanges();
                    ts.Complete();
                    if (act != "insert")
                    {
                        lbIdValue.Text = "";
                        lbIdValue.Visible = false;
                        lbID.Visible = false;
                        bCancel.Visible = false;
                    }
                    tbBusStation.ResetText();
                    tbLocation.ResetText();
                    this.tbSearch.CustomButton.Enabled = true;
                    this.cbLoadItem.Enabled = true;
                    return true;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }            
        }

        private bool DeleteBusStation()
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this Bus Station ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    vn = dc.Venues.Single(i => i.Id == Convert.ToInt16(this.dgBusStation.CurrentRow.Cells[0].Value));
                    using (TransactionScope ts = new TransactionScope())
                    {
                        if (vn != null)
                        {
                            dc.Venues.DeleteOnSubmit(vn);
                            dc.SubmitChanges();
                            ts.Complete();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Somthing error with delete proccess", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
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
            if (this.bCancel.Visible == false)
            {
                if (dgBusStation.SelectedRows.Count > 0)
                {
                    var loaddata = dc.Venues.First(i => i.Id == Convert.ToInt16(dgBusStation.CurrentRow.Cells[0].Value));
                    this.lbID.Visible = true;
                    this.lbIdValue.Visible = true;
                    this.lbIdValue.Text = dgBusStation.CurrentRow.Cells[0].Value.ToString();
                    this.tbBusStation.Text = loaddata.VenueName;
                    this.tbLocation.Text = loaddata.VenueLocation;
                    this.bCancel.Visible = true;
                    this.bDelete.Enabled = false;
                    this.tbSearch.CustomButton.Enabled = false;
                    this.cbLoadItem.Enabled = false;
                    this.bEdit.Enabled = false;
                }
            }
            else
            {
                this.lbID.Visible = false;
                this.lbIdValue.Text = "";
                this.lbIdValue.Visible = false;
                this.tbBusStation.ResetText(); ;
                this.tbLocation.ResetText();
                this.bCancel.Visible = false;
                this.bDelete.Enabled = true;
                this.tbSearch.CustomButton.Enabled = true;
                this.cbLoadItem.Enabled = true;
                this.bEdit.Enabled = true;

            }
        }

        private void tbSearch_ButtonClick(object sender, EventArgs e)
        {
            this.Page = 0;
            LoadGrid(this.Page);
            DisableButton();
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

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (DeleteBusStation() == true)
            {
                MessageBox.Show("Data successfully deleted", Application.ProductName);
                this.Page = 0;
                LoadGrid(this.Page);
                DisableButton();
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void cbLoadItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Page = 0;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void frBusStation_Load(object sender, EventArgs e)
        {
            DisableButton();
        }
    }
}
