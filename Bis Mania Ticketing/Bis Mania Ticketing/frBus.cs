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
    public partial class frBus : Form
    {
        BMTDataContext dc = new BMTDataContext();
        Validation val;
        Bus bus;
        List<Control> skip;
        public int Page { get; set; }
        public frBus()
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
            if (dgBus.SelectedRows.Count < 1)
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

        private void UpdateState()
        {
            if (lbIdValue.Visible == false)
            {
                if (dgBus.SelectedRows.Count > 0)
                {
                    lbID.Visible = true;
                    int tmpId = Convert.ToInt32(dgBus.CurrentRow.Cells[0].Value);
                    lbIdValue.Visible = true;
                    bCancel.Visible = true;
                    var BusEdit = from b in dc.Bus
                                  join o in dc.Otobus
                                  on b.IdOtobus equals o.Id
                                  join t in dc.TicketTypes
                                  on b.IdTicketType equals t.Id
                                  where b.Id == tmpId
                                  select new
                                  {
                                      merge = b.Id + "-" + b.BusNumber,
                                      b.IdOtobus,
                                      b.IdTicketType,
                                      b.BusNumber,
                                      b.BusModel,
                                      b.TotalSeat,
                                      o.OtobusName,
                                      t.TicketName
                                  };
                    lbIdValue.Text = BusEdit.FirstOrDefault().merge;
                    tbOtobus.Text = BusEdit.FirstOrDefault().IdOtobus.ToString();
                    tbOtobusName.Text = BusEdit.FirstOrDefault().OtobusName;
                    tbTicketType.Text = BusEdit.FirstOrDefault().IdTicketType.ToString();
                    tbTicketTypeName.Text = BusEdit.FirstOrDefault().TicketName;
                    tbBusModel.Text = BusEdit.FirstOrDefault().BusModel;
                    nudSeats.Value = Convert.ToDecimal(BusEdit.FirstOrDefault().TotalSeat);
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
                tbBusModel.ResetText();
                nudSeats.Value = Convert.ToDecimal(0);
                bDelete.Enabled = true;
                bEdit.Enabled = true;
            }
        }


        private bool action(string act)
        {
            try
            {
                string busnumber = null;
                using (TransactionScope ts = new TransactionScope())
                {
                    string[] split = lbIdValue.Text.Split('-');
                    bus = act == "insert" ? new Bus() : dc.Bus.Single(id => id.Id == Convert.ToInt32(split[0]));
                    if (act == "insert")
                        bus.Active = 1;
                    bus.IdOtobus = Convert.ToInt32(tbOtobus.Text.Trim());
                    bus.IdTicketType = Convert.ToInt32(tbTicketType.Text.Trim());
                    bus.BusModel = tbBusModel.Text.Trim();
                    bus.TotalSeat = Convert.ToInt32(nudSeats.Value.ToString().Trim());
                    if (act == "insert")
                        dc.Bus.InsertOnSubmit(bus);
                    dc.SubmitChanges();
                    if (act == "insert")
                        busnumber = bus.BusNumber;
                    ts.Complete();
                    if (act != "insert")
                    {
                        lbIdValue.Text = "";
                        lbIdValue.Visible = false;
                        lbID.Visible = false;
                        bCancel.Visible = false;
                    }

                    if(act == "insert")
                        MessageBox.Show("Bus Number " + busnumber + " successfully inserted.", Application.ProductName);
                    tbOtobus.ResetText();
                    tbOtobusName.ResetText();
                    tbTicketType.ResetText();
                    tbTicketTypeName.ResetText();
                    tbBusModel.ResetText();
                    nudSeats.Value = Convert.ToDecimal("0");
                    return true;
                }                             
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }

        private void LoadGrid(int page)
        {
            int selected = Convert.ToInt32(cbLoadItem.SelectedItem.ToString());
            var get = (from b in dc.Bus
                       join o in dc.Otobus
                       on b.IdOtobus equals o.Id
                       join t in dc.TicketTypes
                       on b.IdTicketType equals t.Id
                       where b.Active == 1 &&(
                       b.BusNumber.Contains(tbSearch.Text) ||
                       o.OtobusName.Contains(tbSearch.Text) ||
                       t.TicketName.Contains(tbSearch.Text))
                       select new
                       {
                           b.Id,
                           b.BusNumber,
                           o.OtobusName,
                           t.TicketName,
                           b.TotalSeat
                       });
            if (get.Count() <= selected)
                this.Page = 0;

            int skip = selected;
            int totalskip = page * skip;
            int take = selected;
            int currentpage;

            var loadsource = get.Skip(totalskip).Take(take);
            this.dgBus.DataSource = loadsource.ToList();

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

        private bool DeleteBus()
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this Bus ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    bus = dc.Bus.Single(x => x.Id == Convert.ToInt32(dgBus.CurrentRow.Cells[0].Value));
                    using (TransactionScope ts = new TransactionScope())
                    {
                        if (bus != null)
                        {
                            using (BMTDataContext proc = new BMTDataContext())
                            {

                                proc.DeleteBus(Convert.ToInt32(dgBus.CurrentRow.Cells[0].Value));
                                ts.Complete();
                                return true;
                            }
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

        private void frBus_Load(object sender, EventArgs e)
        {
            DisableButton();
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

        private void bSave_Click(object sender, EventArgs e)
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

        private void bEdit_Click(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (DeleteBus() == true)
            {
                MessageBox.Show("Data successfully deleted", Application.ProductName);
                this.Page = 0;
                LoadGrid(this.Page);
                DisableButton();
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

        private void bCancel_Click(object sender, EventArgs e)
        {
            UpdateState();
        }
    }
}
