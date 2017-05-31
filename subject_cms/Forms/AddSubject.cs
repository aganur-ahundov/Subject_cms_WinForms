using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using subject_cms.Utilites;


namespace subject_cms.Forms
{
    public partial class AddSubject : Form
    {
        public string Title { get; set; }

        public string Teacher { get; set; }
        

        public AddSubject()
        {
            InitializeComponent();
        }

        private void f_cancelBtn_Click( object sender, EventArgs e )
        {
            Close();
        }


        private void f_createBtn_Click( object sender, EventArgs e )
        {
                        /*VALIDATION*/


            if ( string.IsNullOrEmpty( f_titleTxt.Text ) )
            {
                Messanger.Error( "Invalid title field" );
                return;
            }
            else
            {
                Title = f_titleTxt.Text;
            }



            if ( string.IsNullOrEmpty( f_teacherTxt.Text ) )
            {
                Messanger.Error( "Invalid teacher field" );
                return;
            }
            else
            {
                Teacher = f_teacherTxt.Text;
            }

            Close();
        }
    }
}
