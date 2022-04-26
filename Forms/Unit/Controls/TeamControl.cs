using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit.Controls
{
    public partial class TeamControl : UserControl
    {
        public Team data;

        public TeamControl()
        {
            InitializeComponent();
        }

        private void TestTeamControl_Load(object sender, EventArgs e)
        {
            data = new Team();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DirectorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            data.director.name = DirectorNameTextBox.Text;
        }

        private void DirectorEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            data.director.eMail = DirectorEmailTextBox.Text;
        }

        private void DirectorPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            data.director.phone = DirectorPhoneTextBox.Text;
        }

        private void ViceNameTextBox_TextChanged(object sender, EventArgs e)
        {
            data.viceDirector.name = ViceNameTextBox.Text;
        }

        private void ViceEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            data.viceDirector.eMail = ViceEmailTextBox.Text;
        }

        private void VicePhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            data.viceDirector.phone = VicePhoneTextBox.Text;
        }

        private void UnitContactTextBox_TextChanged(object sender, EventArgs e)
        {
            data.contactPhone = UnitContactTextBox.Text;
        }

        private void OtherTextBox_TextChanged(object sender, EventArgs e)
        {
            data.otherDescription = OtherTextBox.Text;
        }

        private void PublicNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.generalPublicCount = (int)PublicNumericUpDown.Value;
        }

        private void OtherNumericUpDownCounter_ValueChanged(object sender, EventArgs e)
        {
            data.otherCount = (int)OtherNumericUpDownCounter.Value;
            if (data.otherCount > 0)
                OtherTextBox.Enabled = true;
            else
                OtherTextBox.Enabled = false;
        }

        private void StudentsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.studentsCount = (int)StudentsNumericUpDown.Value;
        }

        private void ProfessionalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.technicsCount = (int)ProfessionalNumericUpDown.Value;
        }

        private void TeachersNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.teachersCount = (int)TeachersNumericUpDown.Value;
        }

        public void ValidateData()
        {
            if (data != null)
                data.CheckValidity();
            else
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);
        }

        private void directorOccupationTextBox_TextChanged(object sender, EventArgs e)
        {
            data.director.occupation = directorOccupationTextBox.Text;
        }

        private void viceOccupationTextBox_TextChanged(object sender, EventArgs e)
        {
            data.viceDirector.occupation = viceOccupationTextBox.Text;
        }

        public void writeTeamInformation(System.IO.FileStream fs)
        {
            UnitMainForm.AddText(fs, "<unitTeam>\n");
            UnitMainForm.AddText(fs,
                directorOccupationTextBox.Text + '£'
                + DirectorNameTextBox.Text + '£'
                + DirectorEmailTextBox.Text + '£'
                + DirectorPhoneTextBox.Text + '\n');
            UnitMainForm.AddText(fs,
                viceOccupationTextBox.Text + '£'
                + ViceNameTextBox.Text + '£'
                + ViceEmailTextBox.Text + '£'
                + VicePhoneTextBox.Text + '\n');
            UnitMainForm.AddText(fs,
                TeachersNumericUpDown.Value.ToString() + '£'
                + ProfessionalNumericUpDown.Value.ToString() + '£'
                + StudentsNumericUpDown.Value.ToString() + '£'
                + PublicNumericUpDown.Value.ToString() + '£'
                + OtherTextBox.Text + '£'
                + OtherNumericUpDownCounter.Value.ToString() + '\n');
            UnitMainForm.AddText(fs,
                UnitContactTextBox.Text + '£'
                + textBox2.Text + '£'
                + textBox3.Text + '\n');
            UnitMainForm.AddText(fs, "<\\unitTeam>\n");
        }

        public void loadTeamInfo(string path)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {
                string line;
                do { line = sr.ReadLine(); } while (line != "<unitTeam>");
                line = sr.ReadLine();
                string[] lineParser = line.Split('£');
                directorOccupationTextBox.Text = lineParser[0];
                DirectorNameTextBox.Text = lineParser[1];
                DirectorEmailTextBox.Text = lineParser[2];
                DirectorPhoneTextBox.Text = lineParser[3];
                line = sr.ReadLine();
                lineParser = line.Split('£');
                viceOccupationTextBox.Text = lineParser[0];
                ViceNameTextBox.Text = lineParser[1];
                ViceEmailTextBox.Text = lineParser[2];
                VicePhoneTextBox.Text = lineParser[3];
                line = sr.ReadLine();
                lineParser = line.Split('£');
                TeachersNumericUpDown.Value = Convert.ToDecimal(lineParser[0]);
                ProfessionalNumericUpDown.Value = Convert.ToDecimal(lineParser[1]);
                StudentsNumericUpDown.Value = Convert.ToDecimal(lineParser[2]);
                PublicNumericUpDown.Value = Convert.ToDecimal(lineParser[3]);
                OtherTextBox.Text = lineParser[4];
                OtherNumericUpDownCounter.Value = Convert.ToDecimal(lineParser[5]);
                line = sr.ReadLine();
                lineParser = line.Split('£');
                UnitContactTextBox.Text = lineParser[0];
                textBox2.Text = lineParser[1];
                textBox3.Text = lineParser[2];
                sr.Close();

            }
        }

        private void viceDirectorGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
