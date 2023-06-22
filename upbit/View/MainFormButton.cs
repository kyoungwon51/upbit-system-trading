using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upbit.View
{
    internal class MainFormButton
    {
    }

    public partial class MainForm
    {
        private void ReceiveButtonEvent(object sender, EventArgs e)
        {
            if (sender.Equals(toolStripButton_START))
            {             
                Console.WriteLine("시작버튼클릭");
                running.Go();
            }
            else if (sender.Equals(toolStripButton_SelectCoin))
            {

            }
        }
    }
}
