using RyskTech.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class BiologicalAgentsControl : UserControl
    {
        public BiologicalInfo data;
        public string storage;
        public string destination;

        public BiologicalAgentsControl()
        {
            InitializeComponent();
        }

        private void BiologicalAgentsBetter_Load(object sender, EventArgs e)
        {
            data = new BiologicalInfo();
        }

        private void AddAgentDataToTable(BiologicalAgent createdAgent)
        {
            if (createdAgent != null)
            {
                bioAgentData.Rows.Add(
                    createdAgent.name,
                    createdAgent.riskClassification,
                    createdAgent.usageScenarios);
            }
        }

        private void addBiologicalResidueButton_Click(object sender, EventArgs e)
        {
            EditBiologicalAgentForm newAgentForm = new EditBiologicalAgentForm(null);
            newAgentForm.ShowDialog();

            AddAgentDataToTable(newAgentForm.createdAgent);
        }

        private void editBioAgentButotn_Click(object sender, EventArgs e)
        {
            if (bioAgentData.SelectedRows.Count > 0)
            {
                // Take only first if multiple selected
                BiologicalAgent agent = new BiologicalAgent(
                bioAgentData.SelectedRows[0].Cells[0].Value.ToString(),
                bioAgentData.SelectedRows[0].Cells[1].Value.ToString(),
                bioAgentData.SelectedRows[0].Cells[2].Value.ToString()
                );

                EditBiologicalAgentForm newAgentForm = new EditBiologicalAgentForm(agent);
                newAgentForm.ShowDialog();

                if (newAgentForm.createdAgent != null)
                {
                    bioAgentData.Rows[bioAgentData.SelectedRows[0].Index].Cells[0].Value = newAgentForm.createdAgent.name;
                    bioAgentData.Rows[bioAgentData.SelectedRows[0].Index].Cells[1].Value = newAgentForm.createdAgent.riskClassification;
                    bioAgentData.Rows[bioAgentData.SelectedRows[0].Index].Cells[2].Value = newAgentForm.createdAgent.usageScenarios;
                }
            }
        }

        private void removeBioResidueButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in bioAgentData.SelectedRows)
                bioAgentData.Rows.RemoveAt(row.Index);
        }

        private void addSampleButton_Click(object sender, EventArgs e)
        {
            if (newProcessedSampleTextBox.Text != null && newProcessedSampleTextBox.Text.Length > 0)
                processedSamplesListBox.Items.Add(newProcessedSampleTextBox.Text);

            newProcessedSampleTextBox.Text = "";
        }

        private void removeSampleButton_Click(object sender, EventArgs e)
        {
            if (processedSamplesListBox.SelectedIndex >= 0)
                processedSamplesListBox.Items.RemoveAt(processedSamplesListBox.SelectedIndex);
        }

        private void sisgenRegistryNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            data.SISGEN = sisgenRegistryNumberTextBox.Text;
        }

        private void ogmYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.hasOGM = true;
            sisgenRegistryNumberTextBox.Enabled = true;
        }

        private void ogmNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.hasOGM = false;
            sisgenRegistryNumberTextBox.Enabled = false;
        }

        private void certificateYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.hasBioSecurityCertificate = true;
        }

        private void certificateNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.hasBioSecurityCertificate = false;
        }

        private void CreateBiologicalAgentList()
        {
            data.biologicalAgentList = new List<BiologicalAgent>();
            foreach (DataGridViewRow row in bioAgentData.Rows)
            {
                if (row.Cells[0] != null)
                {
                    BiologicalAgent agent = new BiologicalAgent(
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString()
                    );
                    data.biologicalAgentList.Add(agent);
                }
            }
        }

        private void bioResidueDestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            destination = bioResidueDestinationTextBox.Text;
        }

        private void bioStorageTextBox_TextChanged(object sender, EventArgs e)
        {
            storage = bioStorageTextBox.Text;
        }

        public void ValidateData()
        {

            if (this.data == null)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            CreateBiologicalAgentList();
            if (processedSamplesListBox.Items == null || processedSamplesListBox.Items.Count <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoProcessedSamples);

            data.processedSamples = processedSamplesListBox.Items.Cast<String>().ToList();

            data.CheckValidity();

            if (storage == null || destination == null)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            if (storage.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoResidueStorageDescription);

            if (destination.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoResidueDestination);

        }

        private string dumpBioAgentData(BiologicalAgent bio, System.IO.FileStream fs)
        {
            return "\n" + bio.name + "£" + bio.riskClassification + "£" + bio.usageScenarios.Replace('\n', ',');
        }

        public void writeBiologicalInfo(System.IO.FileStream fs)
        {
            CreateBiologicalAgentList();

            LabMainForm.AddText(fs, "<labBiologicalInfo>\n");
            
            if(this.data.biologicalAgentList.Count > 0)
            {
                LabMainForm.AddText(fs, "AGENTES");
                foreach(BiologicalAgent agent in this.data.biologicalAgentList)
                {
                    LabMainForm.AddText(fs, dumpBioAgentData(agent, fs));
                }
                LabMainForm.AddText(fs, "\nEND\n");
            }
            else
            {
                LabMainForm.AddText(fs, "SEM AGENTES\n");
            }
            LabMainForm.AddText(fs, bioStorageTextBox.Text + '\n');
            LabMainForm.AddText(fs, "&&&\n");
            LabMainForm.AddText(fs, bioResidueDestinationTextBox.Text + '\n');
            LabMainForm.AddText(fs, "&&&\n");
            if (this.processedSamplesListBox.Items.Count > 0)
            {
                LabMainForm.AddText(fs, "AMOSTRAS\n");
                foreach (string text in this.processedSamplesListBox.Items)
                {
                    LabMainForm.AddText(fs, text + '\n');
                }
                LabMainForm.AddText(fs, "END");
            }
            else LabMainForm.AddText(fs, "SEM AMOSTRAS");

            if (ogmYesRadioButton.Checked == true)
            {
                LabMainForm.AddText(fs, "\nOGM\n");
                LabMainForm.AddText(fs, sisgenRegistryNumberTextBox.Text + "\n");
            }
            else LabMainForm.AddText(fs, "\nSEM OGM\n");
            if (certificateYesRadioButton.Checked == true)
                LabMainForm.AddText(fs, "CERTIFICADO\n");
            else LabMainForm.AddText(fs, "SEM CERTIFICADO\n");
            LabMainForm.AddText(fs, "<\\labBiologicalInfo>\n");
        }


        public void loadBiologicalInfo(string path)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {
                string line;
                do { line = sr.ReadLine(); } while (line != "<labBiologicalInfo>");
                line = sr.ReadLine();
                if (line == "AGENTES")
                {
                    line = sr.ReadLine();
                    while(line != "END")
                    {
                        parseBioLine(line);
                        line = sr.ReadLine();
                    }

                    line = sr.ReadLine();

                }
                else { line = sr.ReadLine(); }
                while (line != "&&&")
                {
                    this.bioStorageTextBox.Text += line + "\r\n";
                    if (sr.Peek() == '\n')
                    {
                        line = sr.ReadLine();
                        
                    }
                    line = sr.ReadLine();
                }
                line = sr.ReadLine();
                while (line != "&&&")
                {
                    this.bioResidueDestinationTextBox.Text += line + "\r\n";
                    if (sr.Peek() == '\n') { 
                        line = sr.ReadLine();
                   
                }
                    line = sr.ReadLine();
                }
                line = sr.ReadLine();
                if(line == "AMOSTRAS")
                {
                    line = sr.ReadLine();
                    while(line != "END")
                    {
                        this.processedSamplesListBox.Items.Add(line);
                        line = sr.ReadLine();
                    }
                    line =sr.ReadLine();
                }
                else line = sr.ReadLine();

                if (line == "OGM")
                {
                    this.ogmYesRadioButton.Checked = true;
                    this.ogmNoRadioButton.Checked = false;
                    line = sr.ReadLine();
                    this.sisgenRegistryNumberTextBox.Text = line;
                    line = sr.ReadLine();
                }
                else line = sr.ReadLine();
                if(line == "CERTIFICADO")
                {
                    this.certificateYesRadioButton.Checked = true;
                    this.certificateNoRadioButton.Checked = false;
                }
                else
                {
                    this.certificateYesRadioButton.Checked = false;
                    this.certificateNoRadioButton.Checked = true;
                }

                sr.Close();
            }
        }

        private void parseBioLine(string line)
        {

            BiologicalAgent newAgent = new BiologicalAgent();
            string[] information = line.Split('£');
            newAgent.name = information[0];
            newAgent.riskClassification = information[1];
            newAgent.usageScenarios = information[2].Replace(',', '\n');

            this.AddAgentDataToTable(newAgent);
        }
    }
}
