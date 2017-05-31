using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace subject_cms.Utilites
{
    public static class Messanger
    {
        public static void Warning( string _message )
        {
            MessageBox.Show( _message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
        }


        public static void Error( string _message )
        {
            MessageBox.Show( _message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }


        public static void Information( string _message )
        {
            MessageBox.Show( _message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}
