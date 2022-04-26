
namespace RyskTech.Forms.Lab.Controls
{
    partial class LabWelcomeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabWelcomeControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generalInfotableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.unitNameTextBox = new System.Windows.Forms.TextBox();
            this.unitNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.physicalAgentsUsedCheckBox = new System.Windows.Forms.CheckBox();
            this.chemicalAgentsUsedCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.biologicalAgentsUsedCheckBox = new System.Windows.Forms.CheckBox();
            this.manipulatedAgentsLabel = new System.Windows.Forms.Label();
            this.labNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.generalInfotableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.generalInfotableLayoutPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 310);
            this.groupBox1.Name = "groupBox1";
            this.mainTableLayoutPanel.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(590, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Gerais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // generalInfotableLayoutPanel
            // 
            this.generalInfotableLayoutPanel.ColumnCount = 3;
            this.generalInfotableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.91519F));
            this.generalInfotableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.5159F));
            this.generalInfotableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.generalInfotableLayoutPanel.Controls.Add(this.unitNameTextBox, 1, 0);
            this.generalInfotableLayoutPanel.Controls.Add(this.unitNameLabel, 0, 0);
            this.generalInfotableLayoutPanel.Controls.Add(this.panel1, 1, 2);
            this.generalInfotableLayoutPanel.Controls.Add(this.panel2, 2, 2);
            this.generalInfotableLayoutPanel.Controls.Add(this.manipulatedAgentsLabel, 0, 2);
            this.generalInfotableLayoutPanel.Controls.Add(this.labNameTextBox, 1, 1);
            this.generalInfotableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.generalInfotableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalInfotableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.generalInfotableLayoutPanel.Name = "generalInfotableLayoutPanel";
            this.generalInfotableLayoutPanel.RowCount = 3;
            this.generalInfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalInfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalInfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.generalInfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalInfotableLayoutPanel.Size = new System.Drawing.Size(584, 90);
            this.generalInfotableLayoutPanel.TabIndex = 0;
            // 
            // unitNameTextBox
            // 
            this.unitNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.generalInfotableLayoutPanel.SetColumnSpan(this.unitNameTextBox, 2);
            this.unitNameTextBox.Location = new System.Drawing.Point(166, 4);
            this.unitNameTextBox.Name = "unitNameTextBox";
            this.unitNameTextBox.Size = new System.Drawing.Size(415, 20);
            this.unitNameTextBox.TabIndex = 1;
            this.unitNameTextBox.TextChanged += new System.EventHandler(this.unitNameTextBox_TextChanged);
            // 
            // unitNameLabel
            // 
            this.unitNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unitNameLabel.AutoSize = true;
            this.unitNameLabel.Location = new System.Drawing.Point(12, 1);
            this.unitNameLabel.Name = "unitNameLabel";
            this.unitNameLabel.Size = new System.Drawing.Size(138, 26);
            this.unitNameLabel.TabIndex = 0;
            this.unitNameLabel.Text = "Qual o nome da unidade da qual você faz parte?";
            this.unitNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.physicalAgentsUsedCheckBox);
            this.panel1.Controls.Add(this.chemicalAgentsUsedCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(166, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 26);
            this.panel1.TabIndex = 4;
            // 
            // physicalAgentsUsedCheckBox
            // 
            this.physicalAgentsUsedCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.physicalAgentsUsedCheckBox.AutoSize = true;
            this.physicalAgentsUsedCheckBox.Location = new System.Drawing.Point(124, 3);
            this.physicalAgentsUsedCheckBox.Name = "physicalAgentsUsedCheckBox";
            this.physicalAgentsUsedCheckBox.Size = new System.Drawing.Size(60, 17);
            this.physicalAgentsUsedCheckBox.TabIndex = 2;
            this.physicalAgentsUsedCheckBox.Text = "Físicos";
            this.physicalAgentsUsedCheckBox.UseVisualStyleBackColor = true;
            this.physicalAgentsUsedCheckBox.CheckedChanged += new System.EventHandler(this.physicalAgentsUsedCheckBox_CheckedChanged);
            // 
            // chemicalAgentsUsedCheckBox
            // 
            this.chemicalAgentsUsedCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chemicalAgentsUsedCheckBox.AutoSize = true;
            this.chemicalAgentsUsedCheckBox.Location = new System.Drawing.Point(18, 3);
            this.chemicalAgentsUsedCheckBox.Name = "chemicalAgentsUsedCheckBox";
            this.chemicalAgentsUsedCheckBox.Size = new System.Drawing.Size(71, 17);
            this.chemicalAgentsUsedCheckBox.TabIndex = 0;
            this.chemicalAgentsUsedCheckBox.Text = "Químicos";
            this.chemicalAgentsUsedCheckBox.UseVisualStyleBackColor = true;
            this.chemicalAgentsUsedCheckBox.CheckedChanged += new System.EventHandler(this.chemicalAgentsUsedCheckBox_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.biologicalAgentsUsedCheckBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(391, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 26);
            this.panel2.TabIndex = 5;
            // 
            // biologicalAgentsUsedCheckBox
            // 
            this.biologicalAgentsUsedCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.biologicalAgentsUsedCheckBox.AutoSize = true;
            this.biologicalAgentsUsedCheckBox.Location = new System.Drawing.Point(3, 3);
            this.biologicalAgentsUsedCheckBox.Name = "biologicalAgentsUsedCheckBox";
            this.biologicalAgentsUsedCheckBox.Size = new System.Drawing.Size(74, 17);
            this.biologicalAgentsUsedCheckBox.TabIndex = 1;
            this.biologicalAgentsUsedCheckBox.Text = "Biológicos";
            this.biologicalAgentsUsedCheckBox.UseVisualStyleBackColor = true;
            this.biologicalAgentsUsedCheckBox.CheckedChanged += new System.EventHandler(this.biologicalAgentsUsedCheckBox_CheckedChanged);
            // 
            // manipulatedAgentsLabel
            // 
            this.manipulatedAgentsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manipulatedAgentsLabel.AutoSize = true;
            this.manipulatedAgentsLabel.Location = new System.Drawing.Point(35, 67);
            this.manipulatedAgentsLabel.Name = "manipulatedAgentsLabel";
            this.manipulatedAgentsLabel.Size = new System.Drawing.Size(92, 13);
            this.manipulatedAgentsLabel.TabIndex = 2;
            this.manipulatedAgentsLabel.Text = "Agentes utilizados";
            this.manipulatedAgentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labNameTextBox
            // 
            this.labNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.generalInfotableLayoutPanel.SetColumnSpan(this.labNameTextBox, 2);
            this.labNameTextBox.Location = new System.Drawing.Point(166, 33);
            this.labNameTextBox.Name = "labNameTextBox";
            this.labNameTextBox.Size = new System.Drawing.Size(415, 20);
            this.labNameTextBox.TabIndex = 6;
            this.labNameTextBox.TextChanged += new System.EventHandler(this.labNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Qual é o nome do seu espaço?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 159);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::RyskTech.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(177, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(224, 142);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.36096F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.68739F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.95164F));
            this.mainTableLayoutPanel.Controls.Add(this.logoPictureBox, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.groupBox1, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.label3, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.dateTimePicker2, 1, 4);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 5;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.83118F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.17457F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.86512F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.0094F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.11973F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayoutPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(189, 433);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // LabWelcomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "LabWelcomeControl";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.LabWelcomeControlBetter_Load);
            this.groupBox1.ResumeLayout(false);
            this.generalInfotableLayoutPanel.ResumeLayout(false);
            this.generalInfotableLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel generalInfotableLayoutPanel;
        private System.Windows.Forms.TextBox unitNameTextBox;
        private System.Windows.Forms.Label unitNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox physicalAgentsUsedCheckBox;
        private System.Windows.Forms.CheckBox chemicalAgentsUsedCheckBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox biologicalAgentsUsedCheckBox;
        private System.Windows.Forms.Label manipulatedAgentsLabel;
        private System.Windows.Forms.TextBox labNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
    }
}
