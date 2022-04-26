using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class SafetyControl : UserControl
    {
        public Equipment data;
        public Training trainingData;

        public SafetyControl()
        {
            InitializeComponent();
        }

        private void SafetyControlBetter_Load(object sender, EventArgs e)
        {
            data = new Equipment();
            trainingData = new Training();
        }

        private void glassesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[0] = !data.EPIS[0];
        }

        private void concreteWallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[1] = !data.EPIS[1];
        }

        private void glovesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[2] = !data.EPIS[2];
        }

        private void doserCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[3] = !data.EPIS[3];
        }

        private void dustProcetorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[4] = !data.EPIS[4];
        }

        private void maskCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[5] = !data.EPIS[5];

            if (data.EPIS[5])
                masksEPITextBox.Enabled = true;
            else
                masksEPITextBox.Enabled = false;
        }

        private void otherEPICheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[6] = !data.EPIS[6];

            if (data.EPIS[6])
                otherEPITextBox.Enabled = true;
            else
                otherEPITextBox.Enabled = false;
        }

        private void otherEPITextBox_TextChanged(object sender, EventArgs e)
        {
            data.otherEPI = otherEPITextBox.Text;
        }

        private void masksEPITextBox_TextChanged(object sender, EventArgs e)
        {
            data.maskEPI = masksEPITextBox.Text;
        }

        private void sandobxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[0] = !data.EPCS[0];
        }

        private void vermiculitaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[1] = !data.EPCS[1];
        }

        private void calboxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[2] = !data.EPCS[2];
        }

        private void shovelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[3] = !data.EPCS[3];
        }

        private void chapelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[4] = !data.EPCS[4];
        }

        private void exhaustCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[5] = !data.EPCS[5];
        }

        private void otherEPCCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[6] = !data.EPCS[6];

            if (data.EPCS[6])
                otherEPCTextBox.Enabled = true;
            else
                otherEPCTextBox.Enabled = false;
        }

        private void otherEPCTextBox_TextChanged(object sender, EventArgs e)
        {
            data.otherEPC = otherEPCTextBox.Text;
        }

        private void gazeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.firstAidObjects[0] = !data.firstAidObjects[0];
        }

        private void scisorsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.firstAidObjects[1] = !data.firstAidObjects[1];
        }

        private void waterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.firstAidObjects[2] = !data.firstAidObjects[2];
        }

        private void microporeTapeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.firstAidObjects[3] = !data.firstAidObjects[3];
        }

        private void otherFirstAidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.firstAidObjects[4] = !data.firstAidObjects[4];

            if (data.firstAidObjects[4])
                otherFirstAidTextBox.Enabled = true;
            else
                otherFirstAidTextBox.Enabled = false;
        }

        private void otherFirstAidTextBox_TextChanged(object sender, EventArgs e)
        {
            data.otherFirstAid = otherFirstAidTextBox.Text;
        }

        private void noEmergentyBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.noFirstAid = !data.noFirstAid;

            if (data.noFirstAid)
                panel3.Enabled = false;
            else
                panel3.Enabled = true;
        }

        private void yesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trainingData.providesTraining = true;
            textBox1.Enabled = true;
            panel2.Enabled = true;
            numericUpDown1.Enabled = true;
            label7.Enabled = true;
        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trainingData.providesTraining = false;
            textBox1.Enabled = false;
            panel2.Enabled = false;
            numericUpDown1.Enabled = false;
            label7.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trainingData.periodicityAmount = (int)numericUpDown1.Value;
        }

        private void daysRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trainingData.periodicityUnit = "Dias";
        }

        private void monthsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trainingData.periodicityUnit = "Meses";
        }

        private void weeksRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trainingData.periodicityUnit = "Semanas";
        }

        private void yearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trainingData.periodicityUnit = "Anos";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            trainingData.involvedPersonel = textBox1.Text;
        }


        public void ValidateData()
        {
            if (data != null)
                data.CheckValidity();
            else
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            if (trainingData != null)
                trainingData.CheckValidity();
            else
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);
        }


        public void writeSafetyInfo(System.IO.FileStream fs)
        {
            LabMainForm.AddText(fs, "<labSafetyInfo>\n");
            if (glassesCheckBox.Checked == true)
                LabMainForm.AddText(fs, "óculos,");
            if (concreteWallCheckBox.Checked == true)
                LabMainForm.AddText(fs, "auricular,");
            if (glovesCheckBox.Checked == true)
                LabMainForm.AddText(fs, "luvas,");
            if (doserCheckBox.Checked == true)
                LabMainForm.AddText(fs, "dosímetro,");
            if (dustProcetorCheckBox.Checked == true)
                LabMainForm.AddText(fs, "guarda-pó");
            LabMainForm.AddText(fs, "\n");
            if (maskCheckBox.Checked == true)
                LabMainForm.AddText(fs, "máscaras:" + masksEPITextBox.Text + "\n");
            if (otherEPICheckBox.Checked == true)
                LabMainForm.AddText(fs, "outros:" + otherEPITextBox.Text + "\n");
            if (sandobxCheckBox.Checked == true)
                LabMainForm.AddText(fs, "caixa de areia,");
            if (vermiculitaCheckBox.Checked == true)
                LabMainForm.AddText(fs, "vermiculita,");
            if (calboxCheckBox.Checked == true)
                LabMainForm.AddText(fs, "cal,");
            if (shovelCheckBox.Checked == true)
                LabMainForm.AddText(fs, "pá,");
            if (chapelCheckBox.Checked == true)
                LabMainForm.AddText(fs, "capela,");
            if (exhaustCheckBox.Checked == true)
                LabMainForm.AddText(fs, "exaustor");
            LabMainForm.AddText(fs, "\n");
            if (otherEPCCheckBox.Checked == true)
                LabMainForm.AddText(fs, "outros:" + otherEPCTextBox.Text + "\n");
            if (noEmergentyBoxCheckBox.Checked == true)
                LabMainForm.AddText(fs, "sem segurança\n");
            else if (noEmergentyBoxCheckBox.Checked == false)
            {
                if (microporeTapeCheckBox.Checked == true)
                    LabMainForm.AddText(fs, "microporo ");
                if (gazeCheckBox.Checked == true)
                    LabMainForm.AddText(fs, "gaze ");
                if (scisorsCheckBox.Checked == true)
                    LabMainForm.AddText(fs, "tesouras ");
                if (waterCheckBox.Checked == true)
                    LabMainForm.AddText(fs, "água");
                LabMainForm.AddText(fs, "\n");
                if (otherFirstAidCheckBox.Checked == true)
                    LabMainForm.AddText(fs, "outros:" + otherFirstAidTextBox.Text + "\n");
            }
            if (yesRadioButton.Checked == true)
            {
                LabMainForm.AddText(fs, "segurança\n");
                LabMainForm.AddText(fs, numericUpDown1.Value.ToString() + " ");
                if (daysRadioButton.Checked == true)
                    LabMainForm.AddText(fs, "dias\n");
                if (monthsRadioButton.Checked == true)
                    LabMainForm.AddText(fs, "meses\n");
                if (yearsRadioButton.Checked == true)
                    LabMainForm.AddText(fs, "anos\n");
                if (weeksRadioButton.Checked == true)
                    LabMainForm.AddText(fs, "semanas\n");

                LabMainForm.AddText(fs, textBox1.Text + "\n");
                LabMainForm.AddText(fs, "<\\labSafetyInfo>\n");
            }
            else
            {
                LabMainForm.AddText(fs, "sem segurança\n");
                LabMainForm.AddText(fs, "<\\labSafetyInfo>\n");
            }

        }

        public void loadSafetyInfo(string path)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {
                string line;
                do { line = sr.ReadLine(); } while (line != "<labSafetyInfo>");
                line = sr.ReadLine();
                if (line.Contains("óculos"))
                    glassesCheckBox.Checked = true;
                if (line.Contains("auricular"))
                    concreteWallCheckBox.Checked = true;
                if (line.Contains("luvas"))
                    glovesCheckBox.Checked = true;
                if (line.Contains("dosímetro"))
                    doserCheckBox.Checked = true;
                if (line.Contains("guarda-pó"))
                    dustProcetorCheckBox.Checked = true;
                line = sr.ReadLine();
                if (line.Contains("máscaras"))
                {
                    maskCheckBox.Checked = true;
                    string[] field = line.Split(':');
                    masksEPITextBox.Text = field[1];
                    line = sr.ReadLine();
                }
                if (line.Contains("outros"))
                {
                    otherEPICheckBox.Checked = true;
                    string[] field = line.Split(':');
                    otherEPITextBox.Text = field[1];
                    line = sr.ReadLine();
                }
                if (line.Contains("caixa de areia"))
                    sandobxCheckBox.Checked = true;
                if (line.Contains("vermiculita"))
                    vermiculitaCheckBox.Checked = true;
                if (line.Contains("cal"))
                    calboxCheckBox.Checked = true;
                if (line.Contains("pá"))
                    shovelCheckBox.Checked = true;
                if (line.Contains("capela"))
                    chapelCheckBox.Checked = true;
                if (line.Contains("exaustor"))
                    exhaustCheckBox.Checked = true;
                line = sr.ReadLine();
                if (line.Contains("outros"))
                {
                    otherEPCCheckBox.Checked = true;
                    string[] field = line.Split(':');
                    otherEPCTextBox.Text = field[1];
                    line = sr.ReadLine();
                }
                if (line.Contains("sem segurança"))
                {
                    noEmergentyBoxCheckBox.Checked = true;
                    line = sr.ReadLine();
                }
                else
                {
                    if (line.Contains("microporo"))
                        microporeTapeCheckBox.Checked = true;
                    if (line.Contains("gaze"))
                        gazeCheckBox.Checked = true;
                    if (line.Contains("tesouras"))
                        scisorsCheckBox.Checked = true;
                    if (line.Contains("água"))
                        waterCheckBox.Checked = true;
                    line = sr.ReadLine();
                    if (line.Contains("outros"))
                    {
                        otherFirstAidCheckBox.Checked = true;
                        string[] field = line.Split(':');
                        otherFirstAidTextBox.Text = field[1];
                        line = sr.ReadLine();
                    }
                }

                if (line.Contains("sem segurança"))
                {
                    noRadioButton.Checked = true;
                    sr.Close();
                    return;
                }
                else
                {
                    if (line.Contains("segurança"))
                    {
                        yesRadioButton.Checked = true;
                        line = sr.ReadLine();
                        string[] field = line.Split(' ');
                        numericUpDown1.Value = Convert.ToDecimal(field[0]);
                        if (field[1] == "dias")
                            daysRadioButton.Checked = true;
                        if (field[1] == "semanas")
                            weeksRadioButton.Checked = true;
                        if (field[1] == "meses")
                            monthsRadioButton.Checked = true;
                        if (field[1] == "anos")
                            yearsRadioButton.Checked = true;

                        line = sr.ReadLine();
                        while (line != "<\\labSafetyInfo>")
                        {
                            textBox1.Text += line+"\r\n";
                            if (sr.Peek() == '\n')
                                break;

                            line = sr.ReadLine();
                        }
                        sr.Close();
                    }
                }
            }
        }
    }
}
