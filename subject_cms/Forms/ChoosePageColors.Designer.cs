namespace subject_cms.Forms
{
    partial class ChoosePageColors
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.chooseBackgroundColorBtn = new System.Windows.Forms.Button();
            this.headerChooseColorBtn = new System.Windows.Forms.Button();
            this.f_headerColorLbl = new System.Windows.Forms.Label();
            this.f_backgroundColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.Location = new System.Drawing.Point(57, 141);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(120, 34);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // chooseBackgroundColorBtn
            // 
            this.chooseBackgroundColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseBackgroundColorBtn.Location = new System.Drawing.Point(57, 64);
            this.chooseBackgroundColorBtn.Name = "chooseBackgroundColorBtn";
            this.chooseBackgroundColorBtn.Size = new System.Drawing.Size(120, 34);
            this.chooseBackgroundColorBtn.TabIndex = 7;
            this.chooseBackgroundColorBtn.Text = "Backgound";
            this.chooseBackgroundColorBtn.UseVisualStyleBackColor = true;
            this.chooseBackgroundColorBtn.Click += new System.EventHandler(this.chooseBackgroundColorBtn_Click);
            // 
            // headerChooseColorBtn
            // 
            this.headerChooseColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerChooseColorBtn.Location = new System.Drawing.Point(57, 12);
            this.headerChooseColorBtn.Name = "headerChooseColorBtn";
            this.headerChooseColorBtn.Size = new System.Drawing.Size(120, 34);
            this.headerChooseColorBtn.TabIndex = 8;
            this.headerChooseColorBtn.Text = "Header";
            this.headerChooseColorBtn.UseVisualStyleBackColor = true;
            this.headerChooseColorBtn.Click += new System.EventHandler(this.headerChooseColorBtn_Click);
            // 
            // f_headerColorLbl
            // 
            this.f_headerColorLbl.AutoSize = true;
            this.f_headerColorLbl.Location = new System.Drawing.Point(187, 23);
            this.f_headerColorLbl.Name = "f_headerColorLbl";
            this.f_headerColorLbl.Size = new System.Drawing.Size(31, 13);
            this.f_headerColorLbl.TabIndex = 9;
            this.f_headerColorLbl.Text = "Color";
            // 
            // f_backgroundColor
            // 
            this.f_backgroundColor.AutoSize = true;
            this.f_backgroundColor.Location = new System.Drawing.Point(187, 75);
            this.f_backgroundColor.Name = "f_backgroundColor";
            this.f_backgroundColor.Size = new System.Drawing.Size(31, 13);
            this.f_backgroundColor.TabIndex = 10;
            this.f_backgroundColor.Text = "Color";
            // 
            // ChoosePageColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 187);
            this.ControlBox = false;
            this.Controls.Add(this.f_backgroundColor);
            this.Controls.Add(this.f_headerColorLbl);
            this.Controls.Add(this.headerChooseColorBtn);
            this.Controls.Add(this.chooseBackgroundColorBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoosePageColors";
            this.Text = "Page Colors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button chooseBackgroundColorBtn;
        private System.Windows.Forms.Button headerChooseColorBtn;
        private System.Windows.Forms.Label f_headerColorLbl;
        private System.Windows.Forms.Label f_backgroundColor;
    }
}