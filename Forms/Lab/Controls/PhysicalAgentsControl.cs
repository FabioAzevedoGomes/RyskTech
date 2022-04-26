using RyskTech.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class PhysicalAgentsControl : UserControl
    {
        public List<PhysicalAgent> physicalAgentList;

        public PhysicalAgentsControl()
        {
            InitializeComponent();
        }

        private void PhysicalAgentsControlBetter_Load(object sender, EventArgs e)
        {
            physicalAgentList = new List<PhysicalAgent>();
        }

        private void addPhyisicalAgentButton_Click(object sender, EventArgs e)
        {
            EditPhysicalAgentForm newAgentForm = new EditPhysicalAgentForm(null);
            newAgentForm.ShowDialog();

            AddAgentDataToTable(newAgentForm.createdAgent);
        }

        private void editPhyisicalAgentButton_Click(object sender, EventArgs e)
        {
            if (phyisicalAgentsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = phyisicalAgentsDataGridView.SelectedRows[0];

                PhysicalAgent agent = new PhysicalAgent(
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString()
                );

                EditPhysicalAgentForm editPhysicalAgentForm = new EditPhysicalAgentForm(agent);
                editPhysicalAgentForm.ShowDialog();

                if (editPhysicalAgentForm.createdAgent != null)
                {
                    phyisicalAgentsDataGridView.Rows[row.Index].Cells[0].Value = editPhysicalAgentForm.createdAgent.equipment;
                    phyisicalAgentsDataGridView.Rows[row.Index].Cells[1].Value = editPhysicalAgentForm.createdAgent.usage;
                    phyisicalAgentsDataGridView.Rows[row.Index].Cells[2].Value = editPhysicalAgentForm.createdAgent.generatedRisks;
                }
            }
        }

        private void AddAgentDataToTable(PhysicalAgent createdAgent)
        {
            if (createdAgent != null)
            {
                phyisicalAgentsDataGridView.Rows.Add(
                    createdAgent.equipment,
                    createdAgent.usage,
                    createdAgent.generatedRisks);
            }
        }

        private void CreatePhyisicalAgentList()
        {
            physicalAgentList = new List<PhysicalAgent>();
            foreach (DataGridViewRow row in phyisicalAgentsDataGridView.Rows)
            {
                if (row.Cells[0] != null)
                {
                    PhysicalAgent agent = new PhysicalAgent(
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString()
                    );

                    physicalAgentList.Add(agent);
                }
            }
        }

        private void removePhyisicalAgentButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in phyisicalAgentsDataGridView.SelectedRows)
                phyisicalAgentsDataGridView.Rows.RemoveAt(row.Index);
        }

        public void ValidateData()
        {
            if (this.physicalAgentList == null)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            CreatePhyisicalAgentList();

            if (physicalAgentList.Count <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoPhyisicalAgents);
        }

        private void phyisicalAgentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void writePhysicalInfo(System.IO.FileStream fs)
        {
            CreatePhyisicalAgentList();
            LabMainForm.AddText(fs, "<labPhysicalInfo>\n");
            if(this.physicalAgentList.Count > 0)
            {
                LabMainForm.AddText(fs, "AGENTES\n");

                foreach(PhysicalAgent phy in this.physicalAgentList)
                {
                    LabMainForm.AddText(fs, phy.equipment + '£');
                    LabMainForm.AddText(fs, phy.usage.Replace('\n', ',') + '£');
                    LabMainForm.AddText(fs, phy.generatedRisks.Replace("\n", "#####") + '\n');
                }

                
            }
            else { LabMainForm.AddText(fs, "SEM AGENTES\n"); }

            LabMainForm.AddText(fs, "<\\labPhysicalInfo>\n");
        }

        private void parseAgent(string line)
        {
            string[] information = line.Split('£');
            PhysicalAgent phy = new PhysicalAgent();
            phy.equipment = information[0];
            phy.usage = information[1].Replace(',', '\n');
            phy.generatedRisks = information[2].Replace("#####", "\n");
            AddAgentDataToTable(phy);
        }

        public void loadPhysicalInfo(string path)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {

                string line;
                do { line = sr.ReadLine(); } while (line != "<labPhysicalInfo>");
                line = sr.ReadLine();
                if (line == "AGENTES")
                {
                    line = sr.ReadLine();
                    while (line != "<\\labPhysicalInfo>")
                    {
                        parseAgent(line);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                else sr.Close();

            }
        }
    }
}
