namespace subject_cms.Forms
{
    partial class AddSubject
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
            this.f_createBtn = new System.Windows.Forms.Button();
            this.f_cancelBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.teacherLbl = new System.Windows.Forms.Label();
            this.f_titleTxt = new System.Windows.Forms.TextBox();
            this.f_teacherTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // f_createBtn
            // 
            this.f_createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.f_createBtn.Location = new System.Drawing.Point(129, 109);
            this.f_createBtn.Name = "f_createBtn";
            this.f_createBtn.Size = new System.Drawing.Size(92, 33);
            this.f_createBtn.TabIndex = 0;
            this.f_createBtn.Text = "Create";
            this.f_createBtn.UseVisualStyleBackColor = true;
            this.f_createBtn.Click += new System.EventHandler(this.f_createBtn_Click);
            // 
            // f_cancelBtn
            // 
            this.f_cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.f_cancelBtn.Location = new System.Drawing.Point(227, 109);
            this.f_cancelBtn.Name = "f_cancelBtn";
            this.f_cancelBtn.Size = new System.Drawing.Size(92, 33);
            this.f_cancelBtn.TabIndex = 1;
            this.f_cancelBtn.Text = "Cancel";
            this.f_cancelBtn.UseVisualStyleBackColor = true;
            this.f_cancelBtn.Click += new System.EventHandler(this.f_cancelBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLbl.Location = new System.Drawing.Point(12, 32);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(44, 18);
            this.TitleLbl.TabIndex = 2;
            this.TitleLbl.Text = "Title: ";
            // 
            // teacherLbl
            // 
            this.teacherLbl.AutoSize = true;
            this.teacherLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherLbl.Location = new System.Drawing.Point(12, 71);
            this.teacherLbl.Name = "teacherLbl";
            this.teacherLbl.Size = new System.Drawing.Size(117, 18);
            this.teacherLbl.TabIndex = 4;
            this.teacherLbl.Text = "Teacher Name: ";
            // 
            // f_titleTxt
            // 
            this.f_titleTxt.Location = new System.Drawing.Point(175, 29);
            this.f_titleTxt.Name = "f_titleTxt";
            this.f_titleTxt.Size = new System.Drawing.Size(138, 20);
            this.f_titleTxt.TabIndex = 8;
            // 
            // f_teacherTxt
            // 
            this.f_teacherTxt.Location = new System.Drawing.Point(175, 69);
            this.f_teacherTxt.Name = "f_teacherTxt";
            this.f_teacherTxt.Size = new System.Drawing.Size(138, 20);
            this.f_teacherTxt.TabIndex = 9;
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 152);
            this.ControlBox = false;
            this.Controls.Add(this.f_teacherTxt);
            this.Controls.Add(this.f_titleTxt);
            this.Controls.Add(this.teacherLbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.f_cancelBtn);
            this.Controls.Add(this.f_createBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSubject";
            this.Text = "Create Subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button f_createBtn;
        private System.Windows.Forms.Button f_cancelBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label teacherLbl;
        private System.Windows.Forms.TextBox f_titleTxt;
        private System.Windows.Forms.TextBox f_teacherTxt;
    }
}