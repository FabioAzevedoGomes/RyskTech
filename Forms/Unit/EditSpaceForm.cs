﻿using System;
using RyskTech.Data;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit
{
    public partial class EditSpaceForm : Form
    {
        public Space data;

        public EditSpaceForm(Space space)
        {
            InitializeComponent();
            if (space != null)
            {
                buildingTextBox.Text = space.buildingIdentifier;
                roomTextBox.Text = space.roomIdentifier;
                floorTextBox.Text = space.floorIdentifier;
                
                startHourNumericUpDown.Value = space.turnStart.Hours;
                startMinutesNumericUpDown.Value = space.turnStart.Minutes;

                endHourNumericUpDown.Value = space.turnEnd.Hours;
                endMinuteNumericUpDown.Value = space.turnEnd.Minutes;

                surroundingInfoTextBox.Text = space.surroundingsComments;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            data = null;
            Close();
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            data = new Space();

            data.buildingIdentifier = buildingTextBox.Text;
            data.roomIdentifier = roomTextBox.Text;
            data.floorIdentifier = floorTextBox.Text;
            data.turnStart = new TimeSpan((int)startHourNumericUpDown.Value, (int)startMinutesNumericUpDown.Value, 0);
            data.turnEnd = new TimeSpan((int)endHourNumericUpDown.Value, (int)endMinuteNumericUpDown.Value, 0);
            data.surroundingsComments = surroundingInfoTextBox.Text;

            try
            {
                data.CheckValidity();
                Close();
            } catch(Exception ex)
            {
                data = null;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
