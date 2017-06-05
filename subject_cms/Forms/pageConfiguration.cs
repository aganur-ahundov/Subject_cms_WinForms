using System;
using System.Windows.Forms;
using subject_cms.Models;


namespace subject_cms.Forms
{
    public partial class pageConfiguration : Form
    {
        public AdditionalsConfigurations config = new AdditionalsConfigurations();


        public pageConfiguration()
        {
            InitializeComponent();
        }


        private void generateHtml_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addCSSBtn_Click ( object sender, EventArgs e )
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Style files (*.css)|*.css";

            if ( fileDialog.ShowDialog() == DialogResult.Cancel )
                return;

            config.CSSFilePath = fileDialog.FileName;
        }

        private void addScriptBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Script files (*.js)|*.js";
            fileDialog.Multiselect = true;

            if ( fileDialog.ShowDialog() == DialogResult.Cancel )
                return;

            config.ScriptFilesPaths = fileDialog.FileNames;
        }

        private void configurationBtn_Click(object sender, EventArgs e)
        {
            ChoosePageColors colors = new ChoosePageColors();
            colors.ShowDialog();
            config.BackgroundColor = colors.background;
            config.HeaderColor = colors.header;
            config.LessonColor = colors.lessons;
        }
    }
}
