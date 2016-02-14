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
using System.Globalization;
namespace Bis_Mania_Ticketing
{
    public partial class frPassenger : Form
    {
        frMain frM;
        BMTDataContext dc = new BMTDataContext();
        Passenger psngr;
        public int Page { get; set; }
        Validation val;
        List<Control> skip;
        public frPassenger(Form owner)
        {
            InitializeComponent();
            frM = owner as frMain;
            val = new Validation(this.Controls);
            skip = new List<Control> { tbSearch, cbLoadItem, lbIdValue, tbPostCode, tbPhone };
            this.cbLoadItem.SelectedIndex = 0;
            this.Page = 0;
            LoadGrid(this.Page);
            LoadGender();
            this.dtpBirthday.MaxDate = DateTime.Now;
        }

        private void DisableButton()
        {
            if (dgPassenger.SelectedRows.Count < 1)
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
                if (dgPassenger.SelectedRows.Count > 0)
                {
                    lbID.Visible = true;
                    int tmpId = Convert.ToInt32(dgPassenger.CurrentRow.Cells[0].Value);
                    lbIdValue.Visible = true;
                    bCancel.Visible = true;
                    lbIdValue.Text = dgPassenger.CurrentRow.Cells[0].Value.ToString();
                    var PassengerEdit = (from p in dc.Passengers
                                         join g in dc.GenderLists
                                         on p.IdGender equals g.Id
                                         where p.Id == tmpId
                                         select new
                                         {
                                             p.Id,
                                             p.NIK,
                                             p.FirstName,
                                             p.LastName,
                                             p.Birthday,
                                             p.IdGender,
                                             g.GenderName,
                                             p.Address,
                                             p.Phone,
                                             p.Town,
                                             p.PostCode,
                                         });
                    tbNik.Text = PassengerEdit.FirstOrDefault().NIK;
                    tbFirstName.Text = PassengerEdit.FirstOrDefault().FirstName;
                    tbLastName.Text = PassengerEdit.FirstOrDefault().LastName;
                    dtpBirthday.Value = DateTime.Parse(PassengerEdit.FirstOrDefault().Birthday.ToString("yyyy/MM/dd"));
                    cbGender.SelectedValue = PassengerEdit.FirstOrDefault().IdGender;
                    rtbAddress.Text = PassengerEdit.FirstOrDefault().Address;
                    tbTown.Text = PassengerEdit.FirstOrDefault().Town;
                    tbPhone.Text = PassengerEdit.FirstOrDefault().Phone;
                    tbPostCode.Text = PassengerEdit.FirstOrDefault().PostCode;
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
                tbNik.ResetText();
                tbFirstName.ResetText();
                tbLastName.ResetText();
                dtpBirthday.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                cbGender.SelectedIndex = -1;
                rtbAddress.ResetText();
                tbTown.ResetText();
                tbPhone.ResetText();
                tbPostCode.ResetText();
                bDelete.Enabled = true;
                bEdit.Enabled = true;
            }
        }

        private bool DeletePassenger()
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this Ticket Type ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    psngr = dc.Passengers.FirstOrDefault(x => x.Id == Convert.ToInt32(dgPassenger.CurrentRow.Cells[0].Value));
                    using (TransactionScope ts = new TransactionScope())
                    {
                        if (psngr != null)
                        {
                            dc.Passengers.DeleteOnSubmit(psngr);
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
                if (act != "insert")
                {
                    string currentNik = dc.Passengers.First(i => i.Id == Convert.ToInt32(lbIdValue.Text)).NIK;
                    string Nik = tbNik.Text.Trim();

                    if (currentNik != Nik)
                    {
                        if (dc.Passengers.First(i => i.NIK == Nik) != null)
                        {
                            MessageBox.Show("NIK already taken", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
                using (TransactionScope ts = new TransactionScope())
                {
                    psngr = act == "insert" ? new Passenger() : dc.Passengers.FirstOrDefault(id => id.Id == Convert.ToInt32(lbIdValue.Text));
                    psngr.NIK = tbNik.Text.Trim();
                    psngr.FirstName = tbFirstName.Text.Trim();
                    psngr.LastName = tbLastName.Text.Trim();
                    psngr.Birthday = DateTime.ParseExact(dtpBirthday.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture); 
                    psngr.IdGender = Convert.ToInt32(cbGender.SelectedValue);
                    psngr.Address = rtbAddress.Text.Trim();
                    psngr.Town = tbTown.Text.Trim();
                    psngr.PostCode = String.IsNullOrEmpty(tbPostCode.Text.Trim()) ? null : tbPostCode.Text.Trim();
                    psngr.Phone = String.IsNullOrEmpty(tbPhone.Text.Trim()) ? null : tbPostCode.Text.Trim();
                    if (act == "insert")
                        dc.Passengers.InsertOnSubmit(psngr);
                    dc.SubmitChanges();
                    ts.Complete();
                    if (act != "insert")
                    {
                        lbIdValue.Text = "";
                        lbIdValue.Visible = false;
                        lbID.Visible = false;
                        bCancel.Visible = false;
                    }
                    tbNik.ResetText();
                    tbFirstName.ResetText();
                    tbLastName.ResetText();
                    cbGender.SelectedIndex = -1;
                    dtpBirthday.Value = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd"));
                    rtbAddress.ResetText();
                    tbTown.ResetText();
                    tbPostCode.ResetText();
                    tbPhone.ResetText();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }

        private void LoadGender()
        {
            var gender = dc.GenderLists.Select(x => x).ToList();
            this.cbGender.DataSource = gender;
            this.cbGender.DisplayMember = "GenderName";
            this.cbGender.ValueMember = "Id";
        }

        private void LoadGrid(int page)
        {
            int selected = Convert.ToInt32(this.cbLoadItem.SelectedItem.ToString());
            var get = (from p in dc.Passengers
                       join g in dc.GenderLists
                       on p.IdGender equals g.Id
                       where p.NIK.Contains(tbSearch.Text.Trim()) ||
                       (p.FirstName + " " + p.LastName).Contains(tbSearch.Text.Trim())
                       select new
                       {
                           p.Id,
                           p.NIK,
                           Name = p.FirstName + " " + p.LastName,
                           p.Birthday,
                           g.GenderName,
                           p.Address,
                           p.Phone,
                           p.Town,
                           p.PostCode,
                       });

            if (get.Count() <= selected)
                this.Page = 0;

            int skip = selected;
            int totalskip = page * skip;
            int take = selected;
            int currentpage;

            var loadsource = get.Skip(totalskip).Take(take);
            this.dgPassenger.DataSource = loadsource.ToList();

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

        private void frPassenger_Load(object sender, EventArgs e)
        {
            DisableButton();
            this.cbGender.SelectedIndex = -1;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            UpdateState();
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

        private void tbNik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true; 
        }

        private void tbPostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true; 
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true; 
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (DeletePassenger() == true)
            {
                MessageBox.Show("Data successfully deleted", Application.ProductName);
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
    }
}
