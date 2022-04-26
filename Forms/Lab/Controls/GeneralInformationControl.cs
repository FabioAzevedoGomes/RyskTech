using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class GeneralInformationControl : UserControl
    {
        public Characteristics data;

        public GeneralInformationControl()
        {
            InitializeComponent();
        }

        private void GeneralInformationControlBetter_Load(object sender, EventArgs e)
        {
            data = new Characteristics();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) //email
        {
            data.responsiblePersonEmail = textBox3.Text;
        }

        private void responsiblePersonTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.responsiblePersonOccupation = responsiblePersonTextBox.Text;
        }

        private void spaceCharacterizationTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.usageCharacterization = spaceCharacterizationTextBox.Text;
        }

        private void buildingTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.building = buildingTextBox.Text;
        }

        private void roomTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.room = roomTextBox.Text;
        }

        private void responsiblePersonContactTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.responsiblePersonContact = responsiblePersonContactTextBox.Text;
        }

        public void ValidateData()
        {
            data.CheckValidity();
        }

        private void teachersNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.teachersCount = (int)teachersNumericUpDown.Value;
        }

        private void technicsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.technicsCount = (int)technicsNumericUpDown.Value;
        }

        private void studentsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.studentsCount = (int)studentsNumericUpDown.Value;
        }

        private void publicNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.generalPublicCount = (int)publicNumericUpDown.Value;
        }

        private void responsiblePersonName_TextChanged(object sender, EventArgs e)
        {
            data.responsiblePersonName = responsiblePersonName.Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void writeGeneralInfo(System.IO.FileStream fs)
        {
            LabMainForm.AddText(fs, "<labGeneralInfo>\n");
            LabMainForm.AddText(fs, responsiblePersonName.Text + '\n');
            LabMainForm.AddText(fs, responsiblePersonTextBox.Text + '\n');
            LabMainForm.AddText(fs, responsiblePersonContactTextBox.Text + '\n');
            LabMainForm.AddText(fs, textBox3.Text + '\n');
            LabMainForm.AddText(fs, buildingTextBox.Text + '\n');
            LabMainForm.AddText(fs, roomTextBox.Text + '\n');
            LabMainForm.AddText(fs, teachersNumericUpDown.Value.ToString() + '\n');
            LabMainForm.AddText(fs, technicsNumericUpDown.Value.ToString() + "\n");
            LabMainForm.AddText(fs, studentsNumericUpDown.Value.ToString() + "\n");
            LabMainForm.AddText(fs, publicNumericUpDown.Value.ToString() + "\n");
            LabMainForm.AddText(fs, spaceCharacterizationTextBox.Text.Replace("\r\n", "£££"));
            LabMainForm.AddText(fs, "\n<\\labGeneralInfo>\n");
        }



        public void loadGeneralInfo(string path)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {
                string line;
                do { line = sr.ReadLine(); } while (line != "<labGeneralInfo>");
                this.responsiblePersonName.Text = sr.ReadLine();
                this.responsiblePersonTextBox.Text = sr.ReadLine();
                this.responsiblePersonContactTextBox.Text = sr.ReadLine();
                this.textBox3.Text = sr.ReadLine();
                this.buildingTextBox.Text = sr.ReadLine();
                this.roomTextBox.Text = sr.ReadLine();
                this.teachersNumericUpDown.Value = Convert.ToDecimal(sr.ReadLine());
                this.technicsNumericUpDown.Value = Convert.ToDecimal(sr.ReadLine());
                this.studentsNumericUpDown.Value = Convert.ToDecimal(sr.ReadLine());
                this.publicNumericUpDown.Value = Convert.ToDecimal(sr.ReadLine());
                this.spaceCharacterizationTextBox.Text = sr.ReadLine().Replace("£££", "\r\n");
                sr.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
