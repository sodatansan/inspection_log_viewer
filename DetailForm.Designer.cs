namespace inspection_log_viewer
{
    partial class DetailForm
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
            lblDetail = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblDetail
            // 
            lblDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDetail.AutoSize = true;
            lblDetail.BackColor = SystemColors.Control;
            lblDetail.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblDetail.Location = new Point(337, 94);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(84, 45);
            lblDetail.TabIndex = 4;
            lblDetail.Text = "詳細";
            lblDetail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.None;
            btnEdit.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnEdit.Location = new Point(439, 558);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 43);
            btnEdit.TabIndex = 34;
            btnEdit.Text = "編集";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.Location = new Point(439, 607);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 43);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "削除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // DetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 684);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lblDetail);
            Name = "DetailForm";
            Text = "詳細情報";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDetail;
        private Button btnEdit;
        private Button btnDelete;
    }
}