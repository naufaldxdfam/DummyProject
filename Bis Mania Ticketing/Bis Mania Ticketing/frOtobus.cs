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
    public partial class frOtobus : Form
    {
        BMTDataContext dc = new BMTDataContext();
        Otobus ob;
        public int Page { get; set; }
        Validation val;
        List<Control> skip;
        public frOtobus()
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
            if (dgOtobus.SelectedRows.Count < 1)
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
            var get = dc.Otobus.Where(x => x.OtobusName.Contains(tbSearch.Text));
            if (get.Count() <= selected)
                this.Page = 0;
            
            int skip = selected;
            int totalskip = page * skip;
            int take = selected;

            int currentpage;
            var loadsource = get.Skip(totalskip).Take(take);
            this.dgOtobus.DataSource = loadsource.ToList();
            this.dgOtobus.Columns["Id"].HeaderText = "ID";
            this.dgOtobus.Columns["OtobusName"].HeaderText = "Otobus Name";

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
                    ob = act == "insert" ? new Otobus() : dc.Otobus.FirstOrDefault(id => id.Id == Convert.ToInt16(lbIdValue.Text));

                    ob.OtobusName = tbOtobusName.Text;
                    if (act == "insert")
                        dc.Otobus.InsertOnSubmit(ob);
                    dc.SubmitChanges();
                    ts.Complete();
                    if (act != "insert")
                    {
                        lbIdValue.Text = "";
                        lbIdValue.Visible = false;
                        lbID.Visible = false;
                        bCancel.Visible = false;
                    }
                    tbOtobusName.ResetText();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }            
        }

        private bool DeleteOtobus()
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this Otobus ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Otobus oto = new Otobus();
                    oto = dc.Otobus.FirstOrDefault(x => x.Id == Convert.ToInt16(dgOtobus.CurrentRow.Cells["Id"].Value));
                    using(TransactionScope ts = new TransactionScope())
                    {                            
                        if (oto != null)
                        {
                            dc.Otobus.DeleteOnSubmit(oto);
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
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
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
                {
                    MessageBox.Show("Data successfully saved.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.None);
                }

                this.Page = 0;
                LoadGrid(this.Page);
                DisableButton();
            }
        }


        private void UpdateState()
        {
            if (lbIdValue.Visible == false)
            {
                if (dgOtobus.SelectedRows.Count > 0)
                {
                    lbID.Visible = true;
                    lbIdValue.Visible = true;
                    bCancel.Visible = true;
                    lbIdValue.Text = dgOtobus.CurrentRow.Cells[0].Value.ToString();
                    tbOtobusName.Text = dc.Otobus.FirstOrDefault(i => i.Id == Convert.ToInt16(dgOtobus.CurrentRow.Cells[0].Value)).OtobusName;
                    this.bDelete.Enabled = false;
                    bEdit.Enabled = false;

                }
            }
            else
            {
                tbOtobusName.ResetText();
                lbID.Visible = false;
                lbIdValue.Text = "";
                lbIdValue.Visible = false;
                bCancel.Visible = false;
                this.bDelete.Enabled = true;
                bEdit.Enabled = true;
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

        private void bPrevious_Click(object sender, EventArgs e)
        {
            this.Page -= 1;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            this.Page += 1;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void tbSearch_ButtonClick(object sender, EventArgs e)
        {
            this.Page = 0;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (DeleteOtobus() == true)
            {
                MessageBox.Show("Data successfully deleted", Application.ProductName);
                this.Page = 0;
                LoadGrid(this.Page);
                DisableButton();
            }
        }

        private void cbLoadItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Page = 0;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void frOtobus_Load(object sender, EventArgs e)
        {
            DisableButton();
        }
    }
}
