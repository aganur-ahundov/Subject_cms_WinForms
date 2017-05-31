namespace subject_cms
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
            this.NewBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.teacherLbl = new System.Windows.Forms.Label();
            this.semestersLbl = new System.Windows.Forms.Label();
            this.f_newSemesterBtn = new System.Windows.Forms.Button();
            this.f_semestersList = new System.Windows.Forms.ListBox();
            this.f_semestersListLbl = new System.Windows.Forms.Label();
            this.f_semestersAmountLbl = new System.Windows.Forms.Label();
            this.f_teacherLbl = new System.Windows.Forms.Label();
            this.f_titleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewBtn
            // 
            this.NewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewBtn.Location = new System.Drawing.Point(12, 277);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(120, 34);
            this.NewBtn.TabIndex = 0;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLbl.Location = new System.Drawing.Point(12, 14);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(55, 22);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Title: ";
            // 
            // teacherLbl
            // 
            this.teacherLbl.AutoSize = true;
            this.teacherLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherLbl.Location = new System.Drawing.Point(12, 50);
            this.teacherLbl.Name = "teacherLbl";
            this.teacherLbl.Size = new System.Drawing.Size(87, 22);
            this.teacherLbl.TabIndex = 2;
            this.teacherLbl.Text = "Teacher: ";
            // 
            // semestersLbl
            // 
            this.semestersLbl.AutoSize = true;
            this.semestersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.semestersLbl.Location = new System.Drawing.Point(12, 82);
            this.semestersLbl.Name = "semestersLbl";
            this.semestersLbl.Size = new System.Drawing.Size(105, 22);
            this.semestersLbl.TabIndex = 3;
            this.semestersLbl.Text = "Semesters: ";
            // 
            // f_newSemesterBtn
            // 
            this.f_newSemesterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.f_newSemesterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_newSemesterBtn.Location = new System.Drawing.Point(138, 277);
            this.f_newSemesterBtn.Name = "f_newSemesterBtn";
            this.f_newSemesterBtn.Size = new System.Drawing.Size(120, 34);
            this.f_newSemesterBtn.TabIndex = 4;
            this.f_newSemesterBtn.Text = "Add Semester";
            this.f_newSemesterBtn.UseVisualStyleBackColor = true;
            this.f_newSemesterBtn.Click += new System.EventHandler(this.f_newSemesterBtn_Click);
            // 
            // f_semestersList
            // 
            this.f_semestersList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.f_semestersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_semestersList.FormattingEnabled = true;
            this.f_semestersList.ItemHeight = 18;
            this.f_semestersList.Location = new System.Drawing.Point(303, 50);
            this.f_semestersList.Name = "f_semestersList";
            this.f_semestersList.Size = new System.Drawing.Size(230, 256);
            this.f_semestersList.TabIndex = 5;
            // 
            // f_semestersListLbl
            // 
            this.f_semestersListLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.f_semestersListLbl.AutoSize = true;
            this.f_semestersListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_semestersListLbl.Location = new System.Drawing.Point(299, 25);
            this.f_semestersListLbl.Name = "f_semestersListLbl";
            this.f_semestersListLbl.Size = new System.Drawing.Size(138, 22);
            this.f_semestersListLbl.TabIndex = 6;
            this.f_semestersListLbl.Text = "Semesters List: ";
            // 
            // f_semestersAmountLbl
            // 
            this.f_semestersAmountLbl.AutoSize = true;
            this.f_semestersAmountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_semestersAmountLbl.Location = new System.Drawing.Point(123, 83);
            this.f_semestersAmountLbl.Name = "f_semestersAmountLbl";
            this.f_semestersAmountLbl.Size = new System.Drawing.Size(0, 18);
            this.f_semestersAmountLbl.TabIndex = 7;
            // 
            // f_teacherLbl
            // 
            this.f_teacherLbl.AutoSize = true;
            this.f_teacherLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_teacherLbl.Location = new System.Drawing.Point(105, 51);
            this.f_teacherLbl.Name = "f_teacherLbl";
            this.f_teacherLbl.Size = new System.Drawing.Size(0, 18);
            this.f_teacherLbl.TabIndex = 8;
            // 
            // f_titleLbl
            // 
            this.f_titleLbl.AutoSize = true;
            this.f_titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_titleLbl.Location = new System.Drawing.Point(73, 15);
            this.f_titleLbl.Name = "f_titleLbl";
            this.f_titleLbl.Size = new System.Drawing.Size(0, 18);
            this.f_titleLbl.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 329);
            this.Controls.Add(this.f_titleLbl);
            this.Controls.Add(this.f_teacherLbl);
            this.Controls.Add(this.f_semestersAmountLbl);
            this.Controls.Add(this.f_semestersListLbl);
            this.Controls.Add(this.f_semestersList);
            this.Controls.Add(this.f_newSemesterBtn);
            this.Controls.Add(this.semestersLbl);
            this.Controls.Add(this.teacherLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.NewBtn);
            this.Name = "MainForm";
            this.Text = "Subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label teacherLbl;
        private System.Windows.Forms.Label semestersLbl;
        private System.Windows.Forms.Button f_newSemesterBtn;
        private System.Windows.Forms.ListBox f_semestersList;
        private System.Windows.Forms.Label f_semestersListLbl;
        private System.Windows.Forms.Label f_semestersAmountLbl;
        private System.Windows.Forms.Label f_teacherLbl;
        private System.Windows.Forms.Label f_titleLbl;
    }
}

