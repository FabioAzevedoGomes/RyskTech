using RyskTech.Forms.Lab;
using RyskTech.Forms.Unit;
using System;
using System.IO;
using System.Windows.Forms;

namespace RyskTech.Forms
{
    public partial class WelcomeForm : Form
    {


        public WelcomeForm()
        {
            InitializeComponent();
            MessageBox.Show("Essa é uma versão de testes do software Rysktech. Antes de prosseguir, por favor, confira o manual." );
        }

        private bool checkLabProgress()
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullpath = Path.Combine(appdata, "Rysktech\\progress.rysklab");

            if (File.Exists(fullpath))
            {
                DialogResult res = MessageBox.Show("Deseja continuar o progresso salvo anteriormente ?", "Rysktech",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                    return true;
                else return false;


            }
            else return false;
        }

        private bool checkUnitProgress()
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullpath = Path.Combine(appdata, "Rysktech\\progress.ryskunit");


            if (File.Exists(fullpath))
            {
                DialogResult res = MessageBox.Show("Deseja continuar o progresso salvo anteriormente ?", "Rysktech",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                    return true;
                else return false;


            }
            else return false;
        }

        private void iAmALaboratoryButton_Click(object sender, EventArgs e)
        {
            if (checkLabProgress() == false) {

                Form labForm = new LabMainForm();

                this.Hide();
                labForm.ShowDialog();
                this.Close();
            }
            else
            {
                Form labForm = new LabMainForm(true, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                    , "Rysktech\\progress.rysklab"));
                
                this.Hide();
                labForm.ShowDialog();
                this.Close();
            }
        }
        

        private void iAmAUnitManagerButton_Click(object sender, EventArgs e)
        {
            if (checkUnitProgress() == false)
            {
                Form unitForm = new UnitMainForm();
                this.Hide();
                unitForm.ShowDialog();
                this.Close();

            }
            else
            {
                Form unitForm = new UnitMainForm(true, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "Rysktech\\progress.ryskunit"));

                this.Hide();
                unitForm.ShowDialog();
                this.Close();
            }
            
        }
    }
}
