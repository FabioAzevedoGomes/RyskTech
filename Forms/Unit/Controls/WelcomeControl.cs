using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit.Controls
{
    public partial class WelcomeControl : UserControl
    {
        public UnitScope data;

        public WelcomeControl()
        {
            InitializeComponent();
        }

        private void TestWelcomeControl_Load(object sender, EventArgs e)
        {
            data = new UnitScope();
        }

        private void unitNameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.name = unitNameTextBox.Text;
        }

        public void ValidateData()
        {
            data.CheckValidity();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            data.date = dateTimePicker1.Value;
        }

        public void writeWelcomeInfo(System.IO.FileStream fs)
        {
            UnitMainForm.AddText(fs, "<unitWelcome>\n");
            UnitMainForm.AddText(fs, unitNameTextBox.Text +'£');
            UnitMainForm.AddText(fs, dateTimePicker1.Value.ToString());
            UnitMainForm.AddText(fs, "\n<\\unitWelcome>\n");
        }

        public void loadWelcomeInfo(string path)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {
                sr.ReadLine();
                string[] line = sr.ReadLine().Split('£');
                this.unitNameTextBox.Text = line[0];
                this.dateTimePicker1.Value = Convert.ToDateTime(line[1]);
                sr.Close();
            }
        }
    }
}
