using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bis_Mania_Ticketing
{
    public partial class frMenuBus : Form
    {
        frMain frM;
        private void SetCurrentForm(String form)
        {
            foreach (Control ctl in this.pnlTop.Controls)
            {
                if (ctl.GetType() == typeof(Button))
                {
                    if (ctl.Name == form)
                    {
                        ctl.BackColor = Color.FromArgb(0, 105, 92);
                    }
                    else
                    {
                        ctl.BackColor = Color.FromArgb(5, 125, 113);
                    }
                }
            }
        }

        
        public frMenuBus(Form owner)
        {
            InitializeComponent();
            frM = owner as frMain;
        }

        private void bBus_Click(object sender, EventArgs e)
        {
            frBus frB = new frBus();
            this.pnlBody.Controls.Clear();
            frB.TopLevel = false;
            frB.Dock = DockStyle.Fill;
            frB.Show();
            this.pnlBody.Controls.Add(frB);
            frM.SetBreadCrumb("Menu Bus > Bus");
            SetCurrentForm("bBus");
        }

        private void bOtobus_Click(object sender, EventArgs e)
        {
            frOtobus frO = new frOtobus();
            this.pnlBody.Controls.Clear();
            frO.TopLevel = false;
            frO.Dock = DockStyle.Fill;
            frO.Show();
            this.pnlBody.Controls.Add(frO);
            frM.SetBreadCrumb("Menu Bus > Otobus");
            SetCurrentForm("bOtobus");
        }
    }
}
