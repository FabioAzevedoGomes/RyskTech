using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit.Controls
{
    public partial class MethodologyControl : UserControl
    {
        public string methodology;

        public MethodologyControl()
        {
            InitializeComponent();
            MethodologyTextBox.Text = Properties.Resources.default_methodology;
        }

        private void showTable1Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm(Properties.Resources.Quadro1, "Quadro 1");
            table1.ShowDialog();
        }

        private void showTable2Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm(Properties.Resources.Quadro2, "Quadro 2");
            table1.ShowDialog();
        }

        private void showTable3Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm(Properties.Resources.Quadro3, "Quadro 3");
            table1.ShowDialog();
        }

        private void showTable4Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm(Properties.Resources.Quadro4, "Quadro 4");
            table1.ShowDialog();
        }

        private void MethodologyTextBox_TextChanged(object sender, EventArgs e)
        {
            methodology = MethodologyTextBox.Text;
        }

        public void ValidateData()
        {
            // nil
        }

        public void writeMethodology(System.IO.FileStream fs)
        {
            UnitMainForm.AddText(fs, "<Methodology>\n");
            UnitMainForm.AddText(fs, MethodologyTextBox.Text.Replace("\r\n", "◄"));
            UnitMainForm.AddText(fs, "\n<\\Methodology>");
        }

        public void loadMethodology(string path)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {
                string line;
                do { line = sr.ReadLine(); } while (line != "<Methodology>");
                line = sr.ReadLine();
                MethodologyTextBox.Text = line.Replace("◄", "\r\n");
                sr.Close();
            }

        }

       
    }
}
