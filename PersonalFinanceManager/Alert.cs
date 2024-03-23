using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceManager
{
    internal class Alert
    {
        public static void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InfoMessage(string message)
        {
            MessageBox.Show(message, "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
