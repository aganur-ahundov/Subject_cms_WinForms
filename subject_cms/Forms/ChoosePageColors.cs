using System;
using System.Drawing;
using System.Windows.Forms;

namespace subject_cms.Forms
{
    public partial class ChoosePageColors : Form
    {
        public Color? background;
        public Color? header;
        public Color? lessons;

        public ChoosePageColors()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void headerChooseColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if ( colorDialog.ShowDialog() == DialogResult.Cancel )
                return ;

            header = colorDialog.Color;
            f_headerColorLbl.BackColor = colorDialog.Color;
        }

        private void chooseBackgroundColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if ( colorDialog.ShowDialog() == DialogResult.Cancel )
                return;

            background = colorDialog.Color;
            f_backgroundColor.BackColor = colorDialog.Color;
        }

        private void chooseLessonColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if ( colorDialog.ShowDialog() == DialogResult.Cancel )
                return;

            lessons = colorDialog.Color;
            //f_lessonColorLbl.BackColor = lessons;
        }
    }
}
