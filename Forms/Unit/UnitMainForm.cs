﻿using RyskTech.Forms.Unit.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit
{
    public partial class UnitMainForm : Form
    {
        private Data.Unit data;
        private int progress;

        private WelcomeControl testWelcomeControl;
        private LocationControl testLocationControl;
        private TeamControl testTeamControl;
        private StructureControl testStructureControl;
        private HistoryControl testHistoryControl;
        private MethodologyControl testMethodologyControl;

        public UnitMainForm()
        {
            InitializeComponent();
        }

        private void UITestForm_Load(object sender, EventArgs e)
        {
            testWelcomeControl = new WelcomeControl();
            testWelcomeControl.Dock = DockStyle.Fill;

            testLocationControl = new LocationControl();
            testLocationControl.Dock = DockStyle.Fill;

            testTeamControl = new TeamControl();
            testTeamControl.Dock = DockStyle.Fill;

            testStructureControl = new StructureControl();
            testStructureControl.Dock = DockStyle.Fill;

            testHistoryControl = new HistoryControl();
            testHistoryControl.Dock = DockStyle.Fill;

            testMethodologyControl = new MethodologyControl();
            testMethodologyControl.Dock = DockStyle.Fill;

            activeControlPanel.Controls.Add(testWelcomeControl);
            welcomeTabButton.BackColor = Color.DarkGray;

            progress = 1;
            this.data = new Data.Unit();
        }

        private void cleartabButtonColors()
        {
            welcomeTabButton.BackColor = Color.LightGray;
            locationTabButton.BackColor = Color.LightGray;
            teamTabButton.BackColor = Color.LightGray;
            structureTabButton.BackColor = Color.LightGray;
            historyTabButton.BackColor = Color.LightGray;
            methodologyTabButton.BackColor = Color.LightGray;
        }

        private void welcomeTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(testWelcomeControl);

            cleartabButtonColors();
            welcomeTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Bem Vindo!";
            nextConcludeButton.Text = "Próximo";

            progress = 1;
        }

        private void locationTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(testLocationControl);

            cleartabButtonColors();
            locationTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Localização";
            nextConcludeButton.Text = "Próximo";

            progress = 2;
        }

        private void teamTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(testTeamControl);

            cleartabButtonColors();
            teamTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Equipe";
            nextConcludeButton.Text = "Próximo";

            progress = 3;
        }

        private void structureTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(testStructureControl);

            cleartabButtonColors();
            structureTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Estrutura";
            nextConcludeButton.Text = "Próximo";

            progress = 4;
        }

        private void historyTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(testHistoryControl);

            cleartabButtonColors();
            historyTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Histórico";
            nextConcludeButton.Text = "Próximo";

            progress = 5;
        }

        private void methodologyTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(testMethodologyControl);

            cleartabButtonColors();
            methodologyTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Metodologia";
            nextConcludeButton.Text = "Concluir";

            progress = 6;
        }

        private void PrepareForGeneration()
        {
            testWelcomeControl.ValidateData();
            data.generalInformation = testWelcomeControl.data;

            testLocationControl.ValidateData();
            data.location = testLocationControl.data;

            testTeamControl.ValidateData();
            data.team = testTeamControl.data;

            testStructureControl.ValidateData();
            data.structure = testStructureControl.data;

            testHistoryControl.ValidateData();
            data.history = testHistoryControl.history;

            testMethodologyControl.ValidateData();
            data.methodologyDescription = testMethodologyControl.methodology;
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
                    DocumentBuilder docBuilder = new DocumentBuilder(compilation, save.FileName);

                    int statusCode = docBuilder.CreateUnitDocumentFromAPR();

                    if (statusCode == 0)
                        MessageBox.Show("APR Gerada com sucesso!", "Obrigado por usar RyskTech! :)");
                    else
                        MessageBox.Show("Foram encontrados alguns erros na geração da APR", ":(");

                    Close();
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
                    locationTabButton_Click(this, null);
                    break;
                case 2:
                    teamTabButton_Click(this, null);
                    break;
                case 3:
                    structureTabButton_Click(this, null);
                    break;
                case 4:
                    historyTabButton_Click(this, null);
                    break;
                case 5:
                    methodologyTabButton_Click(this, null);
                    break;
                case 6:
                    conclude();
                    break;
            }

        }
    }
}
