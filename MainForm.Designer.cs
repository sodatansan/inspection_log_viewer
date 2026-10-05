namespace inspection_log_viewer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtKeyword = new TextBox();
            btnSearch = new Button();
            dgvResults = new DataGridView();
            txtMachine = new TextBox();
            txtProduct = new TextBox();
            txtCategory = new TextBox();
            btnRegister = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNote = new TextBox();
            txtAction = new TextBox();
            txtContent = new TextBox();
            txtLocation = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // txtKeyword
            // 
            txtKeyword.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtKeyword.Font = new Font("Yu Gothic UI", 10F);
            txtKeyword.Location = new Point(368, 496);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(172, 34);
            txtKeyword.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Font = new Font("Yu Gothic UI", 10F);
            btnSearch.Location = new Point(546, 496);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(134, 35);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "検索";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvResults
            // 
            dgvResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(165, 42);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 62;
            dgvResults.Size = new Size(771, 430);
            dgvResults.TabIndex = 2;
            dgvResults.CellClick += dgvResults_CellClick;
            // 
            // txtMachine
            // 
            txtMachine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMachine.Location = new Point(594, 41);
            txtMachine.Name = "txtMachine";
            txtMachine.Size = new Size(150, 34);
            txtMachine.TabIndex = 4;
            // 
            // txtProduct
            // 
            txtProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtProduct.Location = new Point(594, 94);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(150, 34);
            txtProduct.TabIndex = 5;
            // 
            // txtCategory
            // 
            txtCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCategory.Location = new Point(594, 146);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(150, 34);
            txtCategory.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom;
            btnRegister.Location = new Point(469, 482);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 35);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "登録";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tabControl1.Location = new Point(3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1101, 614);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(dgvResults);
            tabPage1.Controls.Add(txtKeyword);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(1093, 573);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "検索";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtNote);
            tabPage2.Controls.Add(txtAction);
            tabPage2.Controls.Add(txtContent);
            tabPage2.Controls.Add(txtLocation);
            tabPage2.Controls.Add(txtMachine);
            tabPage2.Controls.Add(btnRegister);
            tabPage2.Controls.Add(txtProduct);
            tabPage2.Controls.Add(txtCategory);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(1093, 573);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "登録";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(344, 373);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 18;
            label7.Text = "備考(任意)";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(344, 316);
            label6.Name = "label6";
            label6.Size = new Size(72, 28);
            label6.TabIndex = 17;
            label6.Text = "対処法";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(344, 263);
            label5.Name = "label5";
            label5.Size = new Size(144, 28);
            label5.TabIndex = 16;
            label5.Text = "内容(自由記述)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(344, 205);
            label4.Name = "label4";
            label4.Size = new Size(248, 28);
            label4.TabIndex = 15;
            label4.Text = "場所(爪搬送部、反転部など)";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(344, 152);
            label3.Name = "label3";
            label3.Size = new Size(237, 28);
            label3.TabIndex = 14;
            label3.Text = "種別(機械異常、寸法不良)";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(344, 100);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 13;
            label2.Text = "製品名/品種";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(344, 47);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 12;
            label1.Text = "機械名";
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNote.Location = new Point(594, 367);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(150, 34);
            txtNote.TabIndex = 11;
            // 
            // txtAction
            // 
            txtAction.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAction.Location = new Point(594, 310);
            txtAction.Name = "txtAction";
            txtAction.Size = new Size(150, 34);
            txtAction.TabIndex = 10;
            // 
            // txtContent
            // 
            txtContent.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtContent.Location = new Point(594, 257);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(150, 34);
            txtContent.TabIndex = 9;
            // 
            // txtLocation
            // 
            txtLocation.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLocation.Location = new Point(594, 199);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(150, 34);
            txtLocation.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 624);
            Controls.Add(tabControl1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MainForm";
            Text = "検査ログ管理システム";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtKeyword;
        private Button btnSearch;
        private DataGridView dgvResults;
        private TextBox txtMachine;
        private TextBox txtProduct;
        private TextBox txtCategory;
        private Button btnRegister;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNote;
        private TextBox txtAction;
        private TextBox txtContent;
        private TextBox txtLocation;
    }
}
