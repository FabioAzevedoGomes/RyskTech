
namespace RyskTech.Forms.Lab.Controls
{
    partial class RiskAnalysisControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.editRIskButton = new System.Windows.Forms.Button();
            this.removeRiskButton = new System.Windows.Forms.Button();
            this.addRiskButton = new System.Windows.Forms.Button();
            this.riskDataGridView = new System.Windows.Forms.DataGridView();
            this.danger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.risk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safetyNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.severity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTableLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riskDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.panel2, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.99144F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.58672F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Na tabela a seguir, insira as informações sobre possíveis riscos, seus perigos as" +
    "sociados e salvaguardas existentes para possível prevenção. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editRIskButton);
            this.panel2.Controls.Add(this.removeRiskButton);
            this.panel2.Controls.Add(this.addRiskButton);
            this.panel2.Controls.Add(this.riskDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 400);
            this.panel2.TabIndex = 5;
            // 
            // editRIskButton
            // 
            this.editRIskButton.Location = new System.Drawing.Point(90, 354);
            this.editRIskButton.Name = "editRIskButton";
            this.editRIskButton.Size = new System.Drawing.Size(75, 23);
            this.editRIskButton.TabIndex = 5;
            this.editRIskButton.Text = "Editar";
            this.editRIskButton.UseVisualStyleBackColor = true;
            this.editRIskButton.Click += new System.EventHandler(this.editRIskButton_Click);
            // 
            // removeRiskButton
            // 
            this.removeRiskButton.Location = new System.Drawing.Point(171, 354);
            this.removeRiskButton.Name = "removeRiskButton";
            this.removeRiskButton.Size = new System.Drawing.Size(75, 23);
            this.removeRiskButton.TabIndex = 4;
            this.removeRiskButton.Text = "Remover";
            this.removeRiskButton.UseVisualStyleBackColor = true;
            this.removeRiskButton.Click += new System.EventHandler(this.removeRiskButton_Click);
            // 
            // addRiskButton
            // 
            this.addRiskButton.Location = new System.Drawing.Point(9, 354);
            this.addRiskButton.Name = "addRiskButton";
            this.addRiskButton.Size = new System.Drawing.Size(75, 23);
            this.addRiskButton.TabIndex = 3;
            this.addRiskButton.Text = "Adicionar";
            this.addRiskButton.UseVisualStyleBackColor = true;
            this.addRiskButton.Click += new System.EventHandler(this.addRiskButton_Click);
            // 
            // riskDataGridView
            // 
            this.riskDataGridView.AllowUserToAddRows = false;
            this.riskDataGridView.AllowUserToDeleteRows = false;
            this.riskDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.riskDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.riskDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.riskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.riskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.danger,
            this.risk,
            this.safetyNet,
            this.frequency,
            this.severity,
            this.Column1});
            this.riskDataGridView.Location = new System.Drawing.Point(3, 3);
            this.riskDataGridView.Name = "riskDataGridView";
            this.riskDataGridView.ReadOnly = true;
            this.riskDataGridView.Size = new System.Drawing.Size(574, 345);
            this.riskDataGridView.TabIndex = 2;
            // 
            // danger
            // 
            this.danger.HeaderText = "Perigo";
            this.danger.Name = "danger";
            this.danger.ReadOnly = true;
            // 
            // risk
            // 
            this.risk.HeaderText = "Risco";
            this.risk.Name = "risk";
            this.risk.ReadOnly = true;
            this.risk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // safetyNet
            // 
            this.safetyNet.HeaderText = "Salvaguarda";
            this.safetyNet.Name = "safetyNet";
            this.safetyNet.ReadOnly = true;
            // 
            // frequency
            // 
            this.frequency.HeaderText = "Frequência";
            this.frequency.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.frequency.Name = "frequency";
            this.frequency.ReadOnly = true;
            this.frequency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.frequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // severity
            // 
            this.severity.HeaderText = "Severidade";
            this.severity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.severity.Name = "severity";
            this.severity.ReadOnly = true;
            this.severity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.severity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Classificação";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // RiskAnalysisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "RiskAnalysisControl";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.RiskAnalysisControlBetter_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.riskDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView riskDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeRiskButton;
        private System.Windows.Forms.Button addRiskButton;
        private System.Windows.Forms.Button editRIskButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn danger;
        private System.Windows.Forms.DataGridViewTextBoxColumn risk;
        private System.Windows.Forms.DataGridViewTextBoxColumn safetyNet;
        private System.Windows.Forms.DataGridViewComboBoxColumn frequency;
        private System.Windows.Forms.DataGridViewComboBoxColumn severity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
