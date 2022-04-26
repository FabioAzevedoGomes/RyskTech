using RyskTech.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit.Controls
{
    public partial class StructureControl : UserControl
    {
        public Structure data;

        public StructureControl()
        {
            InitializeComponent();
        }

        private void TestStructureControl_Load(object sender, EventArgs e)
        {
            data = new Structure();
        }

        private void addSpaceButton_Click(object sender, EventArgs e)
        {
            EditSpaceForm form = new EditSpaceForm(null);
            form.ShowDialog();

            if (form.data != null)
                addDataToTable(form.data);
        }

        private void editSpaceButton_Click(object sender, EventArgs e)
        {
            if (InternalStructureDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = InternalStructureDataGridView.SelectedRows[0];

                Space entry = new Space();
                entry.buildingIdentifier = row.Cells[0].Value.ToString();
                entry.roomIdentifier = row.Cells[1].Value.ToString();
                entry.floorIdentifier = row.Cells[2].Value.ToString();
                entry.turnStart = System.TimeSpan.Parse(row.Cells[3].Value.ToString());
                entry.turnEnd = System.TimeSpan.Parse(row.Cells[4].Value.ToString());
                entry.surroundingsComments = row.Cells[5].Value.ToString();
                entry.weekDays = row.Cells[6].Value.ToString();

                EditSpaceForm form = new EditSpaceForm(entry);
                form.ShowDialog();

                if (form.data != null)
                {
                    InternalStructureDataGridView.Rows[row.Index].Cells[0].Value = form.data.buildingIdentifier;
                    InternalStructureDataGridView.Rows[row.Index].Cells[1].Value = form.data.roomIdentifier;
                    InternalStructureDataGridView.Rows[row.Index].Cells[2].Value = form.data.floorIdentifier;
                    InternalStructureDataGridView.Rows[row.Index].Cells[3].Value = form.data.turnStart.ToString();
                    InternalStructureDataGridView.Rows[row.Index].Cells[4].Value = form.data.turnEnd.ToString();
                    InternalStructureDataGridView.Rows[row.Index].Cells[5].Value = form.data.surroundingsComments;
                    InternalStructureDataGridView.Rows[row.Index].Cells[6].Value = form.data.weekDays;
                }
            }
        }

        private void removeSpaceButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in InternalStructureDataGridView.SelectedRows)
                InternalStructureDataGridView.Rows.RemoveAt(row.Index);
        }

        private void addDataToTable(Space createdSpace)
        {
            if (createdSpace != null)
            {
                InternalStructureDataGridView.Rows.Add(
                    createdSpace.buildingIdentifier,
                    createdSpace.roomIdentifier,
                    createdSpace.floorIdentifier,
                    createdSpace.turnStart.ToString(),
                    createdSpace.turnEnd.ToString(),
                    createdSpace.surroundingsComments,
                    createdSpace.weekDays);
            }
        }

        private List<Space> GetStructureData()
        {
            List<Space> result = new List<Space>();

            foreach (DataGridViewRow row in InternalStructureDataGridView.Rows)
            {
                Space entry = new Space();

                if (row.Cells[0].Value != null)
                {
                    entry.buildingIdentifier = row.Cells[0].Value.ToString();
                    if (row.Cells[1].Value != null)
                        entry.roomIdentifier = row.Cells[1].Value.ToString();
                    if (row.Cells[2].Value != null)
                        entry.floorIdentifier = row.Cells[2].Value.ToString();
                    if (row.Cells[3].Value != null)
                        entry.turnStart = System.TimeSpan.Parse(row.Cells[3].Value.ToString());
                    if (row.Cells[4].Value != null)
                        entry.turnEnd = System.TimeSpan.Parse(row.Cells[4].Value.ToString());
                    if (row.Cells[5].Value != null)
                        entry.surroundingsComments = row.Cells[5].Value.ToString();
                    if (row.Cells[6].Value != null)
                        entry.weekDays = row.Cells[6].Value.ToString();

                    result.Add(entry);
                }
            }

            return result;
        }

        public void ValidateData()
        {
            data.spaces = GetStructureData();
            data.CheckValidity();
        }


        public void writeStructureInformation(System.IO.FileStream fs)
        {
            data.spaces = GetStructureData();
            UnitMainForm.AddText(fs, "<unitStructure>\n");
            if (this.data.spaces.Count > 0)
            {
                UnitMainForm.AddText(fs, "ESPAÇOS\n");

                foreach (Space sp in this.data.spaces)
                {
                    UnitMainForm.AddText(fs, sp.buildingIdentifier + '£');
                    UnitMainForm.AddText(fs, sp.roomIdentifier + '£');
                    UnitMainForm.AddText(fs, sp.floorIdentifier + '£');
                    UnitMainForm.AddText(fs, sp.turnStart.ToString() + '£');
                    UnitMainForm.AddText(fs, sp.turnEnd.ToString() + '£');
                    UnitMainForm.AddText(fs, sp.surroundingsComments + '£');
                    UnitMainForm.AddText(fs, sp.weekDays.Replace('\n', ',') + '\n');
                }
            }
            else UnitMainForm.AddText(fs, "SEM ESPAÇOS\n");
            UnitMainForm.AddText(fs, "<\\unitStructure>\n");


        }

        private void parseSpace(string line)
        {
            string[] parser = line.Split('£');
            Space sp = new Space();
            sp.buildingIdentifier = parser[0];
            sp.roomIdentifier = parser[1];
            sp.floorIdentifier = parser[2];
            sp.turnStart = System.TimeSpan.Parse(parser[3]);
            sp.turnEnd = System.TimeSpan.Parse(parser[4]); 
            sp.surroundingsComments = parser[5];
            sp.weekDays = parser[6].Replace(',','\n');
            addDataToTable(sp);
        }

        public void loadStructureInformation(string path)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
            {
                string line;
                do { line = sr.ReadLine(); } while (line != "<unitStructure>");
                line = sr.ReadLine();
                if (line == "ESPAÇOS")
                {
                    line = sr.ReadLine();
                    while (line != "<\\unitStructure>")
                    {
                        parseSpace(line);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                else sr.Close();
            }

        }



        }
}
