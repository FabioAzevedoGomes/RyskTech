
namespace RyskTech.Forms.Unit.Controls
{
    partial class MethodologyControl
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.MethodologyTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showTable4Button = new System.Windows.Forms.Button();
            this.showTable3Button = new System.Windows.Forms.Button();
            this.showTable2Button = new System.Windows.Forms.Button();
            this.showTable1Button = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.32215F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.67785F));
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.MethodologyTextBox, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.98929F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.73233F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.49251F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altere a metodologia abaixo de acordo com a metodologia de análise utilizada na s" +
    "ua unidade. Pressione os botões abaixo para visualizar os quadros aos quais o te" +
    "xto se refere.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MethodologyTextBox
            // 
            this.MethodologyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTableLayoutPanel.SetColumnSpan(this.MethodologyTextBox, 2);
            this.MethodologyTextBox.Location = new System.Drawing.Point(5, 74);
            this.MethodologyTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MethodologyTextBox.Multiline = true;
            this.MethodologyTextBox.Name = "MethodologyTextBox";
            this.MethodologyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MethodologyTextBox.Size = new System.Drawing.Size(586, 338);
            this.MethodologyTextBox.TabIndex = 1;
            this.MethodologyTextBox.TextChanged += new System.EventHandler(this.MethodologyTextBox_TextChanged);
            // 
            // panel1
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.showTable4Button);
            this.panel1.Controls.Add(this.showTable3Button);
            this.panel1.Controls.Add(this.showTable2Button);
            this.panel1.Controls.Add(this.showTable1Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 44);
            this.panel1.TabIndex = 2;
            // 
            // showTable4Button
            // 
            this.showTable4Button.Location = new System.Drawing.Point(504, 11);
            this.showTable4Button.Name = "showTable4Button";
            this.showTable4Button.Size = new System.Drawing.Size(75, 23);
            this.showTable4Button.TabIndex = 3;
            this.showTable4Button.Text = "Quadro 4";
            this.showTable4Button.UseVisualStyleBackColor = true;
            this.showTable4Button.Click += new System.EventHandler(this.showTable4Button_Click);
            // 
            // showTable3Button
            // 
            this.showTable3Button.Location = new System.Drawing.Point(423, 11);
            this.showTable3Button.Name = "showTable3Button";
            this.showTable3Button.Size = new System.Drawing.Size(75, 23);
            this.showTable3Button.TabIndex = 2;
            this.showTable3Button.Text = "Quadro 3";
            this.showTable3Button.UseVisualStyleBackColor = true;
            this.showTable3Button.Click += new System.EventHandler(this.showTable3Button_Click);
            // 
            // showTable2Button
            // 
            this.showTable2Button.Location = new System.Drawing.Point(342, 11);
            this.showTable2Button.Name = "showTable2Button";
            this.showTable2Button.Size = new System.Drawing.Size(75, 23);
            this.showTable2Button.TabIndex = 1;
            this.showTable2Button.Text = "Quadro 2";
            this.showTable2Button.UseVisualStyleBackColor = true;
            this.showTable2Button.Click += new System.EventHandler(this.showTable2Button_Click);
            // 
            // showTable1Button
            // 
            this.showTable1Button.Location = new System.Drawing.Point(261, 11);
            this.showTable1Button.Name = "showTable1Button";
            this.showTable1Button.Size = new System.Drawing.Size(75, 23);
            this.showTable1Button.TabIndex = 0;
            this.showTable1Button.Text = "Quadro 1";
            this.showTable1Button.UseVisualStyleBackColor = true;
            this.showTable1Button.Click += new System.EventHandler(this.showTable1Button_Click);
            // 
            // MethodologyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "MethodologyControl";
            this.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MethodologyTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showTable4Button;
        private System.Windows.Forms.Button showTable3Button;
        private System.Windows.Forms.Button showTable2Button;
        private System.Windows.Forms.Button showTable1Button;
    }
}
