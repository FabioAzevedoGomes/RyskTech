﻿using RyskTech.Data;
using RyskTech.Forms.Lab.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab
{
    public partial class LabMainForm : Form
    {
        private Data.Lab data;
        private int progress;

        // Tabs
        private LabWelcomeControl labWelcomeControl;
        private GeneralInformationControl generalInformationControl;
        private SafetyControl safetyControl;
        private ChemicalAgentControl chemicalAgentControl;
        private BiologicalAgentsControl biologicalAgentControl;
        private PhysicalAgentsControl physicalAgentControl;
        private MechanicalAgentControl mechanicalAgentControl;
        private RiskAnalysisControl riskAnalysisControl;
        private ConclusionControl conclusionControl;

        public LabMainForm()
        {
            InitializeComponent();
        }

        private void LabMainFormBetter_Load(object sender, EventArgs e)
        {
            labWelcomeControl = new LabWelcomeControl();
            labWelcomeControl.Dock = DockStyle.Fill;

            generalInformationControl = new GeneralInformationControl();
            generalInformationControl.Dock = DockStyle.Fill;

            safetyControl = new SafetyControl();
            safetyControl.Dock = DockStyle.Fill;

            chemicalAgentControl = new ChemicalAgentControl();
            chemicalAgentControl.Dock = DockStyle.Fill;

            biologicalAgentControl = new BiologicalAgentsControl();
            biologicalAgentControl.Dock = DockStyle.Fill;

            mechanicalAgentControl = new MechanicalAgentControl();
            mechanicalAgentControl.Dock = DockStyle.Fill;

            physicalAgentControl = new PhysicalAgentsControl();
            physicalAgentControl.Dock = DockStyle.Fill;

            riskAnalysisControl = new RiskAnalysisControl();
            riskAnalysisControl.Dock = DockStyle.Fill;

            conclusionControl = new ConclusionControl();
            conclusionControl.Dock = DockStyle.Fill;

            //

            activeControlPanel.Controls.Add(labWelcomeControl);
            welcomeTabButton.BackColor = Color.DarkGray;

            progress = 1;
            data = new Data.Lab();
        }

        private void clearTabButtonColors()
        {
            welcomeTabButton.BackColor = Color.LightGray;
            generalInfoTabButton.BackColor = Color.LightGray;
            safetyTabButton.BackColor = Color.LightGray;
            chemicalAgentsTabButton.BackColor = Color.LightGray;
            biologicalAgentTabButton.BackColor = Color.LightGray;
            physicalAgentTabButton.BackColor = Color.LightGray;
            mechanicalAgentsTabButton.BackColor = Color.LightGray;
            risksTabButton.BackColor = Color.LightGray;
            conclusionTabButton.BackColor = Color.LightGray;
        }

        private void welcomeTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(labWelcomeControl);

            clearTabButtonColors();
            welcomeTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Bem Vindo!";
            nextConcludeButton.Text = "Próximo";

            progress = 1;
        }

        private void generalInfoTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(generalInformationControl);

            clearTabButtonColors();
            generalInfoTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Informações Gerais";
            nextConcludeButton.Text = "Próximo";

            progress = 2;
        }

        private void safetyTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(safetyControl);

            clearTabButtonColors();
            safetyTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Informações de Segurança";
            nextConcludeButton.Text = "Próximo";

            progress = 3;
        }

        private void chemicalAgentsTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();

            if (labWelcomeControl.data.manipulatesChemicalAgents)
                activeControlPanel.Controls.Add(chemicalAgentControl);
            else
                activeControlPanel.Controls.Add(new ErrorControl("químicos"));

            clearTabButtonColors();
            chemicalAgentsTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Agentes Químicos";
            nextConcludeButton.Text = "Próximo";

            progress = 4;
        }

        private void biologicalAgentTabButton_Click(object sender, EventArgs e)
        {

            activeControlPanel.Controls.Clear();

            if (labWelcomeControl.data.manipulatesBiologicalAgents)
                activeControlPanel.Controls.Add(biologicalAgentControl);
            else
                activeControlPanel.Controls.Add(new ErrorControl("biológicos"));

            clearTabButtonColors();
            biologicalAgentTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Agentes Biológicos";
            nextConcludeButton.Text = "Próximo";

            progress = 5;
        }

        private void physicalAgentTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();

            if (labWelcomeControl.data.manipulatesPhysicalAgents)
                activeControlPanel.Controls.Add(physicalAgentControl);
            else
                activeControlPanel.Controls.Add(new ErrorControl("físicos"));

            clearTabButtonColors();
            physicalAgentTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Agentes Físicos";
            nextConcludeButton.Text = "Próximo";

            progress = 6;

        }

        private void mechanicalAgentsTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(mechanicalAgentControl);

            clearTabButtonColors();
            mechanicalAgentsTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Agentes Mecânicos";
            nextConcludeButton.Text = "Próximo";

            progress = 7;
        }

        private void risksTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(riskAnalysisControl);

            clearTabButtonColors();
            risksTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Riscos";
            nextConcludeButton.Text = "Próximo";

            progress = 8;
        }

        private void conclusionTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(conclusionControl);

            clearTabButtonColors();
            conclusionTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Considerações Finais";
            nextConcludeButton.Text = "Concluir";

            progress = 9;
        }

        private void PrepareForGeneration()
        {
            labWelcomeControl.ValidateData();
            data.generalInformation = labWelcomeControl.data;

            generalInformationControl.ValidateData();
            data.spaceCharacterization = generalInformationControl.data;

            safetyControl.ValidateData();
            data.safetyEquipment = safetyControl.data;
            data.safetyTraining = safetyControl.trainingData;

            if (data.generalInformation.manipulatesChemicalAgents)
            {
                chemicalAgentControl.ValidateData();
                data.manipulatedChemicalResidues = chemicalAgentControl.residueData;
                data.manipulatedChemicalReactors = chemicalAgentControl.reactorData;
                data.chemicalResidueStorageInfo = chemicalAgentControl.storageInfo;
            }

            if (data.generalInformation.manipulatesBiologicalAgents)
            {
                biologicalAgentControl.ValidateData();
                data.biologicalAgentsInfo = biologicalAgentControl.data;
                data.biologicalAgentsDestination = biologicalAgentControl.destination;
                data.biologicalAgentsStorage = biologicalAgentControl.storage;
            }

            mechanicalAgentControl.ValidateData();
            data.mechanicalAgentsInfo = mechanicalAgentControl.mechanicalAgentList;

            if (data.generalInformation.manipulatesPhysicalAgents)
            {
                physicalAgentControl.ValidateData();
                data.physicalAgentsInfo = physicalAgentControl.physicalAgentList;
            }

            riskAnalysisControl.ValidateData();
            conclusionControl.ValidateData();
            data.riskAnalysisInformation = new RiskAnalysis();
            data.riskAnalysisInformation.conclusion = conclusionControl.conclusion;
            data.riskAnalysisInformation.accidents = conclusionControl.accidentHistory;
            data.riskAnalysisInformation.recomendations = conclusionControl.recomendation;
            data.riskAnalysisInformation.identifiedRisks = riskAnalysisControl.data;
            data.riskAnalysisInformation.CheckValidity();
        }

        private void conclude()
        {
            try
            {
                PrepareForGeneration();

                APR compilation = new APR(data);

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Word Document|*.docx";
                save.Title = "Salvar APR";

                DialogResult result = save.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(save.FileName))
                {
                    if (compilation.lab.biologicalAgentsInfo.hasBioSecurityCertificate)
                    {
                        MessageBox.Show("Por favor, apresente o certificado de biossegurança do seu laboratório");
                        OpenFileDialog open = new OpenFileDialog();
                        open.Filter = "Pdf Document|*.pdf";
                        open.Title = "Certificado de Biossegurança";

                        DialogResult openResult = open.ShowDialog();

                        if (openResult == DialogResult.OK && !string.IsNullOrWhiteSpace(open.FileName))
                        {
                            DocumentBuilder docBuilder = new DocumentBuilder(compilation, save.FileName);

                            int statusCode = docBuilder.CreateLabDocumentFromAPR();
                            File.Copy(open.FileName, save.FileName + "_certificado.pdf");

                            if (statusCode == 0)
                                MessageBox.Show("APR Gerada com sucesso!", "Obrigado por usar RyskTech! :)");
                            else
                                MessageBox.Show("Foram encontrados alguns erros na geração da APR", ":(");

                            Close();
                        }
                    }
                    else
                    {
                        DocumentBuilder docBuilder = new DocumentBuilder(compilation, save.FileName);

                        int statusCode = docBuilder.CreateLabDocumentFromAPR();

                        if (statusCode == 0)
                            MessageBox.Show("APR Gerada com sucesso!", "Obrigado por usar RyskTech! :)");
                        else
                            MessageBox.Show("Foram encontrados alguns erros na geração da APR", ":(");

                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nextConcludeButton_Click(object sender, EventArgs e)
        {
            switch (progress)
            {
                case 1:
                    generalInfoTabButton_Click(this, null);
                    break;
                case 2:
                    safetyTabButton_Click(this, null);
                    break;
                case 3:
                    chemicalAgentsTabButton_Click(this, null);
                    break;
                case 4:
                    biologicalAgentTabButton_Click(this, null);
                    break;
                case 5:
                    physicalAgentTabButton_Click(this, null);
                    break;
                case 6:
                    mechanicalAgentsTabButton_Click(this, null);
                    break;
                case 7:
                    risksTabButton_Click(this, null);
                    break;
                case 8:
                    conclusionTabButton_Click(this, null);
                    break;
                case 9:
                    conclude();
                    break;
            }

        }
    }
}
