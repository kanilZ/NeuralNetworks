using NeuralNetworks;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutProgram();
            aboutForm.ShowDialog();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var pictureConverter = new PictureConverter();
                var inputs = pictureConverter.Convert(openFileDialog.FileName);
                var result = Program.Controller.ImageNetwork.Predict(inputs).Output;

            }
        }

        private void enterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var enterdataForm = new EnterData();
            var result = enterdataForm.ShowForm();

        }
    }
}
