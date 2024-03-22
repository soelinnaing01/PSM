namespace PersonalFinanceManager
{
    partial class frm_saving
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addsaving = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpk_saving = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_saving = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_totalamount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_AddWithdrawal = new System.Windows.Forms.Button();
            this.txt_withdrawAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdo_saving = new System.Windows.Forms.RadioButton();
            this.rdo_withdraw = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_saving)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addsaving);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpk_saving);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Monthly Saving";
            // 
            // btn_addsaving
            // 
            this.btn_addsaving.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_addsaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addsaving.ForeColor = System.Drawing.Color.White;
            this.btn_addsaving.Location = new System.Drawing.Point(202, 45);
            this.btn_addsaving.Name = "btn_addsaving";
            this.btn_addsaving.Size = new System.Drawing.Size(75, 32);
            this.btn_addsaving.TabIndex = 3;
            this.btn_addsaving.Text = "Add";
            this.btn_addsaving.UseVisualStyleBackColor = false;
            this.btn_addsaving.Click += new System.EventHandler(this.btn_addsaving_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(79, 63);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(117, 23);
            this.txt_amount.TabIndex = 2;
            this.txt_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_amount_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount :";
            // 
            // dtpk_saving
            // 
            this.dtpk_saving.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_saving.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_saving.Location = new System.Drawing.Point(79, 31);
            this.dtpk_saving.Name = "dtpk_saving";
            this.dtpk_saving.Size = new System.Drawing.Size(117, 23);
            this.dtpk_saving.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month :";
            // 
            // pnl_search
            // 
            this.pnl_search.Location = new System.Drawing.Point(514, 236);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(150, 24);
            this.pnl_search.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(463, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(459, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Filter By :";
            // 
            // dgv_saving
            // 
            this.dgv_saving.AllowUserToAddRows = false;
            this.dgv_saving.AllowUserToDeleteRows = false;
            this.dgv_saving.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_saving.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_saving.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_saving.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_saving.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_saving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_saving.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_saving.EnableHeadersVisualStyles = false;
            this.dgv_saving.GridColor = System.Drawing.Color.Gray;
            this.dgv_saving.Location = new System.Drawing.Point(12, 264);
            this.dgv_saving.Name = "dgv_saving";
            this.dgv_saving.ReadOnly = true;
            this.dgv_saving.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_saving.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_saving.Size = new System.Drawing.Size(652, 285);
            this.dgv_saving.TabIndex = 10;
            this.dgv_saving.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_saving_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Saving :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lbl_totalamount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(317, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 90);
            this.panel1.TabIndex = 0;
            // 
            // lbl_totalamount
            // 
            this.lbl_totalamount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalamount.AutoSize = true;
            this.lbl_totalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalamount.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_totalamount.Location = new System.Drawing.Point(142, 35);
            this.lbl_totalamount.Name = "lbl_totalamount";
            this.lbl_totalamount.Size = new System.Drawing.Size(0, 20);
            this.lbl_totalamount.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_AddWithdrawal);
            this.groupBox2.Controls.Add(this.txt_withdrawAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Withdrawal Saving";
            // 
            // btn_AddWithdrawal
            // 
            this.btn_AddWithdrawal.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_AddWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddWithdrawal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_AddWithdrawal.Location = new System.Drawing.Point(202, 45);
            this.btn_AddWithdrawal.Name = "btn_AddWithdrawal";
            this.btn_AddWithdrawal.Size = new System.Drawing.Size(75, 32);
            this.btn_AddWithdrawal.TabIndex = 5;
            this.btn_AddWithdrawal.Text = "Withdrawal";
            this.btn_AddWithdrawal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AddWithdrawal.UseVisualStyleBackColor = false;
            this.btn_AddWithdrawal.Click += new System.EventHandler(this.btn_AddWithdrawal_Click);
            // 
            // txt_withdrawAmount
            // 
            this.txt_withdrawAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_withdrawAmount.Location = new System.Drawing.Point(79, 50);
            this.txt_withdrawAmount.Name = "txt_withdrawAmount";
            this.txt_withdrawAmount.Size = new System.Drawing.Size(117, 23);
            this.txt_withdrawAmount.TabIndex = 4;
            this.txt_withdrawAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_withdrawAmount_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount :";
            // 
            // rdo_saving
            // 
            this.rdo_saving.AutoSize = true;
            this.rdo_saving.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_saving.Location = new System.Drawing.Point(338, 186);
            this.rdo_saving.Name = "rdo_saving";
            this.rdo_saving.Size = new System.Drawing.Size(75, 21);
            this.rdo_saving.TabIndex = 6;
            this.rdo_saving.TabStop = true;
            this.rdo_saving.Text = "Saving";
            this.rdo_saving.UseVisualStyleBackColor = true;
            this.rdo_saving.CheckedChanged += new System.EventHandler(this.rdo_saving_CheckedChanged);
            // 
            // rdo_withdraw
            // 
            this.rdo_withdraw.AutoSize = true;
            this.rdo_withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_withdraw.Location = new System.Drawing.Point(338, 223);
            this.rdo_withdraw.Name = "rdo_withdraw";
            this.rdo_withdraw.Size = new System.Drawing.Size(105, 21);
            this.rdo_withdraw.TabIndex = 7;
            this.rdo_withdraw.TabStop = true;
            this.rdo_withdraw.Text = "Withdrawal";
            this.rdo_withdraw.UseVisualStyleBackColor = true;
            this.rdo_withdraw.CheckedChanged += new System.EventHandler(this.rdo_withdraw_CheckedChanged);
            // 
            // frm_saving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 561);
            this.Controls.Add(this.rdo_withdraw);
            this.Controls.Add(this.rdo_saving);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_saving);
            this.Controls.Add(this.pnl_search);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_saving";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saving";
            this.Load += new System.EventHandler(this.frm_saving_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_saving)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addsaving;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpk_saving;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_saving;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_totalamount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AddWithdrawal;
        private System.Windows.Forms.TextBox txt_withdrawAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdo_saving;
        private System.Windows.Forms.RadioButton rdo_withdraw;
    }
}