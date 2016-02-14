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
    public partial class frTicketType : Form
    {
        frMain frM;
        BMTDataContext dc = new BMTDataContext();
        TicketType tt;
        Validation val;
        List<Control> skip;
        public int Page { get; set; }
        public frTicketType(Form frM)
        {
            InitializeComponent();
            this.frM = frM as frMain;
            val = new Validation(this.Controls);
            skip = new List<Control> { tbSearch, cbLoadItem, lbIdValue };
            this.cbLoadItem.SelectedIndex = 0;
            this.Page = 0;
            LoadGrid(Page);
        }

        private void DisableButton()
        {
            if (dgTicket.SelectedRows.Count < 1)
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
            var get = dc.TicketTypes.Where(x => x.TicketName.Contains(tbSearch.Text));
            if (get.Count() <= selected)
                this.Page = 0;

            int skip = selected;
            int totalskip = page * skip;
            int take = selected;

            int currentpage;
            var loadsource = get.Skip(totalskip).Take(take);
            this.dgTicket.DataSource = loadsource.ToList();
            this.dgTicket.Columns["Id"].HeaderText = "ID";
            this.dgTicket.Columns["TicketName"].HeaderText = "Ticket Name";

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

        private bool DeleteTicketType()
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this Ticket Type ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    tt = dc.TicketTypes.FirstOrDefault(x => x.Id == Convert.ToInt32(dgTicket.CurrentRow.Cells[0].Value));
                    using (TransactionScope ts = new TransactionScope())
                    {
                        if (tt != null)
                        {
                            dc.TicketTypes.DeleteOnSubmit(tt);
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

        private bool action(String act)
        {
            try
            {
                using(TransactionScope ts = new TransactionScope())
                {
                    tt = act == "insert" ? new TicketType() : dc.TicketTypes.Single(i => i.Id == Convert.ToInt32(lbIdValue.Text));
                    tt.TicketName = tbTicket.Text.Trim();
                    if (act == "insert")
                        dc.TicketTypes.InsertOnSubmit(tt);
                    dc.SubmitChanges();
                    ts.Complete();
                    if (act != "insert")
                    {
                        lbIdValue.Text = "0";
                        lbIdValue.Visible = false;
                        lbID.Visible = false;
                        bCancel.Visible = false;
                    }
                    tbTicket.ResetText();
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
                if (dgTicket.SelectedRows.Count > 0)
                {
                    lbID.Visible = true;
                    lbIdValue.Visible = true;
                    bCancel.Visible = true;
                    lbIdValue.Text = dgTicket.CurrentRow.Cells[0].Value.ToString();
                    tbTicket.Text = dc.TicketTypes.FirstOrDefault(i => i.Id == Convert.ToInt32(dgTicket.CurrentRow.Cells[0].Value)).TicketName;
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
                tbTicket.ResetText();
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
            this.Page -= 1;
            LoadGrid(this.Page);
            DisableButton();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (DeleteTicketType() == true)
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

        private void bCancel_Click(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void frTicketType_Load(object sender, EventArgs e)
        {

            DisableButton();
        }
    }
}
