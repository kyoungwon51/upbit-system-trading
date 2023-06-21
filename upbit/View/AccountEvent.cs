using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using upbit.Model;

namespace upbit.View
{
    internal class AccountEvent {}

    public partial class MainForm
    {
        private void ReceiveEventAccountAdd(object sender, AccountClass account)
        {
            if (dataGridView_Account.InvokeRequired)
            {
                dataGridView_Account.Invoke((MethodInvoker)delegate ()
                {

                });
            }

        }

        private void ReceiveEventAccountUpdate(object sender, AccountClass account)
        {
            if (dataGridView_Account.InvokeRequired)
            {
                dataGridView_Account.Invoke((MethodInvoker)delegate ()
                {

                });
            }
        }

        private void ReceiveEventAccountDelete(object sender, string market)
        {
            if (dataGridView_Account.InvokeRequired)
            {
                dataGridView_Account.Invoke((MethodInvoker)delegate ()
                {

                });
            }
        }
    }
}
