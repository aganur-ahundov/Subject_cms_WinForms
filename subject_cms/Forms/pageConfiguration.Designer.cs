namespace subject_cms.Forms
{
    partial class pageConfiguration
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
            this.addCSSBtn = new System.Windows.Forms.Button();
            this.addScriptBtn = new System.Windows.Forms.Button();
            this.generateHtml = new System.Windows.Forms.Button();
            this.configurationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCSSBtn
            // 
            this.addCSSBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCSSBtn.Location = new System.Drawing.Point(28, 26);
            this.addCSSBtn.Name = "addCSSBtn";
            this.addCSSBtn.Size = new System.Drawing.Size(120, 34);
            this.addCSSBtn.TabIndex = 1;
            this.addCSSBtn.Text = "Add CSS";
            this.addCSSBtn.UseVisualStyleBackColor = true;
            this.addCSSBtn.Click += new System.EventHandler(this.addCSSBtn_Click);
            // 
            // addScriptBtn
            // 
            this.addScriptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addScriptBtn.Location = new System.Drawing.Point(175, 26);
            this.addScriptBtn.Name = "addScriptBtn";
            this.addScriptBtn.Size = new System.Drawing.Size(120, 34);
            this.addScriptBtn.TabIndex = 2;
            this.addScriptBtn.Text = "Add Script";
            this.addScriptBtn.UseVisualStyleBackColor = true;
            this.addScriptBtn.Click += new System.EventHandler(this.addScriptBtn_Click);
            // 
            // generateHtml
            // 
            this.generateHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateHtml.Location = new System.Drawing.Point(108, 128);
            this.generateHtml.Name = "generateHtml";
            this.generateHtml.Size = new System.Drawing.Size(120, 34);
            this.generateHtml.TabIndex = 13;
            this.generateHtml.Text = "Generate";
            this.generateHtml.UseVisualStyleBackColor = true;
            this.generateHtml.Click += new System.EventHandler(this.generateHtml_Click);
            // 
            // configurationBtn
            // 
            this.configurationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.configurationBtn.Location = new System.Drawing.Point(108, 79);
            this.configurationBtn.Name = "configurationBtn";
            this.configurationBtn.Size = new System.Drawing.Size(120, 34);
            this.configurationBtn.TabIndex = 14;
            this.configurationBtn.Text = "Configuration";
            this.configurationBtn.UseVisualStyleBackColor = true;
            this.configurationBtn.Click += new System.EventHandler(this.configurationBtn_Click);
            // 
            // pageConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 197);
            this.ControlBox = false;
            this.Controls.Add(this.configurationBtn);
            this.Controls.Add(this.generateHtml);
            this.Controls.Add(this.addScriptBtn);
            this.Controls.Add(this.addCSSBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pageConfiguration";
            this.Text = "Configuration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addCSSBtn;
        private System.Windows.Forms.Button addScriptBtn;
        private System.Windows.Forms.Button generateHtml;
        private System.Windows.Forms.Button configurationBtn;
    }
}