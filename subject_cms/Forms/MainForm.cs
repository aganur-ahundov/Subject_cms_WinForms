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
using subject_cms.Utilites;


namespace subject_cms
{
    public partial class MainForm : Form
    {
        private Subject subject = new Subject();

        public MainForm()
        {
            InitializeComponent();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            AddSubject newSubject = new AddSubject();
            newSubject.ShowDialog();


            //If user accepted creation this field must be not empty
            if (!string.IsNullOrEmpty(newSubject.Title))
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


        //ADD NEW SEMESTER TO LIST
        private void f_newSemesterBtn_Click( object sender, EventArgs e )
        {
            if ( string.IsNullOrEmpty( f_titleLbl.Text ) )
            {
                Messanger.Warning ( "First, you need to create subject" );
                return;
            }

            AddSemester newSemester = new AddSemester();
            newSemester.ShowDialog();

            if ( string.IsNullOrEmpty( newSemester.semester.Title ) )
                return;

            add_semester( newSemester.semester );
        }



        //REMOVE SEMESTER FROM SEMESTERS LIST
        private void removeSemester_Click( object sender, EventArgs e )
        {
            string title = f_semestersList.SelectedItem?.ToString();
            if ( string.IsNullOrEmpty( title ) )
                return;

            remove_semester( title );
        }
        

        //EDIT SEMESTER
        private void editSemester_Click( object sender, EventArgs e )
        {
            string title = f_semestersList.SelectedItem?.ToString();
            if ( string.IsNullOrEmpty( title ) )
                return;

            Semester editSemester = subject.Semesters.Where( s => s.Title == title ).First();
            remove_semester( editSemester.Title );

            AddSemester newSemester = new AddSemester( editSemester );
            newSemester.ShowDialog();

            add_semester( newSemester.semester );
        }


        private void remove_semester( string _title )
        {
            f_semestersList.Items.Remove( _title );

            Semester removeItem = subject.Semesters.Where( s => s.Title == _title ).First();
            subject.Semesters.Remove( removeItem );

            f_semestersAmountLbl.Text = subject.Semesters.Count.ToString();
        }


        private void add_semester( Semester _newSemester )
        {
            subject.Semesters.Add( _newSemester );
            f_semestersList.Items.Add( _newSemester.Title );

            f_semestersAmountLbl.Text = subject.Semesters.Count.ToString();
        }

        private void generateHtml_Click( object sender, EventArgs e )
        {
            if ( string.IsNullOrEmpty ( f_titleLbl.Text ) )
            {
                Messanger.Warning ( "First, you need to create subject" );
                return;
            }


            if ( subject.Semesters.Count == 0 )
            {
                Messanger.Warning( "Semesters list is empty" );
                return;
            }

            FolderBrowserDialog folder = new FolderBrowserDialog();
            if ( folder.ShowDialog() == DialogResult.Cancel )
                return;

            HtmlGenerator html = new HtmlGenerator( folder.SelectedPath, subject );
            Messanger.Information ( "File generated successfully!" );
        }
    }
}
