using RyskTech.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class RiskAnalysisControl : UserControl
    {
        public List<Risk> data;

        public RiskAnalysisControl()
        {
            InitializeComponent();
        }

        private void RiskAnalysisControlBetter_Load(object sender, EventArgs e)
        {
            data = new List<Risk>();
        }

        private void addRiskButton_Click(object sender, EventArgs e)
        {
            EditRiskForm newRisk = new EditRiskForm(null);
            newRisk.ShowDialog();

            AddAgentDataToTable(newRisk.createdRisk);
        }

        private void editRIskButton_Click(object sender, EventArgs e)
        {
            if (riskDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = riskDataGridView.SelectedRows[0];
                Risk risk = new Risk(
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value == null ? "" : row.Cells[2].Value.ToString(),
                    row.Cells[3].Value == null ? "" : row.Cells[3].Value.ToString(),
                    row.Cells[4].Value == null ? "" : row.Cells[4].Value.ToString());

                EditRiskForm newRisk = new EditRiskForm(risk);
                newRisk.ShowDialog();

                if (newRisk.createdRisk != null)
                {
                    riskDataGridView.Rows[row.Index].Cells[0].Value = newRisk.createdRisk.description;
                    riskDataGridView.Rows[row.Index].Cells[1].Value = newRisk.createdRisk.associatedDanger;
                    riskDataGridView.Rows[row.Index].Cells[2].Value = newRisk.createdRisk.safetyNet;
                    riskDataGridView.Rows[row.Index].Cells[3].Value = newRisk.createdRisk.frequencyClassification;
                    riskDataGridView.Rows[row.Index].Cells[4].Value = newRisk.createdRisk.severityClassification;
                    riskDataGridView.Rows[row.Index].Cells[5].Value = newRisk.createdRisk.riskClassification;
                }
            }
        }

        private void removeRiskButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in riskDataGridView.SelectedRows)
                riskDataGridView.Rows.RemoveAt(row.Index);
        }

        private void AddAgentDataToTable(Risk createdAgent)
        {
            if (createdAgent != null)
            {
                this.riskDataGridView.Rows.Add(
                    createdAgent.description,
                    createdAgent.associatedDanger,
                    createdAgent.safetyNet,
                    createdAgent.frequencyClassification,
                    createdAgent.severityClassification,
                    createdAgent.riskClassification
                    );
            }
        }

        private void CreateRiskList()
        {
            data = new List<Risk>();
            foreach (DataGridViewRow row in riskDataGridView.Rows)
            {
                if (row.Cells[0] != null && row.Cells[0].Value != null)
                {
                    Risk risk = new Risk(
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value == null ? "" : row.Cells[3].Value.ToString(),
                        row.Cells[4].Value == null ? "" : row.Cells[4].Value.ToString());

                    risk.CheckValidity();
                    data.Add(risk);
                }
            }
        }

        public void ValidateData()
        {
            if (data != null)
                CreateRiskList();
        }

        public void writeRisksInfo(System.IO.FileStream fs)
        {
            CreateRiskList();
            LabMainForm.AddText(fs, "<labRisksInfo>\n");
            if (this.data.Count > 0)
            {
                LabMainForm.AddText(fs, "RISCOS\n");

                foreach (Risk risk in this.data)
                {
                    LabMainForm.AddText(fs, risk.description + '£');
                    LabMainForm.AddText(fs, risk.associatedDanger + '£');
                    LabMainForm.AddText(fs, risk.safetyNet.Replace("\n", "###") + '£');
                    LabMainForm.AddText(fs, risk.frequencyClassification + '£');
                    LabMainForm.AddText(fs, risk.severityClassification + '£');
                    LabMainForm.AddText(fs, risk.riskClassification.ToString() + '£' + '\n');

                }


            }
            else { LabMainForm.AddText(fs, "SEM RISCOS\n"); }

            LabMainForm.AddText(fs, "<\\labRisksInfo>\n");
        }

        private void parseRisks(string line)
        {
            string[] information = line.Split('£');
            Risk newRisk = new Risk();
            newRisk.description = information[0];
            newRisk.associatedDanger = information[1];
            newRisk.safetyNet = information[2].Replace("###", "\n");
            newRisk.frequencyClassification = information[3];
            newRisk.severityClassification = information[4];
            newRisk.riskClassification = Convert.ToInt16(information[5]);
            AddAgentDataToTable(newRisk);
            
        }

        public void loadRiskInfo(string path)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {

                string line;
                do { line = sr.ReadLine(); } while (line != "<labRisksInfo>");
                line = sr.ReadLine();
                if (line == "RISCOS")
                {
                    line = sr.ReadLine();
                    while (line != "<\\labRisksInfo>")
                    {
                        parseRisks(line);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                else sr.Close();

            }
        }
    }
}
