using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab
{
    public partial class EditPhysicalAgentForm : Form
    {
        public PhysicalAgent createdAgent;

        public EditPhysicalAgentForm(PhysicalAgent agent)
        {
            InitializeComponent();
            if (agent != null)
            {
                string[] usage = agent.usage.Split('\n');
                string[] risks = agent.generatedRisks.Split('\n');

                equipmentTextBox.Text = agent.equipment;

                if(usage != null)
                {
                    foreach(string s in usage)
                    {
                        if (s == "Ensino")
                        {
                            teachingCheckBox.Checked = true;
                        }
                        if (s == "Pesquisa")
                        {
                            researchCheckBox.Checked = true;
                        }
                        if (s == "Extensão")
                        {
                            extensionCheckBox.Checked = true;
                        }
                        if (s == "Processo Produtivo")
                        {
                            productiveProcessCheckBox.Checked = true;
                        }
                    }
                }


                foreach(string s in risks)
                {
                    if(s.Contains("Ruídos"))
                    {
                        noiseCheckBox.Checked = true;
                        noiseTextBox.Text = s.Split(':')[1];
                    }
                    if(s.Contains("Temperaturas Extremas"))
                    {
                        extremeTemperatureCheckBox.Checked = true;
                        temperatureTextBox.Text = s.Split(':')[1];
                    }
                    if(s.Contains("Pressões Extremas"))
                    {
                        pressureCheckBox.Checked = true;
                        pressureTextBox.Text = s.Split(':')[1]; 
                    }
                    if(s.Contains("Radiação"))
                    {
                        radiationCheckBox.Checked = true;
                    }
                    if (s.Contains("Radiação Ionizante"))
                    {
                        radiationCheckBox.Checked = true;
                        ionizingCheckBox.Checked = true; 
                    }
                    if (s.Contains("Radiação Não Ionizante"))
                    {
                        radiationCheckBox.Checked= true;
                        notIonizingCheckBox.Checked = true;
                    }
                    if (s.Contains("Radiação Ionizante e Não Ionizante"))
                    {
                        radiationCheckBox.Checked = true;
                        ionizingCheckBox.Checked = true;
                        notIonizingCheckBox.Checked = true;
                    }

                    if (s.Contains("Campos magnéticos intensos"))
                    {
                        intensemagnecticFieldCheckBox.Checked = true;
                    }
                    if( s.Contains("Infrassom"))
                    {
                        infraSoundCheckBox.Checked = true;
                    }
                    if( s.Contains("Ultrassom"))
                    {
                        ultrasoundCheckBox.Checked = true;  
                    }
                    if( s.Contains("Umidade"))
                    {
                        humidityCheckBox.Checked = true;
                    }
                    if (s.Contains("Vibrações"))
                    {
                        vibrationCheckBox.Checked = true; 
                    }


                }

            }
        }

        private void noiseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (noiseCheckBox.Checked)
                noiseTextBox.Enabled = true;
            else
                noiseTextBox.Enabled = false;
        }

        private void extremeTemperatureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (extremeTemperatureCheckBox.Checked)
                temperatureTextBox.Enabled = true;
            else
                temperatureTextBox.Enabled = false;
        }

        private void pressureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pressureCheckBox.Checked)
                pressureTextBox.Enabled = true;
            else
                pressureTextBox.Enabled = false;
        }

        private void radiationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (radiationCheckBox.Checked)
            {
                ionizingCheckBox.Enabled = true;
                notIonizingCheckBox.Enabled = true;
            }
            else
            {
                ionizingCheckBox.Enabled = false;
                notIonizingCheckBox.Enabled = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            createdAgent = null;
            Close();
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            PhysicalAgent agent = new PhysicalAgent();

            string usageScenarios = "";
            if (teachingCheckBox.Checked)
                usageScenarios += "Ensino\n";

            if (researchCheckBox.Checked)
                usageScenarios += "Pesquisa\n";

            if (productiveProcessCheckBox.Checked)
                usageScenarios += "Processo Produtivo\n";

            if (extensionCheckBox.Checked)
                usageScenarios += "Extensão\n";

            string risks = "";

            if (noiseCheckBox.Checked)
                risks += "Ruídos: " + noiseTextBox.Text + "\n";

            if (extremeTemperatureCheckBox.Checked)
                risks += "Temperaturas Extremas: " + temperatureTextBox.Text + "\n";

            if (pressureCheckBox.Checked)
                risks += "Pressões Extremas: " + pressureTextBox.Text + "\n";

            if (radiationCheckBox.Checked)
                risks += "Radiação " + (ionizingCheckBox.Checked ? "Ionizante" : "") + (ionizingCheckBox.Checked && notIonizingCheckBox.Checked ? " e " : "") + (notIonizingCheckBox.Checked ? "Não Ionizante" : "") + "\n";

            if (intensemagnecticFieldCheckBox.Checked)
                risks += "Campos magnéticos intensos\n";

            if (infraSoundCheckBox.Checked)
                risks += "Infrassom";

            if (ultrasoundCheckBox.Checked)
                risks += "Ultrassom\n";

            if (humidityCheckBox.Checked)
                risks += "Umidade\n";

            if (vibrationCheckBox.Checked)
                risks += "Vibrações\n";

            agent.generatedRisks = risks;
            agent.equipment = equipmentTextBox.Text;
            agent.usage = usageScenarios;

            try
            {
                agent.CheckValidity();
                createdAgent = agent;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                createdAgent = null;
            }
        }
    }
}
