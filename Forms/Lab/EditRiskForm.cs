using RyskTech.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab
{
    public partial class EditRiskForm : Form
    {
        public Risk createdRisk;

        public EditRiskForm(Risk agent)
        {
            InitializeComponent();
            if (agent != null)
            {
                 
                string[] safetyMeasures = agent.safetyNet.Split('\n');
            

                if (safetyMeasures != null)
                {

                    foreach (string s in safetyMeasures)
                    {
                        if(s.Length > 0)
                        safetyMeasuresListBox.Items.Add(s);
                        

                    }

                }
                dangerComboBox.Text = agent.associatedDanger;
                riskComboBox.Text = agent.description;
                frequencyClassificationComboBox.Text = agent.frequencyClassification;
                severityClassificationComboBox.Text = agent.severityClassification;
            }
        }

        private void frequencyTableButton_Click(object sender, EventArgs e)
        {
            ShowTableForm table = new ShowTableForm(Properties.Resources.Quadro3, "Classificação quanto à frequência");
            table.ShowDialog();
        }

        private void severityTableButotn_Click(object sender, EventArgs e)
        {
            ShowTableForm table = new ShowTableForm(Properties.Resources.Quadro2, "Classificação quanto à severidade");
            table.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            createdRisk = null;
            Close();
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            string safetyMeasures = "";
            foreach (string item in safetyMeasuresListBox.Items)
            {
                safetyMeasures += item + "\n";
            }

            createdRisk = new Risk(
                riskComboBox.Text,
                dangerComboBox.Text,
                safetyMeasures,
                frequencyClassificationComboBox.Text,
                severityClassificationComboBox.Text);

            try
            {
                createdRisk.CheckValidity();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                createdRisk = null;
            }
        }

        private void addSafetyNetButton_Click(object sender, EventArgs e)
        {
            if (safetyGuardComboBox.Text != null && safetyGuardComboBox.Text.Length > 0)
                safetyMeasuresListBox.Items.Add(safetyGuardComboBox.Text);

            safetyGuardComboBox.Text = "";
        }

        private void removeSafetyNetButton_Click(object sender, EventArgs e)
        {
            if (safetyMeasuresListBox.SelectedIndex >= 0)
                safetyMeasuresListBox.Items.RemoveAt(safetyMeasuresListBox.SelectedIndex);
        }
    }
}
