﻿using RyskTech.Data;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class GeneralInformationControl : UserControl
    {
        public Characteristics data;

        public GeneralInformationControl()
        {
            InitializeComponent();
        }

        private void GeneralInformationControl_Load(object sender, System.EventArgs e)
        {
            data = new Characteristics();
        }

        private void responsiblePersonTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.responsiblePersonName = responsiblePersonTextBox.Text;
        }

        private void spaceCharacterizationTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.usageCharacterization = spaceCharacterizationTextBox.Text;
        }

        private void buildingTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.building = buildingTextBox.Text;
        }

        private void roomTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.room = roomTextBox.Text;
        }

        private void responsiblePersonContactTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.responsiblePersonContact = responsiblePersonContactTextBox.Text;
        }

        public void ValidateData()
        {
            data.CheckValidity();
        }
    }
}