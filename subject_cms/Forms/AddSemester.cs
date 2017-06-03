using System;
using System.Windows.Forms;
using subject_cms.Models;
using subject_cms.Utilites;


namespace subject_cms.Forms
{
    public partial class AddSemester : Form
    {
       public Semester semester { get; set; }


        public AddSemester()
        {
            InitializeComponent();

            f_semesterTypeCBox.Items.AddRange( new string[] { "Exam", "Credit" } );
            f_semesterTypeCBox.SelectedIndex = 0;
            
            semester = new Semester();
        }

        public AddSemester( Semester _semester )
        {
            InitializeComponent();

            f_semesterTypeCBox.Items.AddRange(new string[] { "Exam", "Credit" });
            f_semesterTypeCBox.SelectedIndex = 0;

            semester = _semester;

            //If it edit created semester fill all fields
            f_semesterTitleTxt.Text = semester.Title;
            f_semesterTypeCBox.SelectedItem = Enum.GetName(typeof(SemesterType), semester.Type);
            f_lectureHoursTxt.Text = semester.Lectures.Hours.ToString();
            f_lectureFileAmountLbl.Text = semester.Lectures.Files.Count.ToString();
            f_practiceHoursTxt.Text = semester.Practice.Hours.ToString();
            f_practiceFileAmountLbl.Text = semester.Practice.Files.Count.ToString();
            f_laboratoryHoursTxt.Text = semester.Laboratory.Hours.ToString();
            f_laboratoryFileAmountLbl.Text = semester.Laboratory.Files.Count.ToString();
        }


        //Close add new semester form
        private void button3_Click( object sender, EventArgs e )
        {
            Close();
        }


        //Add new file for lecture lessons
        private void lectureAddFiles_Click( object sender, EventArgs e )
        {
            addFileToLesson( semester.Lectures );
            f_lectureFileAmountLbl.Text = semester.Lectures.Files.Count.ToString();
        }

        private void practiceAddFiles_Click( object sender, EventArgs e )
        {
            addFileToLesson( semester.Practice );
            f_practiceFileAmountLbl.Text = semester.Practice.Files.Count.ToString();
        }


        private void addLaboratoryFiles_Click( object sender, EventArgs e )
        {
            addFileToLesson( semester.Laboratory );
            f_laboratoryFileAmountLbl.Text = semester.Laboratory.Files.Count.ToString();
        }


        //Open file dialog and save choosen file
        private void addFileToLesson ( Lesson _lesson )
        {
            AddFile file = new AddFile();
            file.ShowDialog();

            if ( file.File.file != null )
            {
                _lesson.Files.Add( file.File );
            }
        }


        /*FULL VALIDATION*/
        private void button2_Click(object sender, EventArgs e)
        {
            if ( !checkLessonsHours() )
                return;

            if ( string.IsNullOrEmpty( f_semesterTitleTxt.Text ) )
            {
                Messanger.Warning( "Enter semester title" );
                return;
            }

            semester.Title = f_semesterTitleTxt.Text;
            semester.Type = f_semesterTypeCBox.SelectedItem.ToString() == "Exam" ? SemesterType.Exam : SemesterType.Credit;

            Close();
        }

        

        /*CLEAR LESSONS PANEL METHODS*/
        private void lectureClearBtn_Click(object sender, EventArgs e)
        {
            semester.Lectures.Files.Clear();
            semester.Lectures.Hours = 0;
            f_lectureHoursTxt.Text = string.Empty;
            f_lectureFileAmountLbl.Text = "0";
        }


        private void PracticeClearBtn_Click( object sender, EventArgs e )
        {
            semester.Practice.Files.Clear();
            semester.Practice.Hours = 0;
            f_practiceHoursTxt.Text = string.Empty;
            f_practiceFileAmountLbl.Text = "0";
        }

        private void LaboratoryClearBtn_Click(object sender, EventArgs e)
        {
            semester.Laboratory.Files.Clear();
            semester.Laboratory.Hours = 0;
            f_laboratoryHoursTxt.Text = string.Empty;
            f_laboratoryFileAmountLbl.Text = "0";
        }


        /*Check lessons hour field for correct number*/
        private bool checkLessonsHours()
        {
            if ( string.IsNullOrEmpty( f_lectureHoursTxt.Text )
                   && string.IsNullOrEmpty( f_laboratoryHoursTxt.Text )
                   && string.IsNullOrEmpty( f_practiceHoursTxt.Text ) )
            {
                Messanger.Warning( "Semester cant be empty. Please fill a fields" );
                return false;
            }


            if ( !string.IsNullOrEmpty( f_lectureHoursTxt.Text ) )
            {
                try
                {
                    semester.Lectures.Hours = short.Parse(f_lectureHoursTxt.Text);
                }
                catch ( FormatException )
                {
                    Messanger.Error( "Lecture hours field invalid" );
                    return false;
                }
            }


            if ( !string.IsNullOrEmpty( f_practiceHoursTxt.Text ) )
            {
                try
                {
                    semester.Practice.Hours = short.Parse( f_practiceHoursTxt.Text );
                }
                catch ( FormatException )
                {
                    Messanger.Error( "Practice hours field invalid" );
                    return false;
                }
            }


            if ( !string.IsNullOrEmpty( f_laboratoryHoursTxt.Text ) )
            {
                try
                {
                    semester.Laboratory.Hours = short.Parse( f_laboratoryHoursTxt.Text );
                }
                catch ( FormatException )
                {
                    Messanger.Error( "Laboratory hours field invalid" );
                    return false;
                }
            }

            return true;
        }
    }
}
