using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class LabWelcomeControl : UserControl
    {
        public LabScope data;

        public LabWelcomeControl()
        {
            InitializeComponent();
            
        }

        private void LabWelcomeControlBetter_Load(object sender, EventArgs e)
        {
            data = new LabScope();
        }

        private void unitNameTextBox_TextChanged(object sender, EventArgs e)
        {
            data.belongingUnitName = unitNameTextBox.Text;
        }

        private void labNameTextBox_TextChanged(object sender, EventArgs e)
        {
            data.labName = labNameTextBox.Text;
        }

        private void chemicalAgentsUsedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.manipulatesChemicalAgents = chemicalAgentsUsedCheckBox.Checked;
        }

        private void biologicalAgentsUsedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.manipulatesBiologicalAgents = biologicalAgentsUsedCheckBox.Checked;
        }

        private void physicalAgentsUsedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.manipulatesPhysicalAgents = physicalAgentsUsedCheckBox.Checked;
        }

        public void ValidateData()
        {
            if (data != null)
                data.CheckValidity();
            else
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            data.date = dateTimePicker2.Value;
        }

        public void writeWelcomeInfo(System.IO.FileStream fs)
        {
            LabMainForm.AddText(fs, "<LabWelcome>\n");
            LabMainForm.AddText(fs, this.data.belongingUnitName + '\n');
            LabMainForm.AddText(fs, this.data.labName + '\n');
            if (this.data.manipulatesChemicalAgents)
                LabMainForm.AddText(fs, "chemical,");
            if (this.data.manipulatesBiologicalAgents)
                LabMainForm.AddText(fs, "biological,");
            if (this.data.manipulatesPhysicalAgents)
                LabMainForm.AddText(fs, "physical");
            LabMainForm.AddText(fs, "\n");
            LabMainForm.AddText(fs, this.data.date.ToLongDateString() + '\n');
            LabMainForm.AddText(fs, "<\\LabWelcome>\n");
        }

        public void loadWelcomeInfo(string path)
        {
            using(System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {
                 string line = sr.ReadLine();
               this.unitNameTextBox.Text = sr.ReadLine();
               this.labNameTextBox.Text = sr.ReadLine();
                line = sr.ReadLine();
                if(line.Contains("chemical"))
                    chemicalAgentsUsedCheckBox.Checked = true;
                if(line.Contains("biological"))
                    biologicalAgentsUsedCheckBox.Checked = true;
                if(line.Contains("physical"))
                    physicalAgentsUsedCheckBox.Checked = true;

                DateTime dateValue = Convert.ToDateTime(sr.ReadLine());
                if(dateValue == DateTime.MinValue)
                    dateValue = DateTime.Now;
                this.dateTimePicker2.Value = dateValue;

                if (sr.ReadLine() == "<\\LabWelcome>")
                    sr.Close(); 
            }

        }
    }
}
