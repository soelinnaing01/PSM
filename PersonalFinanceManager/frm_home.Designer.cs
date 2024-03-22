namespace PersonalFinanceManager
{
    partial class frm_home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbx_function = new System.Windows.Forms.GroupBox();
            this.btnSaving = new System.Windows.Forms.Button();
            this.btnBudget = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_refersh = new System.Windows.Forms.Button();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_monthly = new System.Windows.Forms.RadioButton();
            this.rdo_yearly = new System.Windows.Forms.RadioButton();
            this.cbo_title = new System.Windows.Forms.ComboBox();
            this.cbo_function = new System.Windows.Forms.ComboBox();
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.pnl_chart = new System.Windows.Forms.Panel();
            this.gbx_function.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_function
            // 
            this.gbx_function.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbx_function.BackColor = System.Drawing.Color.Gainsboro;
            this.gbx_function.Controls.Add(this.btnSaving);
            this.gbx_function.Controls.Add(this.btnBudget);
            this.gbx_function.Controls.Add(this.btnExpense);
            this.gbx_function.Controls.Add(this.btnIncome);
            this.gbx_function.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbx_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_function.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.gbx_function.Location = new System.Drawing.Point(43, 65);
            this.gbx_function.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_function.Name = "gbx_function";
            this.gbx_function.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_function.Size = new System.Drawing.Size(424, 815);
            this.gbx_function.TabIndex = 1;
            this.gbx_function.TabStop = false;
            this.gbx_function.Text = "Functions";
            // 
            // btnSaving
            // 
            this.btnSaving.BackColor = System.Drawing.Color.Indigo;
            this.btnSaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaving.ForeColor = System.Drawing.Color.White;
            this.btnSaving.Image = global::PersonalFinanceManager.Properties.Resources.icons8_saving_50;
            this.btnSaving.Location = new System.Drawing.Point(227, 212);
            this.btnSaving.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaving.Name = "btnSaving";
            this.btnSaving.Size = new System.Drawing.Size(175, 123);
            this.btnSaving.TabIndex = 4;
            this.btnSaving.Text = "Saving";
            this.btnSaving.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaving.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaving.UseVisualStyleBackColor = false;
            // 
            // btnBudget
            // 
            this.btnBudget.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBudget.ForeColor = System.Drawing.Color.White;
            this.btnBudget.Image = global::PersonalFinanceManager.Properties.Resources.icons8_fund_50;
            this.btnBudget.Location = new System.Drawing.Point(20, 212);
            this.btnBudget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(175, 123);
            this.btnBudget.TabIndex = 3;
            this.btnBudget.Text = "Budget";
            this.btnBudget.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBudget.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBudget.UseVisualStyleBackColor = false;
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.Color.Crimson;
            this.btnExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpense.ForeColor = System.Drawing.Color.White;
            this.btnExpense.Image = global::PersonalFinanceManager.Properties.Resources.expense;
            this.btnExpense.Location = new System.Drawing.Point(227, 54);
            this.btnExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(175, 123);
            this.btnExpense.TabIndex = 2;
            this.btnExpense.Text = "Expense";
            this.btnExpense.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExpense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExpense.UseVisualStyleBackColor = false;
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.Chartreuse;
            this.btnIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.Image = global::PersonalFinanceManager.Properties.Resources.income;
            this.btnIncome.Location = new System.Drawing.Point(20, 54);
            this.btnIncome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(175, 123);
            this.btnIncome.TabIndex = 1;
            this.btnIncome.Text = "Income";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncome.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1427, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logined by :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_name.Location = new System.Drawing.Point(1565, 11);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 20);
            this.lbl_name.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.btn_refersh);
            this.groupBox1.Controls.Add(this.lbl_balance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(496, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(597, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_refersh
            // 
            this.btn_refersh.BackColor = System.Drawing.Color.White;
            this.btn_refersh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refersh.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refersh.Image = global::PersonalFinanceManager.Properties.Resources.icons8_refresh_20;
            this.btn_refersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refersh.Location = new System.Drawing.Point(549, 12);
            this.btn_refersh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_refersh.Name = "btn_refersh";
            this.btn_refersh.Size = new System.Drawing.Size(40, 32);
            this.btn_refersh.TabIndex = 0;
            this.btn_refersh.TabStop = false;
            this.btn_refersh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refersh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_refersh.UseVisualStyleBackColor = false;
            this.btn_refersh.Click += new System.EventHandler(this.btn_refersh_Click);
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(211, 39);
            this.lbl_balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(0, 29);
            this.lbl_balance.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(35, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "BALANCE :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox2.Controls.Add(this.rdo_monthly);
            this.groupBox2.Controls.Add(this.rdo_yearly);
            this.groupBox2.Controls.Add(this.cbo_title);
            this.groupBox2.Controls.Add(this.cbo_function);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(496, 193);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(597, 190);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report";
            // 
            // rdo_monthly
            // 
            this.rdo_monthly.AutoSize = true;
            this.rdo_monthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_monthly.Location = new System.Drawing.Point(147, 47);
            this.rdo_monthly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdo_monthly.Name = "rdo_monthly";
            this.rdo_monthly.Size = new System.Drawing.Size(95, 24);
            this.rdo_monthly.TabIndex = 6;
            this.rdo_monthly.TabStop = true;
            this.rdo_monthly.Text = "Monthly";
            this.rdo_monthly.UseVisualStyleBackColor = true;
            // 
            // rdo_yearly
            // 
            this.rdo_yearly.AutoSize = true;
            this.rdo_yearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_yearly.Location = new System.Drawing.Point(29, 47);
            this.rdo_yearly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdo_yearly.Name = "rdo_yearly";
            this.rdo_yearly.Size = new System.Drawing.Size(82, 24);
            this.rdo_yearly.TabIndex = 5;
            this.rdo_yearly.TabStop = true;
            this.rdo_yearly.Text = "Yearly";
            this.rdo_yearly.UseVisualStyleBackColor = true;
            // 
            // cbo_title
            // 
            this.cbo_title.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_title.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_title.FormattingEnabled = true;
            this.cbo_title.Location = new System.Drawing.Point(296, 103);
            this.cbo_title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_title.Name = "cbo_title";
            this.cbo_title.Size = new System.Drawing.Size(215, 28);
            this.cbo_title.TabIndex = 8;
            this.cbo_title.SelectedIndexChanged += new System.EventHandler(this.cbo_title_SelectedIndexChanged);
            // 
            // cbo_function
            // 
            this.cbo_function.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_function.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_function.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_function.FormattingEnabled = true;
            this.cbo_function.Items.AddRange(new object[] {
            "Income",
            "Expense",
            "Budget",
            "Saving",
            "Withdrawal"});
            this.cbo_function.Location = new System.Drawing.Point(52, 103);
            this.cbo_function.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_function.Name = "cbo_function";
            this.cbo_function.Size = new System.Drawing.Size(215, 28);
            this.cbo_function.TabIndex = 7;
            this.cbo_function.SelectedIndexChanged += new System.EventHandler(this.cbo_function_SelectedIndexChanged);
            // 
            // dgv_report
            // 
            this.dgv_report.AllowUserToAddRows = false;
            this.dgv_report.AllowUserToDeleteRows = false;
            this.dgv_report.AllowUserToResizeColumns = false;
            this.dgv_report.AllowUserToResizeRows = false;
            this.dgv_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_report.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_report.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_report.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report.EnableHeadersVisualStyles = false;
            this.dgv_report.GridColor = System.Drawing.Color.Gray;
            this.dgv_report.Location = new System.Drawing.Point(496, 410);
            this.dgv_report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.ReadOnly = true;
            this.dgv_report.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_report.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_report.Size = new System.Drawing.Size(597, 154);
            this.dgv_report.TabIndex = 0;
            this.dgv_report.TabStop = false;
            // 
            // pnl_chart
            // 
            this.pnl_chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_chart.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_chart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_chart.Location = new System.Drawing.Point(1117, 65);
            this.pnl_chart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_chart.Name = "pnl_chart";
            this.pnl_chart.Size = new System.Drawing.Size(663, 498);
            this.pnl_chart.TabIndex = 0;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 895);
            this.Controls.Add(this.pnl_chart);
            this.Controls.Add(this.dgv_report);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbx_function);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1813, 932);
            this.Name = "frm_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_home_FormClosed);
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_home_KeyDown);
            this.gbx_function.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_function;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Button btn_refersh;
        private System.Windows.Forms.Button btnBudget;
        private System.Windows.Forms.Button btnSaving;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_function;
        private System.Windows.Forms.ComboBox cbo_title;
        private System.Windows.Forms.DataGridView dgv_report;
        private System.Windows.Forms.Panel pnl_chart;
        private System.Windows.Forms.RadioButton rdo_monthly;
        private System.Windows.Forms.RadioButton rdo_yearly;
    }
}