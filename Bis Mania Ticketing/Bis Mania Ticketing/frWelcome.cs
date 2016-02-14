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
    public partial class frWelcome : Form
    {
        frMain frM;

        public frWelcome(Form fr)
        {
            InitializeComponent();
            frM = fr as frMain;
        }
    }
}
