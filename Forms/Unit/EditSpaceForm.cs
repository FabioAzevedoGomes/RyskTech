using RyskTech.Data;
using System;
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
                string[] weekdays = space.weekDays.Split('\n');

                if(weekdays != null)
                {
                    foreach (string weekday in weekdays)
                    {
                        if(weekday == "Segunda-Feira")
                        {
                            checkBox1.Checked = true;
                        }
                        if (weekday == "Terça-Feira")
                        {
                            checkBox2.Checked = true;
                        }
                        if (weekday == "Quarta-Feira")
                        {
                            checkBox3.Checked = true;
                        }
                        if (weekday == "Quinta-Feira")
                        {
                            checkBox4.Checked = true;
                        }
                        if (weekday == "Sexta-Feira")
                        {
                            checkBox5.Checked = true;
                        }
                        if (weekday == "Sábado")
                        {
                            checkBox6.Checked = true;
                        }
                        if (weekday == "Domingo")
                        {
                            checkBox7.Checked = true;
                        }
                    }
                }

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
            data.weekDays = "";
            if (checkBox1.Checked)
                data.weekDays += "Segunda-Feira\n";
            if (checkBox2.Checked)
                data.weekDays += "Terça-Feira\n";
            if (checkBox3.Checked)
                data.weekDays += "Quarta-Feira\n";
            if (checkBox4.Checked)
                data.weekDays += "Quinta-Feira\n";
            if (checkBox5.Checked)
                data.weekDays += "Sexta-Feira\n";
            if (checkBox6.Checked)
                data.weekDays += "Sábado\n";
            if (checkBox7.Checked)
                data.weekDays += "Domingo\n";

            try
            {
                data.CheckValidity();
                Close();
            }
            catch (Exception ex)
            {
                data = null;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
