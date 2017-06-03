using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace subject_cms.Models
{
    public class HtmlGenerator
    {
        private FileInfo index;

        public HtmlGenerator( string _root )
        {
            File.Move( "../html_templates/html_empty.html", _root + "index.html" );
            index = new FileInfo( _root + "index.html" );
            HtmlElement s;
            s.OuterText = "it's ok";
        }
    }
}
