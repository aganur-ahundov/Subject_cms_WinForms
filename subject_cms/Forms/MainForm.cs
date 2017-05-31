using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using subject_cms.Forms;
using subject_cms.Models;


namespace subject_cms
{
    public partial class MainForm : Form
    {
        private Subject subject;

        public MainForm()
        {
            InitializeComponent();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            AddSubject newSubject = new AddSubject();
            newSubject.ShowDialog();


            //If user accepted creation this field must be not empty
            if ( !string.IsNullOrEmpty( newSubject.Title ) )
            {
                subject = new Subject();
                subject.Title = newSubject.Title;
                subject.TeacherName = newSubject.Teacher;
                subject.Semesters = new List<Semester>();

                f_semestersAmountLbl.Text = "0";
                f_teacherLbl.Text = subject.TeacherName;
                f_titleLbl.Text = subject.Title;
            }
        }

        private void f_newSemesterBtn_Click(object sender, EventArgs e)
        {
            AddSemester newSemester = new AddSemester();
            newSemester.ShowDialog();

        }
    }
}
