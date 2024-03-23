using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceManager
{
    internal class keycontrol
    {
        public static void AllowOnlyLetters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void AllowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void AllowOnlyLettersAndNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void TriggerButtonClickOnRightArrow(object sender, KeyEventArgs e, Button button)
        {
            if (e.KeyCode == Keys.Oemplus)
            {
                button.PerformClick();
                e.Handled = true;
            }
        }

        public static void KeyDownEnterAndPlus(object sender, KeyEventArgs e, Button button1, Button button2)
        {
            if (e.KeyCode == Keys.Oemplus)
            {
                button1.PerformClick();
            };
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button2.PerformClick();
            }
        }

        public static void KeyDownEnterNextButtonClick(object sender, KeyEventArgs e, Button button)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button.PerformClick();
            }
        }

        public static void KeyDownEnterNextTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Control control = sender as Control;
                if (control != null)
                {
                    Form form = control.FindForm();
                    form?.SelectNextControl(control, true, true, true, true);
                }
                ComboBox comboBox = sender as ComboBox;
                if (comboBox != null && comboBox.AutoCompleteMode != AutoCompleteMode.None)
                {
                    // Find the suggested item that matches the current text
                    string currentText = comboBox.Text;
                    for (int i = 0; i < comboBox.Items.Count; i++)
                    {
                        string itemText = comboBox.GetItemText(comboBox.Items[i]);
                        if (itemText.StartsWith(currentText))
                        {
                            comboBox.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        public static void RemoveKeyPress(TextBox txb)
        {
            txb.KeyPress -= AllowOnlyLetters;
            txb.KeyPress -= AllowOnlyNumbers;
        }
    }
}
