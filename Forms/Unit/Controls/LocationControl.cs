using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit.Controls
{
    public partial class LocationControl : UserControl
    {
        public Location data;

        public LocationControl()
        {
            InitializeComponent();
        }

        private void TestLocationControl_Load(object sender, EventArgs e)
        {
            data = new Location();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Rua":
                    data.prefix = LocationPrefix.Road;
                    break;
                case "Av.":
                    data.prefix = LocationPrefix.Avenue;
                    break;
                case "Al.":
                    data.prefix = LocationPrefix.Boulevard;
                    break;
                case "Tv.":
                    data.prefix = LocationPrefix.Crossing;
                    break;
                case "Rod.":
                    data.prefix = LocationPrefix.Highway;
                    break;
                default:
                    break;
            }
        }
        private void UnitSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Temporary fix until I find out why javascript is giving errors
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate(data.GetGoogleMapsSearchURL());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            data.streetName = StreetTextBox.Text;
        }

        private void NeighborhoodTextBox_TextChanged(object sender, EventArgs e)
        {
            data.district = NeighborhoodTextBox.Text;
        }

        private void ZIPTextBox_TextChanged(object sender, EventArgs e)
        {
            data.ZIPCode = ZIPTextBox.Text;
        }

        private void ComplementTextBox_TextChanged(object sender, EventArgs e)
        {
            data.complement = ComplementTextBox.Text;
        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NumberTextBox.Text.Length > 0)
            {
                try
                {
                    data.streetNumber = int.Parse(NumberTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Por favor digite apenas números");
                    NumberTextBox.Text = "";
                }
            }
        }

        public void ValidateData()
        {
            if (data != null)
                data.CheckValidity();
            else
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);
        }

        public void writeLocationInfo(System.IO.FileStream fs)
        {
            UnitMainForm.AddText(fs, "<unitLocation>\n");
            if (comboBox1.SelectedItem == null)
                UnitMainForm.AddText(fs, "0" + '£');
            else
            UnitMainForm.AddText(fs, comboBox1.SelectedItem.ToString() + '£');
            UnitMainForm.AddText(fs, StreetTextBox.Text + '£'
                + NumberTextBox.Text + '£'
                + NeighborhoodTextBox.Text + '£'
                + ZIPTextBox.Text + '£'
                + ComplementTextBox.Text);
            UnitMainForm.AddText(fs, "\n<\\unitLocation>\n");
        }
        public void loadLocationInfo(string path)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {
                string line;
                do { line = sr.ReadLine(); } while (line != "<unitLocation>");
                line = sr.ReadLine();
                string[] parseLine = line.Split('£');
                if(parseLine[0] != "0")
                comboBox1.SelectedItem = parseLine[0];
                StreetTextBox.Text = parseLine[1];
                NumberTextBox.Text = parseLine[2];
                NeighborhoodTextBox.Text = parseLine[3];
                ZIPTextBox.Text = parseLine[4];
                ComplementTextBox.Text = parseLine[5];
                sr.Close();
            }
        }
    }
}
