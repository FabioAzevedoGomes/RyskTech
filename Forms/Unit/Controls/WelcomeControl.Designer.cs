
namespace RyskTech.Forms.Unit.Controls
{
    partial class WelcomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeControl));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generalInfotableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.unitNameLabel = new System.Windows.Forms.Label();
            this.unitNameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.generalInfotableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.75433F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.00692F));
            this.mainTableLayoutPanel.Controls.Add(this.logoPictureBox, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.groupBox1, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.97216F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.11777F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.49036F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07207F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::RyskTech.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(177, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(224, 176);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 164);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.generalInfotableLayoutPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 349);
            this.groupBox1.Name = "groupBox1";
            this.mainTableLayoutPanel.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(590, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Gerais";
            // 
            // generalInfotableLayoutPanel
            // 
            this.generalInfotableLayoutPanel.ColumnCount = 3;
            this.generalInfotableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.91519F));
            this.generalInfotableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.5159F));
            this.generalInfotableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.generalInfotableLayoutPanel.Controls.Add(this.unitNameLabel, 0, 0);
            this.generalInfotableLayoutPanel.Controls.Add(this.unitNameTextBox, 1, 0);
            this.generalInfotableLayoutPanel.Controls.Add(this.dateTimePicker1, 1, 1);
            this.generalInfotableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.generalInfotableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalInfotableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.generalInfotableLayoutPanel.Name = "generalInfotableLayoutPanel";
            this.generalInfotableLayoutPanel.RowCount = 2;
            this.generalInfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalInfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalInfotableLayoutPanel.Size = new System.Drawing.Size(584, 96);
            this.generalInfotableLayoutPanel.TabIndex = 0;
            // 
            // unitNameLabel
            // 
            this.unitNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.unitNameLabel.AutoSize = true;
            this.unitNameLabel.Location = new System.Drawing.Point(3, 17);
            this.unitNameLabel.Name = "unitNameLabel";
            this.unitNameLabel.Size = new System.Drawing.Size(149, 13);
            this.unitNameLabel.TabIndex = 0;
            this.unitNameLabel.Text = "Qual o nome da sua unidade?";
            this.unitNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitNameTextBox
            // 
            this.unitNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.generalInfotableLayoutPanel.SetColumnSpan(this.unitNameTextBox, 2);
            this.unitNameTextBox.Location = new System.Drawing.Point(166, 14);
            this.unitNameTextBox.Name = "unitNameTextBox";
            this.unitNameTextBox.Size = new System.Drawing.Size(415, 20);
            this.unitNameTextBox.TabIndex = 1;
            this.unitNameTextBox.TextChanged += new System.EventHandler(this.unitNameTextBox_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data";
            // 
            // WelcomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "WelcomeControl";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.TestWelcomeControl_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.generalInfotableLayoutPanel.ResumeLayout(false);
            this.generalInfotableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel generalInfotableLayoutPanel;
        private System.Windows.Forms.Label unitNameLabel;
        private System.Windows.Forms.TextBox unitNameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}
