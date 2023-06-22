namespace upbit.View
{
    partial class SelectCoinForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_ToRight = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.dataGridView_Left = new System.Windows.Forms.DataGridView();
            this.dataGridView_Right = new System.Windows.Forms.DataGridView();
            this.RightCol_Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RightCol_Market = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Right_Korean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Left_Market = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Right)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_save, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.17647F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.82353F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 398);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView_Left, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView_Right, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(446, 333);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.button_ToRight, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(264, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(71, 325);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // button_ToRight
            // 
            this.button_ToRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ToRight.Location = new System.Drawing.Point(3, 141);
            this.button_ToRight.Name = "button_ToRight";
            this.button_ToRight.Size = new System.Drawing.Size(65, 42);
            this.button_ToRight.TabIndex = 0;
            this.button_ToRight.Text = "▶";
            this.button_ToRight.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_save.Location = new System.Drawing.Point(3, 342);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(446, 53);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "저장";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Left
            // 
            this.dataGridView_Left.AllowUserToAddRows = false;
            this.dataGridView_Left.AllowUserToDeleteRows = false;
            this.dataGridView_Left.AllowUserToResizeColumns = false;
            this.dataGridView_Left.AllowUserToResizeRows = false;
            this.dataGridView_Left.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Left.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RightCol_Select,
            this.RightCol_Market,
            this.Right_Korean});
            this.dataGridView_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Left.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_Left.Name = "dataGridView_Left";
            this.dataGridView_Left.RowHeadersVisible = false;
            this.dataGridView_Left.RowTemplate.Height = 30;
            this.dataGridView_Left.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Left.Size = new System.Drawing.Size(253, 325);
            this.dataGridView_Left.TabIndex = 1;
           
            // dataGridView_Right
            // 
            this.dataGridView_Right.AllowUserToAddRows = false;
            this.dataGridView_Right.AllowUserToDeleteRows = false;
            this.dataGridView_Right.AllowUserToResizeColumns = false;
            this.dataGridView_Right.AllowUserToResizeRows = false;
            this.dataGridView_Right.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Right.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Left_Market});
            this.dataGridView_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Right.Location = new System.Drawing.Point(342, 4);
            this.dataGridView_Right.Name = "dataGridView_Right";
            this.dataGridView_Right.RowHeadersVisible = false;
            this.dataGridView_Right.RowTemplate.Height = 30;
            this.dataGridView_Right.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Right.Size = new System.Drawing.Size(177, 325);
            this.dataGridView_Right.TabIndex = 2;
           
            // 
            // RightCol_Select
            // 
            this.RightCol_Select.FillWeight = 50F;
            this.RightCol_Select.HeaderText = "선택";
            this.RightCol_Select.Name = "RightCol_Select";
            this.RightCol_Select.ReadOnly = true;
            this.RightCol_Select.Width = 50;
            // 
            // RightCol_Market
            // 
            this.RightCol_Market.HeaderText = "Market";
            this.RightCol_Market.Name = "RightCol_Market";
            this.RightCol_Market.ReadOnly = true;
            this.RightCol_Market.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RightCol_Market.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Right_Korean
            // 
            this.Right_Korean.HeaderText = "이름";
            this.Right_Korean.Name = "Right_Korean";
            this.Right_Korean.ReadOnly = true;
            this.Right_Korean.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Right_Korean.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Left_Market
            // 
            this.Left_Market.HeaderText = "Market";
            this.Left_Market.Name = "Left_Market";
            this.Left_Market.ReadOnly = true;
            // 
            // SelectCoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 398);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SelectCoinForm";
            this.Text = "SelectCoinForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Right)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_ToRight;
        private System.Windows.Forms.DataGridView dataGridView_Left;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataGridView dataGridView_Right;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RightCol_Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightCol_Market;
        private System.Windows.Forms.DataGridViewTextBoxColumn Right_Korean;
        private System.Windows.Forms.DataGridViewTextBoxColumn Left_Market;
    }
}