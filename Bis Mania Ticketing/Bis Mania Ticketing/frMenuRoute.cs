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
    public partial class frMenuRoute : Form
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

        public frMenuRoute(Form owner)
        {
            InitializeComponent();
            frM = owner as frMain;
        }

        private void bStation_Click(object sender, EventArgs e)
        {
            frBusStation frS = new frBusStation();
            this.pnlBody.Controls.Clear();
            frS.TopLevel = false;
            frS.Dock = DockStyle.Fill;
            frS.Show();
            this.pnlBody.Controls.Add(frS);
            frM.SetBreadCrumb("Menu Route > Bus Station");
            SetCurrentForm("bStation");
        }

        private void bRoute_Click(object sender, EventArgs e)
        {
            frRoute frR = new frRoute();
            this.pnlBody.Controls.Clear();
            frR.TopLevel = false;
            frR.Dock = DockStyle.Fill;
            frR.Show();
            this.pnlBody.Controls.Add(frR);
            frM.SetBreadCrumb("Menu Route > Route");
            SetCurrentForm("bRoute");
        }
    }
}
