﻿using RyskTech.Data;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace RyskTech.Forms.Lab
{
    public partial class EditChemicalReactorForm : Form
    {
        public ChemicalReactor createdAgent;

        private Dictionary<string, string> subtancesCasNumber = new Dictionary<string, string>();

        private void getAgentNames()
        {
            string substanceString = Properties.Resources.substances;
            string numbersString = Properties.Resources.cas_numbers;
            string[] substances = substanceString.Split('\n');
            string[] casNumbers = numbersString.Split('\n');

            // Populate combo box
            foreach (var substance in substances)
                residueNameTextBox.Items.Add(String.Concat(substance.Where(c => !Char.IsWhiteSpace(c))));

            // Build dictoinary
            for (int i = 0; i < substances.Count(); i++)
            {
                string substance = String.Concat(substances[i].Where(c => !Char.IsWhiteSpace(c)));
                string casNumber = String.Concat(casNumbers[i].Where(c => !Char.IsWhiteSpace(c)));
                subtancesCasNumber.Add(substance, casNumber);
            }
        }

        public EditChemicalReactorForm(ChemicalReactor agent)
        {
            InitializeComponent();

            getAgentNames();

            if (agent != null)
            {
                residueNameTextBox.Text = agent.name;
                physicalStateComboBox.Text = agent.physicalState;
                quantityUpDown.Value = (decimal)agent.quantity;
                measurementUnitComboBox.Text = agent.measurementUnit;
                casNumberTextBox.Text = agent.casNumber;
                if (agent.inert)
                    inertRadioButton.Checked = true;
                else
                    activeRadioButton.Checked = true;
                isDangerousCheckBox.Checked = agent.dangerCharacteristics.Length > 0;
                storageLocationTextBox.Text = agent.storageDetails;
                if (agent.mixtureDescription == null || agent.mixtureDescription.Length <= 0)
                {
                    pureRadioButton.Checked = true;
                    mixedRadioButton.Checked = false;
                }
                else
                {
                    pureRadioButton.Checked = false;
                    mixedRadioButton.Checked = true;
                    mixedSubstanceTextBox.Text = agent.mixtureDescription;
                }
            }
        }

        private void pureRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mixedSubstanceTextBox.Enabled = false;
        }

        private void mixedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mixedSubstanceTextBox.Enabled = true;
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

            string origins = "";
            foreach (string item in originCheckedListBox.CheckedItems)
                origins += item + "\n";


            string dangers = "";
            foreach (string item in dangerCharacteristicsListBox.CheckedItems)
                dangers += item + "\n";


            // Create agent
            ChemicalReactor new_agent = new ChemicalReactor(
                residueNameTextBox.Text,
                physicalStateComboBox.Text,
                (float)quantityUpDown.Value,
                measurementUnitComboBox.Text,
                origins,
                casNumberTextBox.Text,
                mixedRadioButton.Checked ? mixedSubstanceTextBox.Text : "Pura",
                dangers,
                container,
                storageLocationTextBox.Text,
                inertRadioButton.Checked);

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

        private void residueNameTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void residueNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (residueNameTextBox.Items.Contains(residueNameTextBox.Text))
            {
                casNumberTextBox.Enabled = false;
                casNumberTextBox.Text = subtancesCasNumber[residueNameTextBox.Text];
            }
            else
            {
                casNumberTextBox.Enabled = true;
                casNumberTextBox.Text = "";
            }
        }

        private void inertRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void activeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
