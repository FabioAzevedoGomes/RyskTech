
namespace RyskTech.Forms.Unit
{
    partial class UnitMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitMainForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.navigationLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.methodologyTabButton = new System.Windows.Forms.Button();
            this.historyTabButton = new System.Windows.Forms.Button();
            this.structureTabButton = new System.Windows.Forms.Button();
            this.teamTabButton = new System.Windows.Forms.Button();
            this.locationTabButton = new System.Windows.Forms.Button();
            this.welcomeTabButton = new System.Windows.Forms.Button();
            this.activeControlPanel = new System.Windows.Forms.Panel();
            this.activePanelLabel = new System.Windows.Forms.Label();
            this.bottomBarPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.nextConcludeButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.navigationLayoutPanel.SuspendLayout();
            this.bottomBarPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(684, 561);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // navigationLayoutPanel
            // 
            this.navigationLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.navigationLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.navigationLayoutPanel.ColumnCount = 1;
            this.navigationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.navigationLayoutPanel.Controls.Add(this.methodologyTabButton, 0, 5);
            this.navigationLayoutPanel.Controls.Add(this.historyTabButton, 0, 4);
            this.navigationLayoutPanel.Controls.Add(this.structureTabButton, 0, 3);
            this.navigationLayoutPanel.Controls.Add(this.teamTabButton, 0, 2);
            this.navigationLayoutPanel.Controls.Add(this.locationTabButton, 0, 1);
            this.navigationLayoutPanel.Controls.Add(this.welcomeTabButton, 0, 0);
            this.navigationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.navigationLayoutPanel.Name = "navigationLayoutPanel";
            this.navigationLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.navigationLayoutPanel.RowCount = 6;
            this.mainTableLayoutPanel.SetRowSpan(this.navigationLayoutPanel, 3);
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.navigationLayoutPanel.Size = new System.Drawing.Size(74, 555);
            this.navigationLayoutPanel.TabIndex = 1;
            // 
            // methodologyTabButton
            // 
            this.methodologyTabButton.BackColor = System.Drawing.Color.LightGray;
            this.methodologyTabButton.BackgroundImage = global::RyskTech.Properties.Resources.methodolody;
            this.methodologyTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.methodologyTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodologyTabButton.FlatAppearance.BorderSize = 0;
            this.methodologyTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.methodologyTabButton.Location = new System.Drawing.Point(8, 458);
            this.methodologyTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.methodologyTabButton.Name = "methodologyTabButton";
            this.methodologyTabButton.Size = new System.Drawing.Size(58, 89);
            this.methodologyTabButton.TabIndex = 11;
            this.methodologyTabButton.UseVisualStyleBackColor = false;
            this.methodologyTabButton.Click += new System.EventHandler(this.methodologyTabButton_Click);
            // 
            // historyTabButton
            // 
            this.historyTabButton.BackColor = System.Drawing.Color.LightGray;
            this.historyTabButton.BackgroundImage = global::RyskTech.Properties.Resources.history;
            this.historyTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.historyTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyTabButton.FlatAppearance.BorderSize = 0;
            this.historyTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyTabButton.Location = new System.Drawing.Point(8, 368);
            this.historyTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.historyTabButton.Name = "historyTabButton";
            this.historyTabButton.Size = new System.Drawing.Size(58, 85);
            this.historyTabButton.TabIndex = 10;
            this.historyTabButton.UseVisualStyleBackColor = false;
            this.historyTabButton.Click += new System.EventHandler(this.historyTabButton_Click);
            // 
            // structureTabButton
            // 
            this.structureTabButton.BackColor = System.Drawing.Color.LightGray;
            this.structureTabButton.BackgroundImage = global::RyskTech.Properties.Resources.structure;
            this.structureTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.structureTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.structureTabButton.FlatAppearance.BorderSize = 0;
            this.structureTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.structureTabButton.Location = new System.Drawing.Point(8, 278);
            this.structureTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.structureTabButton.Name = "structureTabButton";
            this.structureTabButton.Size = new System.Drawing.Size(58, 85);
            this.structureTabButton.TabIndex = 9;
            this.structureTabButton.UseVisualStyleBackColor = false;
            this.structureTabButton.Click += new System.EventHandler(this.structureTabButton_Click);
            // 
            // teamTabButton
            // 
            this.teamTabButton.BackColor = System.Drawing.Color.LightGray;
            this.teamTabButton.BackgroundImage = global::RyskTech.Properties.Resources.team;
            this.teamTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.teamTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamTabButton.FlatAppearance.BorderSize = 0;
            this.teamTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamTabButton.Location = new System.Drawing.Point(8, 188);
            this.teamTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.teamTabButton.Name = "teamTabButton";
            this.teamTabButton.Size = new System.Drawing.Size(58, 85);
            this.teamTabButton.TabIndex = 8;
            this.teamTabButton.UseVisualStyleBackColor = false;
            this.teamTabButton.Click += new System.EventHandler(this.teamTabButton_Click);
            // 
            // locationTabButton
            // 
            this.locationTabButton.BackColor = System.Drawing.Color.LightGray;
            this.locationTabButton.BackgroundImage = global::RyskTech.Properties.Resources.location;
            this.locationTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.locationTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationTabButton.FlatAppearance.BorderSize = 0;
            this.locationTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationTabButton.Location = new System.Drawing.Point(8, 98);
            this.locationTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.locationTabButton.Name = "locationTabButton";
            this.locationTabButton.Size = new System.Drawing.Size(58, 85);
            this.locationTabButton.TabIndex = 7;
            this.locationTabButton.UseVisualStyleBackColor = false;
            this.locationTabButton.Click += new System.EventHandler(this.locationTabButton_Click);
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
            this.welcomeTabButton.Size = new System.Drawing.Size(58, 85);
            this.welcomeTabButton.TabIndex = 6;
            this.welcomeTabButton.UseVisualStyleBackColor = false;
            this.welcomeTabButton.Click += new System.EventHandler(this.welcomeTabButton_Click);
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
            this.activeControlPanel.Size = new System.Drawing.Size(596, 467);
            this.activeControlPanel.TabIndex = 0;
            // 
            // activePanelLabel
            // 
            this.activePanelLabel.AutoSize = true;
            this.activePanelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activePanelLabel.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activePanelLabel.Location = new System.Drawing.Point(83, 0);
            this.activePanelLabel.Name = "activePanelLabel";
            this.activePanelLabel.Size = new System.Drawing.Size(598, 52);
            this.activePanelLabel.TabIndex = 2;
            this.activePanelLabel.Text = "Bem Vindo!";
            this.activePanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomBarPanel
            // 
            this.bottomBarPanel.Controls.Add(this.saveButton);
            this.bottomBarPanel.Controls.Add(this.nextConcludeButton);
            this.bottomBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomBarPanel.Location = new System.Drawing.Point(83, 528);
            this.bottomBarPanel.Name = "bottomBarPanel";
            this.bottomBarPanel.Size = new System.Drawing.Size(598, 30);
            this.bottomBarPanel.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(5, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Salvar Progresso";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nextConcludeButton
            // 
            this.nextConcludeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextConcludeButton.Location = new System.Drawing.Point(506, 4);
            this.nextConcludeButton.Name = "nextConcludeButton";
            this.nextConcludeButton.Size = new System.Drawing.Size(83, 23);
            this.nextConcludeButton.TabIndex = 4;
            this.nextConcludeButton.Text = "Próximo";
            this.nextConcludeButton.UseVisualStyleBackColor = true;
            this.nextConcludeButton.Click += new System.EventHandler(this.nextConcludeButton_Click);
            // 
            // UnitMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1800, 800);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "UnitMainForm";
            this.Text = "RyskTech - Unidade";
            this.Load += new System.EventHandler(this.UITestForm_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.navigationLayoutPanel.ResumeLayout(false);
            this.bottomBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel activeControlPanel;
        private System.Windows.Forms.TableLayoutPanel navigationLayoutPanel;
        private System.Windows.Forms.Button welcomeTabButton;
        private System.Windows.Forms.Button locationTabButton;
        private System.Windows.Forms.Button methodologyTabButton;
        private System.Windows.Forms.Button historyTabButton;
        private System.Windows.Forms.Button structureTabButton;
        private System.Windows.Forms.Button teamTabButton;
        private System.Windows.Forms.Label activePanelLabel;
        private System.Windows.Forms.Panel bottomBarPanel;
        private System.Windows.Forms.Button nextConcludeButton;
        private System.Windows.Forms.Button saveButton;
    }
}