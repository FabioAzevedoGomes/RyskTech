
namespace RyskTech.Forms.Lab
{
    partial class LabMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabMainForm));
            this.activePanelLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.navigationLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.conclusionTabButton = new System.Windows.Forms.Button();
            this.welcomeTabButton = new System.Windows.Forms.Button();
            this.generalInfoTabButton = new System.Windows.Forms.Button();
            this.safetyTabButton = new System.Windows.Forms.Button();
            this.chemicalAgentsTabButton = new System.Windows.Forms.Button();
            this.biologicalAgentTabButton = new System.Windows.Forms.Button();
            this.physicalAgentTabButton = new System.Windows.Forms.Button();
            this.mechanicalAgentsTabButton = new System.Windows.Forms.Button();
            this.risksTabButton = new System.Windows.Forms.Button();
            this.activeControlPanel = new System.Windows.Forms.Panel();
            this.bottomBarPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.nextConcludeButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.navigationLayoutPanel.SuspendLayout();
            this.bottomBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // activePanelLabel
            // 
            this.activePanelLabel.AutoSize = true;
            this.activePanelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activePanelLabel.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activePanelLabel.Location = new System.Drawing.Point(83, 0);
            this.activePanelLabel.Name = "activePanelLabel";
            this.activePanelLabel.Size = new System.Drawing.Size(594, 52);
            this.activePanelLabel.TabIndex = 2;
            this.activePanelLabel.Text = "Bem Vindo!";
            this.activePanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.navigationLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.activeControlPanel, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.activePanelLabel, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.bottomBarPanel, 1, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(680, 557);
            this.mainTableLayoutPanel.TabIndex = 1;
            // 
            // navigationLayoutPanel
            // 
            this.navigationLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.navigationLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.navigationLayoutPanel.ColumnCount = 1;
            this.navigationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navigationLayoutPanel.Controls.Add(this.conclusionTabButton, 0, 8);
            this.navigationLayoutPanel.Controls.Add(this.welcomeTabButton, 0, 0);
            this.navigationLayoutPanel.Controls.Add(this.generalInfoTabButton, 0, 1);
            this.navigationLayoutPanel.Controls.Add(this.safetyTabButton, 0, 2);
            this.navigationLayoutPanel.Controls.Add(this.chemicalAgentsTabButton, 0, 3);
            this.navigationLayoutPanel.Controls.Add(this.biologicalAgentTabButton, 0, 4);
            this.navigationLayoutPanel.Controls.Add(this.physicalAgentTabButton, 0, 5);
            this.navigationLayoutPanel.Controls.Add(this.mechanicalAgentsTabButton, 0, 6);
            this.navigationLayoutPanel.Controls.Add(this.risksTabButton, 0, 7);
            this.navigationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.navigationLayoutPanel.Name = "navigationLayoutPanel";
            this.navigationLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.navigationLayoutPanel.RowCount = 9;
            this.mainTableLayoutPanel.SetRowSpan(this.navigationLayoutPanel, 3);
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.navigationLayoutPanel.Size = new System.Drawing.Size(74, 551);
            this.navigationLayoutPanel.TabIndex = 1;
            // 
            // conclusionTabButton
            // 
            this.conclusionTabButton.BackColor = System.Drawing.Color.LightGray;
            this.conclusionTabButton.BackgroundImage = global::RyskTech.Properties.Resources.conclusion;
            this.conclusionTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.conclusionTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conclusionTabButton.FlatAppearance.BorderSize = 0;
            this.conclusionTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conclusionTabButton.Location = new System.Drawing.Point(8, 488);
            this.conclusionTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.conclusionTabButton.Name = "conclusionTabButton";
            this.conclusionTabButton.Size = new System.Drawing.Size(58, 55);
            this.conclusionTabButton.TabIndex = 14;
            this.conclusionTabButton.UseVisualStyleBackColor = false;
            this.conclusionTabButton.Click += new System.EventHandler(this.conclusionTabButton_Click);
            // 
            // welcomeTabButton
            // 
            this.welcomeTabButton.BackColor = System.Drawing.Color.LightGray;
            this.welcomeTabButton.BackgroundImage = global::RyskTech.Properties.Resources.home;
            this.welcomeTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.welcomeTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeTabButton.FlatAppearance.BorderSize = 0;
            this.welcomeTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomeTabButton.Location = new System.Drawing.Point(8, 8);
            this.welcomeTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.welcomeTabButton.Name = "welcomeTabButton";
            this.welcomeTabButton.Size = new System.Drawing.Size(58, 55);
            this.welcomeTabButton.TabIndex = 6;
            this.welcomeTabButton.UseVisualStyleBackColor = false;
            this.welcomeTabButton.Click += new System.EventHandler(this.welcomeTabButton_Click);
            // 
            // generalInfoTabButton
            // 
            this.generalInfoTabButton.BackColor = System.Drawing.Color.LightGray;
            this.generalInfoTabButton.BackgroundImage = global::RyskTech.Properties.Resources.information;
            this.generalInfoTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.generalInfoTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalInfoTabButton.FlatAppearance.BorderSize = 0;
            this.generalInfoTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalInfoTabButton.Location = new System.Drawing.Point(8, 68);
            this.generalInfoTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.generalInfoTabButton.Name = "generalInfoTabButton";
            this.generalInfoTabButton.Size = new System.Drawing.Size(58, 55);
            this.generalInfoTabButton.TabIndex = 7;
            this.generalInfoTabButton.UseVisualStyleBackColor = false;
            this.generalInfoTabButton.Click += new System.EventHandler(this.generalInfoTabButton_Click);
            // 
            // safetyTabButton
            // 
            this.safetyTabButton.BackColor = System.Drawing.Color.LightGray;
            this.safetyTabButton.BackgroundImage = global::RyskTech.Properties.Resources.safety;
            this.safetyTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.safetyTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.safetyTabButton.FlatAppearance.BorderSize = 0;
            this.safetyTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.safetyTabButton.Location = new System.Drawing.Point(8, 128);
            this.safetyTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.safetyTabButton.Name = "safetyTabButton";
            this.safetyTabButton.Size = new System.Drawing.Size(58, 55);
            this.safetyTabButton.TabIndex = 8;
            this.safetyTabButton.UseVisualStyleBackColor = false;
            this.safetyTabButton.Click += new System.EventHandler(this.safetyTabButton_Click);
            // 
            // chemicalAgentsTabButton
            // 
            this.chemicalAgentsTabButton.BackColor = System.Drawing.Color.LightGray;
            this.chemicalAgentsTabButton.BackgroundImage = global::RyskTech.Properties.Resources.chemical;
            this.chemicalAgentsTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chemicalAgentsTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chemicalAgentsTabButton.FlatAppearance.BorderSize = 0;
            this.chemicalAgentsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chemicalAgentsTabButton.Location = new System.Drawing.Point(8, 188);
            this.chemicalAgentsTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.chemicalAgentsTabButton.Name = "chemicalAgentsTabButton";
            this.chemicalAgentsTabButton.Size = new System.Drawing.Size(58, 55);
            this.chemicalAgentsTabButton.TabIndex = 9;
            this.chemicalAgentsTabButton.UseVisualStyleBackColor = false;
            this.chemicalAgentsTabButton.Click += new System.EventHandler(this.chemicalAgentsTabButton_Click);
            // 
            // biologicalAgentTabButton
            // 
            this.biologicalAgentTabButton.BackColor = System.Drawing.Color.LightGray;
            this.biologicalAgentTabButton.BackgroundImage = global::RyskTech.Properties.Resources.biological;
            this.biologicalAgentTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.biologicalAgentTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biologicalAgentTabButton.FlatAppearance.BorderSize = 0;
            this.biologicalAgentTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.biologicalAgentTabButton.Location = new System.Drawing.Point(8, 248);
            this.biologicalAgentTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.biologicalAgentTabButton.Name = "biologicalAgentTabButton";
            this.biologicalAgentTabButton.Size = new System.Drawing.Size(58, 55);
            this.biologicalAgentTabButton.TabIndex = 10;
            this.biologicalAgentTabButton.UseVisualStyleBackColor = false;
            this.biologicalAgentTabButton.Click += new System.EventHandler(this.biologicalAgentTabButton_Click);
            // 
            // physicalAgentTabButton
            // 
            this.physicalAgentTabButton.BackColor = System.Drawing.Color.LightGray;
            this.physicalAgentTabButton.BackgroundImage = global::RyskTech.Properties.Resources.physical;
            this.physicalAgentTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.physicalAgentTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.physicalAgentTabButton.FlatAppearance.BorderSize = 0;
            this.physicalAgentTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.physicalAgentTabButton.Location = new System.Drawing.Point(8, 308);
            this.physicalAgentTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.physicalAgentTabButton.Name = "physicalAgentTabButton";
            this.physicalAgentTabButton.Size = new System.Drawing.Size(58, 55);
            this.physicalAgentTabButton.TabIndex = 11;
            this.physicalAgentTabButton.UseVisualStyleBackColor = false;
            this.physicalAgentTabButton.Click += new System.EventHandler(this.physicalAgentTabButton_Click);
            // 
            // mechanicalAgentsTabButton
            // 
            this.mechanicalAgentsTabButton.BackColor = System.Drawing.Color.LightGray;
            this.mechanicalAgentsTabButton.BackgroundImage = global::RyskTech.Properties.Resources.mechanical;
            this.mechanicalAgentsTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mechanicalAgentsTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mechanicalAgentsTabButton.FlatAppearance.BorderSize = 0;
            this.mechanicalAgentsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mechanicalAgentsTabButton.Location = new System.Drawing.Point(8, 368);
            this.mechanicalAgentsTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.mechanicalAgentsTabButton.Name = "mechanicalAgentsTabButton";
            this.mechanicalAgentsTabButton.Size = new System.Drawing.Size(58, 55);
            this.mechanicalAgentsTabButton.TabIndex = 12;
            this.mechanicalAgentsTabButton.UseVisualStyleBackColor = false;
            this.mechanicalAgentsTabButton.Click += new System.EventHandler(this.mechanicalAgentsTabButton_Click);
            // 
            // risksTabButton
            // 
            this.risksTabButton.BackColor = System.Drawing.Color.LightGray;
            this.risksTabButton.BackgroundImage = global::RyskTech.Properties.Resources.risk;
            this.risksTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.risksTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.risksTabButton.FlatAppearance.BorderSize = 0;
            this.risksTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.risksTabButton.Location = new System.Drawing.Point(8, 428);
            this.risksTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.risksTabButton.Name = "risksTabButton";
            this.risksTabButton.Size = new System.Drawing.Size(58, 55);
            this.risksTabButton.TabIndex = 13;
            this.risksTabButton.UseVisualStyleBackColor = false;
            this.risksTabButton.Click += new System.EventHandler(this.risksTabButton_Click);
            // 
            // activeControlPanel
            // 
            this.activeControlPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activeControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeControlPanel.Location = new System.Drawing.Point(83, 55);
            this.activeControlPanel.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.activeControlPanel.Name = "activeControlPanel";
            this.activeControlPanel.Padding = new System.Windows.Forms.Padding(5);
            this.activeControlPanel.Size = new System.Drawing.Size(592, 463);
            this.activeControlPanel.TabIndex = 0;
            this.activeControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.activeControlPanel_Paint);
            // 
            // bottomBarPanel
            // 
            this.bottomBarPanel.Controls.Add(this.saveButton);
            this.bottomBarPanel.Controls.Add(this.nextConcludeButton);
            this.bottomBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomBarPanel.Location = new System.Drawing.Point(83, 524);
            this.bottomBarPanel.Name = "bottomBarPanel";
            this.bottomBarPanel.Size = new System.Drawing.Size(594, 30);
            this.bottomBarPanel.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(5, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Salvar Progresso";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nextConcludeButton
            // 
            this.nextConcludeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextConcludeButton.Location = new System.Drawing.Point(502, 4);
            this.nextConcludeButton.Name = "nextConcludeButton";
            this.nextConcludeButton.Size = new System.Drawing.Size(83, 23);
            this.nextConcludeButton.TabIndex = 4;
            this.nextConcludeButton.Text = "Próximo";
            this.nextConcludeButton.UseVisualStyleBackColor = true;
            this.nextConcludeButton.Click += new System.EventHandler(this.nextConcludeButton_Click);
            // 
            // LabMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1800, 800);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "LabMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RyskTech - Laboratório";
            this.Load += new System.EventHandler(this.LabMainFormBetter_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.navigationLayoutPanel.ResumeLayout(false);
            this.bottomBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label activePanelLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel navigationLayoutPanel;
        private System.Windows.Forms.Button welcomeTabButton;
        private System.Windows.Forms.Panel activeControlPanel;
        private System.Windows.Forms.Panel bottomBarPanel;
        private System.Windows.Forms.Button nextConcludeButton;
        private System.Windows.Forms.Button generalInfoTabButton;
        private System.Windows.Forms.Button safetyTabButton;
        private System.Windows.Forms.Button chemicalAgentsTabButton;
        private System.Windows.Forms.Button biologicalAgentTabButton;
        private System.Windows.Forms.Button physicalAgentTabButton;
        private System.Windows.Forms.Button mechanicalAgentsTabButton;
        private System.Windows.Forms.Button risksTabButton;
        private System.Windows.Forms.Button conclusionTabButton;
        private System.Windows.Forms.Button saveButton;
    }
}