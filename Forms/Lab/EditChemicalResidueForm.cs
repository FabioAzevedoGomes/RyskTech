using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class EditChemicalResidueForm : Form
    {
        public ChemicalResidue createdAgent;

        public EditChemicalResidueForm(ChemicalResidue agent)
        {
            InitializeComponent();
            if (agent != null)
            {
                string[] origins = agent.origin.Split('\n');
                string[] dangers = agent.dangerCharacteristics.Split('\n');
                string[] containers = agent.container.Split('\n');

                if (origins != null) //Se as boxes  de  uso estiverem marcadas, marca  elas na hora  de edição
                {
                    foreach (string s in origins)
                    {
                        if (s == "Ensino")
                        {
                            originCheckedListBox.SetItemChecked(0, true);
                        }
                        if (s == "Pesquisa")
                        {
                            originCheckedListBox.SetItemChecked(1, true);
                        }
                        if (s == "Extensão")
                        {
                            originCheckedListBox.SetItemChecked(2, true);
                        }
                        if (s == "Processo Produtivo")
                        {
                            originCheckedListBox.SetItemChecked(3, true);
                        }
                    }
                }

                if (dangers != null)
                {
                    foreach (string s in dangers)
                    {
                        if (s == "Inflamável")
                        {
                            dangerCharacteristicsListBox.SetItemChecked(0, true);
                        }
                        if (s == "Corrosivo")
                        {
                            dangerCharacteristicsListBox.SetItemChecked(1, true);
                        }
                        if (s == "Tóxico")
                        {
                            dangerCharacteristicsListBox.SetItemChecked(2, true);
                        }
                        if (s == "Reativo")
                        {
                            dangerCharacteristicsListBox.SetItemChecked(3, true);
                        }
                    }
                }

                if (containers != null)
                {
                    foreach (string s in containers)
                    {
                        if (s == "Vidro temperado transparente")
                        {
                            transparentGlassRadioButton.Checked = true;
                        }
                        if (s == "Vidro temperado âmbar")
                        {
                            amberGlassRadioButton.Checked = true;
                        }
                        if (s == "Bombona plástica")
                        {
                            plasticRadioButton.Checked = true;
                        }
                        if (s == "Outro")
                        {
                            otherRadioButton.Checked = true;
                        }
                    }
                }


                residueNameTextBox.Text = agent.name;
                physicalStateComboBox.Text = agent.physicalState;
                quantityUpDown.Value = (decimal)agent.quantity;
                measurementUnitComboBox.Text = agent.measurementUnit;
                if (agent.inert)
                    inertRadioButton.Checked = true;
                else
                    activeRadioButton.Checked = true;
                isDangerousCheckBox.Checked = agent.dangerCharacteristics.Length > 0;
                storageLocationTextBox.Text = agent.storageDetails;
            }
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            string container = "";
            if (transparentGlassRadioButton.Checked)
                container += Resources.Language.pt_local.TemperedGlassContainer + "\n";
            if (amberGlassRadioButton.Checked)
                container += Resources.Language.pt_local.AmberGlassContainer + "\n";
            if (plasticRadioButton.Checked)
                container += Resources.Language.pt_local.PlasticContainer + "\n";
            if (otherRadioButton.Checked)
                container += "Outro" + "\n";


            string origins = "";
            foreach (string item in originCheckedListBox.CheckedItems)
                origins += item + "\n";


            string dangers = "";
            foreach (string item in dangerCharacteristicsListBox.CheckedItems)
                dangers += item + "\n";


            // Create agent
            ChemicalResidue new_agent =
                new ChemicalResidue(
                    residueNameTextBox.Text,
                    physicalStateComboBox.Text,
                    inertRadioButton.Checked,
                    (float)quantityUpDown.Value,
                    measurementUnitComboBox.Text,
                    origins,
                    isDangerousCheckBox.Checked,
                    dangers,
                    container,
                    storageLocationTextBox.Text
                );

            try
            {
                new_agent.CheckValidity();
                this.createdAgent = new_agent;
                this.Close();
            }
            catch (Exception ex)
            {
                this.createdAgent = null;
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.createdAgent = null;
            this.Close();
        }

        private void inertRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void activeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        } 
    }
}
