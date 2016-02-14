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
    public partial class frMain : Form
    {

        private void SetCurrentForm(String form)
        {
            foreach(Control ctl in this.pnlLeft.Controls)
            {
                if (ctl.GetType() == typeof(Button))
                {                 
                    if (ctl.Name == form)
                    {
                        ctl.BackColor = Color.FromArgb(102, 102, 102);
                    }
                    else
                    {
                        ctl.BackColor = Color.FromArgb(41, 41, 41);
                    }   
                }
            }
        }

        public void SetBreadCrumb(String breadcrumb)
        {
            this.lbBreadcrumb.Text = breadcrumb == "Home" ? "Home" : "Home > " + breadcrumb; 
        }

        public frMain()
        {
            InitializeComponent();
            frWelcome fr = new frWelcome(this);
            this.pnlMid.Controls.Clear();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            fr.Show();
            this.pnlMid.Controls.Add(fr);
            SetCurrentForm("bHome");
            SetBreadCrumb("Home");
        }
        
        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ex = MessageBox.Show(this, "Apakah anda ingin keluar dari aplikasi ini?", "Keluar Aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ex == DialogResult.No)
                e.Cancel = true;
        }

        private void bBus_Click(object sender, EventArgs e)
        {
            frMenuBus fr = new frMenuBus(this);
            this.pnlMid.Controls.Clear();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            fr.Show();
            this.pnlMid.Controls.Add(fr);
            SetCurrentForm("bBus");
            SetBreadCrumb("Menu Bus");
        }

        private void bRoute_Click(object sender, EventArgs e)
        {
            frMenuRoute fr = new frMenuRoute(this);
            this.pnlMid.Controls.Clear();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            fr.Show();
            this.pnlMid.Controls.Add(fr);
            SetCurrentForm("bRoute");
            SetBreadCrumb("Menu Route");
        }

        private void bSchedule_Click(object sender, EventArgs e)
        {

        }

        private void bBooking_Click(object sender, EventArgs e)
        {

        }

        private void bHome_Click(object sender, EventArgs e)
        {
            frWelcome fr = new frWelcome(this);
            this.pnlMid.Controls.Clear();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            fr.Show();
            this.pnlMid.Controls.Add(fr);
            SetCurrentForm("bHome");
            SetBreadCrumb("Home");
        }

        private void bPricing_Click(object sender, EventArgs e)
        {
            frPricing fr = new frPricing(this);
            this.pnlMid.Controls.Clear();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            fr.Show();
            this.pnlMid.Controls.Add(fr);
            SetCurrentForm("bPricing");
            SetBreadCrumb("Pricing");
        }

        private void bPassenger_Click(object sender, EventArgs e)
        {
            frPassenger fr = new frPassenger(this);
            this.pnlMid.Controls.Clear();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            fr.Show();
            this.pnlMid.Controls.Add(fr);
            SetCurrentForm("bPassenger");
            SetBreadCrumb("Passenger");
        }

        private void bTicketType_Click(object sender, EventArgs e)
        {
            frTicketType fr = new frTicketType(this);
            this.pnlMid.Controls.Clear();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            fr.Show();
            this.pnlMid.Controls.Add(fr);
            SetCurrentForm("bTicketType");
            SetBreadCrumb("Ticket Type");
        }
    }
}
