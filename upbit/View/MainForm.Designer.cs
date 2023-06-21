namespace upbit.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_Account = new System.Windows.Forms.DataGridView();
            this.account_market = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_avgPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_curPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_START = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Account)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 288);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_Account);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "잔고";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Account
            // 
            this.dataGridView_Account.AllowUserToAddRows = false;
            this.dataGridView_Account.AllowUserToDeleteRows = false;
            this.dataGridView_Account.AllowUserToResizeColumns = false;
            this.dataGridView_Account.AllowUserToResizeRows = false;
            this.dataGridView_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.account_market,
            this.account_profit,
            this.account_quantity,
            this.account_avgPrice,
            this.account_curPrice});
            this.dataGridView_Account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Account.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Account.Name = "dataGridView_Account";
            this.dataGridView_Account.RowTemplate.Height = 30;
            this.dataGridView_Account.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Account.Size = new System.Drawing.Size(555, 252);
            this.dataGridView_Account.TabIndex = 0;
            this.dataGridView_Account.SelectionChanged += new System.EventHandler(this.dataGridView_Account_SelectionChanged);
            // 
            // account_market
            // 
            this.account_market.HeaderText = "마켓";
            this.account_market.Name = "account_market";
            this.account_market.ReadOnly = true;
            // 
            // account_profit
            // 
            this.account_profit.HeaderText = "수익률";
            this.account_profit.Name = "account_profit";
            this.account_profit.ReadOnly = true;
            // 
            // account_quantity
            // 
            this.account_quantity.HeaderText = "보유수량";
            this.account_quantity.Name = "account_quantity";
            this.account_quantity.ReadOnly = true;
            // 
            // account_avgPrice
            // 
            this.account_avgPrice.HeaderText = "평균매수가";
            this.account_avgPrice.Name = "account_avgPrice";
            this.account_avgPrice.ReadOnly = true;
            // 
            // account_curPrice
            // 
            this.account_curPrice.HeaderText = "현재가";
            this.account_curPrice.Name = "account_curPrice";
            this.account_curPrice.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "모니터링";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.25552F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.74448F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 317);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_START});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(575, 23);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_START
            // 
            this.toolStripButton_START.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_START.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_START.Image")));
            this.toolStripButton_START.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_START.Name = "toolStripButton_START";
            this.toolStripButton_START.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton_START.Text = "START";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 317);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Account)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_market;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_avgPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_curPrice;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_START;
    }
}