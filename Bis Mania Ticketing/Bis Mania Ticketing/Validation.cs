using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
namespace Bis_Mania_Ticketing
{
    class Validation
    {
        Control.ControlCollection collection;
        
        public Validation(Control.ControlCollection collection)
        {
            this.collection = collection;
        }
        
        public bool Validate(List<Control> skipctl)
        {
            foreach(Control ctl in this.collection)
            {
                if (ctl.GetType() == typeof(MetroTextBox) || ctl.GetType() == typeof(TextBox) || ctl.GetType() == typeof(RichTextBox))
                {
                    if (skipctl.Exists(x => x.Name == ctl.Name) == false)
                    {
                        if (String.IsNullOrEmpty(ctl.Text))
                        {
                            MessageBox.Show("Field(s) cannot be empty", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }         
                }
                else if (ctl.GetType() == typeof(ComboBox) || ctl.GetType() == typeof(MetroComboBox))
                {
                    if (skipctl.Exists(x => x.Name == ctl.Name) == false)
                    {
                        if (((MetroComboBox)ctl).SelectedIndex < 0)
                        {
                            MessageBox.Show("Field(s) cannot be empty", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else if(ctl.GetType() == typeof(NumericUpDown))
                {
                    if (skipctl.Exists(x => x.Name == ctl.Name) == false)
                    {
                        if (String.IsNullOrEmpty(((NumericUpDown)ctl).Value.ToString()))
                        {
                            MessageBox.Show("Field(s) cannot be empty", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            return true;

        }
    }
}
