using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using upbit.UpbitAPI;
using upbit.Model;
using upbit.Controller;

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
        }

        private void dataGridView_Account_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_Account.ClearSelection();
        }
    }
}
