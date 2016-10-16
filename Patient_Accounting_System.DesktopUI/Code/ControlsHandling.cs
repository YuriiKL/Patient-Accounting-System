using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Accounting_System.DesktopUI.Code
{
    class ControlsHandling
    {
        public static void HandleTextChanged(List<string> dataSource, ComboBox comboBox)
        {
            var text = comboBox.Text;

            if (dataSource.Count() > 0)
            {
                comboBox.DataSource = dataSource;
                var sText = comboBox.Items[0].ToString();
                comboBox.SelectionStart = text.Length;
                comboBox.SelectionLength = sText.Length - text.Length;
                return;
            }
            else
            {
                comboBox.DroppedDown = false;
                comboBox.SelectionStart = text.Length;
            }
        }
    }
}
