
namespace RyskTech.Forms.Lab.Controls
{
    partial class MechanicalAgentControl
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
            this.mechanicalAgentsDataGridView = new System.Windows.Forms.DataGridView();
            this.agentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editMechanicalAgentButton = new System.Windows.Forms.Button();
            this.removeAgentButton = new System.Windows.Forms.Button();
            this.addAgentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicalAgentsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Controls.Add(this.mechanicalAgentsDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.24786F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.85471F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.89744F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // mechanicalAgentsDataGridView
            // 
            this.mechanicalAgentsDataGridView.AllowUserToAddRows = false;
            this.mechanicalAgentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mechanicalAgentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mechanicalAgentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mechanicalAgentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mechanicalAgentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentName,
            this.riks,
            this.additionalInfo});
            this.mechanicalAgentsDataGridView.Location = new System.Drawing.Point(5, 66);
            this.mechanicalAgentsDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.mechanicalAgentsDataGridView.Name = "mechanicalAgentsDataGridView";
            this.mechanicalAgentsDataGridView.Size = new System.Drawing.Size(586, 344);
            this.mechanicalAgentsDataGridView.TabIndex = 2;
            // 
            // agentName
            // 
            this.agentName.HeaderText = "Agente";
            this.agentName.Name = "agentName";
            // 
            // riks
            // 
            this.riks.HeaderText = "Risco";
            this.riks.Name = "riks";
            // 
            // additionalInfo
            // 
            this.additionalInfo.HeaderText = "Informações Adicionais";
            this.additionalInfo.Name = "additionalInfo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editMechanicalAgentButton);
            this.panel1.Controls.Add(this.removeAgentButton);
            this.panel1.Controls.Add(this.addAgentButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 46);
            this.panel1.TabIndex = 3;
            // 
            // editMechanicalAgentButton
            // 
            this.editMechanicalAgentButton.Location = new System.Drawing.Point(93, 11);
            this.editMechanicalAgentButton.Name = "editMechanicalAgentButton";
            this.editMechanicalAgentButton.Size = new System.Drawing.Size(75, 23);
            this.editMechanicalAgentButton.TabIndex = 2;
            this.editMechanicalAgentButton.Text = "Editar";
            this.editMechanicalAgentButton.UseVisualStyleBackColor = true;
            this.editMechanicalAgentButton.Click += new System.EventHandler(this.editMechanicalAgentButton_Click);
            // 
            // removeAgentButton
            // 
            this.removeAgentButton.Location = new System.Drawing.Point(174, 11);
            this.removeAgentButton.Name = "removeAgentButton";
            this.removeAgentButton.Size = new System.Drawing.Size(75, 23);
            this.removeAgentButton.TabIndex = 1;
            this.removeAgentButton.Text = "Remover";
            this.removeAgentButton.UseVisualStyleBackColor = true;
            this.removeAgentButton.Click += new System.EventHandler(this.removeAgentButton_Click);
            // 
            // addAgentButton
            // 
            this.addAgentButton.Location = new System.Drawing.Point(12, 11);
            this.addAgentButton.Name = "addAgentButton";
            this.addAgentButton.Size = new System.Drawing.Size(75, 23);
            this.addAgentButton.TabIndex = 0;
            this.addAgentButton.Text = "Adicionar";
            this.addAgentButton.UseVisualStyleBackColor = true;
            this.addAgentButton.Click += new System.EventHandler(this.addAgentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preencha a tabela abaixo com os agentes mecânicos e riscos associados no seu espa" +
    "ço";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MechanicalAgentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "MechanicalAgentControl";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.MechanicalAgentControlBetter_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicalAgentsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView mechanicalAgentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn riks;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeAgentButton;
        private System.Windows.Forms.Button addAgentButton;
        private System.Windows.Forms.Button editMechanicalAgentButton;
    }
}
