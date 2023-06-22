using System;
using System.Windows.Forms;
using upbit.Controller;
using upbit.UpbitAPI; 

namespace upbit.View
{
    public partial class MainForm : Form
    {
        private APIClass api;
        private Running running;
        public MainForm(APIClass api)
        {
            InitializeComponent();
            this.api = api;
            this.FormClosing += ReceiveFormClosingEvent;
            this.running = new Running(api);
            InitDataGridView();
            SetReceiveFunction();
        }

        private void InitDataGridView()
        {
            SetDataGridViewColMiddleCenter(dataGridView_Account);
        }

        private void SetDataGridViewColMiddleCenter(DataGridView grid)
        {
            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void ReceiveFormClosingEvent(object sender, FormClosingEventArgs e)
        {
            if (sender.Equals(this))
            {
                running.stop();

                if (selectCoinForm != null)
                {
                    selectCoinForm.Close();
                    selectCoinForm = null;
                }
            }
            else if (sender.Equals(selectCoinForm))
            {
                selectCoinForm = null;
            }
        }

        private void SetReceiveFunction()
        {
            toolStripButton_START.Click += ReceiveButtonEvent;
            toolStripButton_SelectCoin.Click += ReceiveButtonEvent;
        }

        private void dataGridView_Account_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_Account.ClearSelection();
        }
    }
}
