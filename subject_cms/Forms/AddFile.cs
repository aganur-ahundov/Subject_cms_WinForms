using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using subject_cms.Models;
using subject_cms.Utilites;


namespace subject_cms.Forms
{
    public partial class AddFile : Form
    {
        //public string Path { get; set; }

        //public string Description { get; set; }

        //public bool IsPublic { get; set; }
        
        public FileContainer File { get; set; }


        public AddFile()
        {
            InitializeComponent();
            File = new FileContainer();
        }

        private void cancelAddBtn_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void chooseFilePathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChoose = new OpenFileDialog();

            if ( fileChoose.ShowDialog() == DialogResult.Cancel )
                return;

            f_filePathLbl.Text = fileChoose.FileName;
        }

        private void addFileBtn_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty( f_filePathLbl.Text ) )
            {
                Messanger.Error( "Need to choose file!" );
                return;
            }

            File.Description = f_fileDescriptionTxt.Text;
            File.IsAvailable = f_publicFileChBox.Checked;
            File.file = new FileInfo( f_filePathLbl.Text );
            Close();
        }
    }
}
