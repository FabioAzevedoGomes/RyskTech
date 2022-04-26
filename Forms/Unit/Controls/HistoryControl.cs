using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit.Controls
{
    public partial class HistoryControl : UserControl
    {
        public string history;

        public HistoryControl()
        {
            InitializeComponent();
        }

        private void UnitHistoryTextBox_TextChanged(object sender, EventArgs e)
        {
            history = UnitHistoryTextBox.Text;
        }

        public void ValidateData()
        {
            if (history == null || history.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.NoHistory);
        }

        public void writeHistory(System.IO.FileStream fs)
        {
            UnitMainForm.AddText(fs, "<unitHistory>\n");
            UnitMainForm.AddText(fs, UnitHistoryTextBox.Text.Replace("\n", "£££"));
            UnitMainForm.AddText(fs, "\n<\\unitHistory>\n");
        }

        public void loadHistory(string path)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {
                string line;
                do { line = sr.ReadLine(); } while (line != "<unitHistory>");
                line = sr.ReadLine();
                UnitHistoryTextBox.Text = line.Replace("£££", "\n");
                sr.Close();
            }
        }
    }
}
