using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upbit.View
{
    internal class MainFormButton
    {
    }

    public partial class MainForm
    {
        private SelectCoinForm selectCoinForm;
        private void ReceiveButtonEvent(object sender, EventArgs e)
        {
            if (sender.Equals(toolStripButton_START))
            {             
                Console.WriteLine("시작버튼클릭");
                running.Go();
            }
            else if (sender.Equals(toolStripButton_SelectCoin))
            {
                if (selectCoinForm != null) { return; }
                selectCoinForm = new SelectCoinForm(this.api);
                selectCoinForm.FormClosing += ReceiveFormClosingEvent;

                selectCoinForm.StartPosition = FormStartPosition.Manual;
                selectCoinForm.Owner = this;
                selectCoinForm.Location = this.Location;
                selectCoinForm.Show();
            }
        }
    }
}
