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
