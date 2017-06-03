namespace subject_cms.Forms
{
    partial class AddFile
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
            this.filePathLbl = new System.Windows.Forms.Label();
            this.chooseFilePathBtn = new System.Windows.Forms.Button();
            this.f_fileDescriptionTxt = new System.Windows.Forms.TextBox();
            this.f_publicFileChBox = new System.Windows.Forms.CheckBox();
            this.f_filePathLbl = new System.Windows.Forms.Label();
            this.fileDescriptionLbl = new System.Windows.Forms.Label();
            this.addFileBtn = new System.Windows.Forms.Button();
            this.cancelAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filePathLbl
            // 
            this.filePathLbl.AutoSize = true;
            this.filePathLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filePathLbl.Location = new System.Drawing.Point(12, 17);
            this.filePathLbl.Name = "filePathLbl";
            this.filePathLbl.Size = new System.Drawing.Size(57, 22);
            this.filePathLbl.TabIndex = 0;
            this.filePathLbl.Text = "Path: ";
            // 
            // chooseFilePathBtn
            // 
            this.chooseFilePathBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFilePathBtn.Location = new System.Drawing.Point(408, 19);
            this.chooseFilePathBtn.Name = "chooseFilePathBtn";
            this.chooseFilePathBtn.Size = new System.Drawing.Size(103, 25);
            this.chooseFilePathBtn.TabIndex = 1;
            this.chooseFilePathBtn.Text = "Open";
            this.chooseFilePathBtn.UseVisualStyleBackColor = true;
            this.chooseFilePathBtn.Click += new System.EventHandler(this.chooseFilePathBtn_Click);
            // 
            // f_fileDescriptionTxt
            // 
            this.f_fileDescriptionTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f_fileDescriptionTxt.Location = new System.Drawing.Point(12, 108);
            this.f_fileDescriptionTxt.Multiline = true;
            this.f_fileDescriptionTxt.Name = "f_fileDescriptionTxt";
            this.f_fileDescriptionTxt.Size = new System.Drawing.Size(509, 160);
            this.f_fileDescriptionTxt.TabIndex = 2;
            // 
            // f_publicFileChBox
            // 
            this.f_publicFileChBox.AutoSize = true;
            this.f_publicFileChBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_publicFileChBox.Location = new System.Drawing.Point(12, 58);
            this.f_publicFileChBox.Name = "f_publicFileChBox";
            this.f_publicFileChBox.Size = new System.Drawing.Size(67, 22);
            this.f_publicFileChBox.TabIndex = 3;
            this.f_publicFileChBox.Text = "Public";
            this.f_publicFileChBox.UseVisualStyleBackColor = true;
            // 
            // f_filePathLbl
            // 
            this.f_filePathLbl.AutoSize = true;
            this.f_filePathLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_filePathLbl.Location = new System.Drawing.Point(75, 21);
            this.f_filePathLbl.Name = "f_filePathLbl";
            this.f_filePathLbl.Size = new System.Drawing.Size(0, 18);
            this.f_filePathLbl.TabIndex = 4;
            // 
            // fileDescriptionLbl
            // 
            this.fileDescriptionLbl.AutoSize = true;
            this.fileDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileDescriptionLbl.Location = new System.Drawing.Point(8, 83);
            this.fileDescriptionLbl.Name = "fileDescriptionLbl";
            this.fileDescriptionLbl.Size = new System.Drawing.Size(105, 22);
            this.fileDescriptionLbl.TabIndex = 5;
            this.fileDescriptionLbl.Text = "Description:";
            // 
            // addFileBtn
            // 
            this.addFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFileBtn.Location = new System.Drawing.Point(309, 283);
            this.addFileBtn.Name = "addFileBtn";
            this.addFileBtn.Size = new System.Drawing.Size(103, 25);
            this.addFileBtn.TabIndex = 6;
            this.addFileBtn.Text = "Add";
            this.addFileBtn.UseVisualStyleBackColor = true;
            this.addFileBtn.Click += new System.EventHandler(this.addFileBtn_Click);
            // 
            // cancelAddBtn
            // 
            this.cancelAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelAddBtn.Location = new System.Drawing.Point(418, 283);
            this.cancelAddBtn.Name = "cancelAddBtn";
            this.cancelAddBtn.Size = new System.Drawing.Size(103, 25);
            this.cancelAddBtn.TabIndex = 7;
            this.cancelAddBtn.Text = "Cancel";
            this.cancelAddBtn.UseVisualStyleBackColor = true;
            this.cancelAddBtn.Click += new System.EventHandler(this.cancelAddBtn_Click);
            // 
            // AddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 320);
            this.ControlBox = false;
            this.Controls.Add(this.cancelAddBtn);
            this.Controls.Add(this.addFileBtn);
            this.Controls.Add(this.fileDescriptionLbl);
            this.Controls.Add(this.f_filePathLbl);
            this.Controls.Add(this.f_publicFileChBox);
            this.Controls.Add(this.f_fileDescriptionTxt);
            this.Controls.Add(this.chooseFilePathBtn);
            this.Controls.Add(this.filePathLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFile";
            this.Text = "Add File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filePathLbl;
        private System.Windows.Forms.Button chooseFilePathBtn;
        private System.Windows.Forms.TextBox f_fileDescriptionTxt;
        private System.Windows.Forms.CheckBox f_publicFileChBox;
        private System.Windows.Forms.Label f_filePathLbl;
        private System.Windows.Forms.Label fileDescriptionLbl;
        private System.Windows.Forms.Button addFileBtn;
        private System.Windows.Forms.Button cancelAddBtn;
    }
}