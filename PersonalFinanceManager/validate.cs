using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceManager
{
    internal class validate
    {
        //Check validating by group 
        public static bool TextCheck(Control control)
        {
            bool messageShown = false;
            foreach (var item in control.Controls)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        MessageBox.Show("Textbox is empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Focus();
                        messageShown = true;
                        break;
                    }
                }
                else if (item is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)item;
                    if (comboBox.SelectedItem == null)
                    {
                        MessageBox.Show("You must choose one value!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comboBox.Focus();
                        messageShown = true;
                        break;
                    }
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)item;
                    DateTime currentDate = DateTime.Now;
                    if (dateTimePicker.Value.Month != currentDate.Month || dateTimePicker.Value.Year != currentDate.Year)
                    {
                        MessageBox.Show("Date must be within the current month and year!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dateTimePicker.Focus();
                        messageShown = true;
                        break;
                    }
                    else if (dateTimePicker.Value.Date > currentDate.Date)
                    {
                        MessageBox.Show("Date cannot be greater than the current date!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dateTimePicker.Focus();
                        messageShown = true;
                        break;
                    }
                }
            }
            return messageShown;
        }

        public static void ControlClear(Control control)
        {
            foreach (var item in control.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)item;
                    comboBox.SelectedItem = null;
                }
                else if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    textBox.Text = null;
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dtpk = (DateTimePicker)item;
                    dtpk.Value = DateTime.Now;
                }
            }
        }
    }
}
