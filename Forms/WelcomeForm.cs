﻿using RyskTech.Forms.Lab;
using RyskTech.Forms.Unit;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void iAmALaboratoryButton_Click(object sender, EventArgs e)
        {
            Form labForm = new LabMainFormBetter();

            this.Hide();
            labForm.ShowDialog();
            this.Close();
        }

        private void iAmAUnitManagerButton_Click(object sender, EventArgs e)
        {
            Form unitForm = new UnitMainFormBetter();

            this.Hide();
            unitForm.ShowDialog();
            this.Close();
        }
    }
}
