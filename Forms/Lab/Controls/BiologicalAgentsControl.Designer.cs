
namespace RyskTech.Forms.Lab.Controls
{
    partial class BiologicalAgentsControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bioResidueDestinationTextBox = new System.Windows.Forms.TextBox();
            this.bioStorageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sisgenRegistryNumberTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ogmNoRadioButton = new System.Windows.Forms.RadioButton();
            this.ogmYesRadioButton = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.certificateNoRadioButton = new System.Windows.Forms.RadioButton();
            this.certificateYesRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeSampleButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.newProcessedSampleTextBox = new System.Windows.Forms.TextBox();
            this.addSampleButton = new System.Windows.Forms.Button();
            this.processedSamplesListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editBioAgentButotn = new System.Windows.Forms.Button();
            this.removeBioResidueButton = new System.Windows.Forms.Button();
            this.addBiologicalResidueButton = new System.Windows.Forms.Button();
            this.bioAgentData = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riskClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bioAgentData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 467);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.bioResidueDestinationTextBox);
            this.groupBox4.Controls.Add(this.bioStorageTextBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 165);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Armazenamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Qual é o destino dos resíduos biológicos gerados?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Como é feito o armazenamento de resíduos biológicos?";
            // 
            // bioResidueDestinationTextBox
            // 
            this.bioResidueDestinationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bioResidueDestinationTextBox.Location = new System.Drawing.Point(13, 110);
            this.bioResidueDestinationTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.bioResidueDestinationTextBox.Multiline = true;
            this.bioResidueDestinationTextBox.Name = "bioResidueDestinationTextBox";
            this.bioResidueDestinationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bioResidueDestinationTextBox.Size = new System.Drawing.Size(326, 42);
            this.bioResidueDestinationTextBox.TabIndex = 4;
            this.bioResidueDestinationTextBox.TextChanged += new System.EventHandler(this.bioResidueDestinationTextBox_TextChanged);
            // 
            // bioStorageTextBox
            // 
            this.bioStorageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bioStorageTextBox.Location = new System.Drawing.Point(13, 41);
            this.bioStorageTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.bioStorageTextBox.Multiline = true;
            this.bioStorageTextBox.Name = "bioStorageTextBox";
            this.bioStorageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bioStorageTextBox.Size = new System.Drawing.Size(326, 40);
            this.bioStorageTextBox.TabIndex = 3;
            this.bioStorageTextBox.TextChanged += new System.EventHandler(this.bioStorageTextBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.sisgenRegistryNumberTextBox);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(367, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 181);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Certificação";
            // 
            // sisgenRegistryNumberTextBox
            // 
            this.sisgenRegistryNumberTextBox.Enabled = false;
            this.sisgenRegistryNumberTextBox.Location = new System.Drawing.Point(10, 86);
            this.sisgenRegistryNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.sisgenRegistryNumberTextBox.Name = "sisgenRegistryNumberTextBox";
            this.sisgenRegistryNumberTextBox.Size = new System.Drawing.Size(166, 20);
            this.sisgenRegistryNumberTextBox.TabIndex = 5;
            this.sisgenRegistryNumberTextBox.TextChanged += new System.EventHandler(this.sisgenRegistryNumberTextBox_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ogmNoRadioButton);
            this.panel4.Controls.Add(this.ogmYesRadioButton);
            this.panel4.Location = new System.Drawing.Point(10, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 34);
            this.panel4.TabIndex = 5;
            // 
            // ogmNoRadioButton
            // 
            this.ogmNoRadioButton.AutoSize = true;
            this.ogmNoRadioButton.Checked = true;
            this.ogmNoRadioButton.Location = new System.Drawing.Point(59, 9);
            this.ogmNoRadioButton.Name = "ogmNoRadioButton";
            this.ogmNoRadioButton.Size = new System.Drawing.Size(45, 17);
            this.ogmNoRadioButton.TabIndex = 2;
            this.ogmNoRadioButton.TabStop = true;
            this.ogmNoRadioButton.Text = "Não";
            this.ogmNoRadioButton.UseVisualStyleBackColor = true;
            this.ogmNoRadioButton.CheckedChanged += new System.EventHandler(this.ogmNoRadioButton_CheckedChanged);
            // 
            // ogmYesRadioButton
            // 
            this.ogmYesRadioButton.AutoSize = true;
            this.ogmYesRadioButton.Location = new System.Drawing.Point(10, 8);
            this.ogmYesRadioButton.Name = "ogmYesRadioButton";
            this.ogmYesRadioButton.Size = new System.Drawing.Size(42, 17);
            this.ogmYesRadioButton.TabIndex = 1;
            this.ogmYesRadioButton.Text = "Sim";
            this.ogmYesRadioButton.UseVisualStyleBackColor = true;
            this.ogmYesRadioButton.CheckedChanged += new System.EventHandler(this.ogmYesRadioButton_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.certificateNoRadioButton);
            this.panel3.Controls.Add(this.certificateYesRadioButton);
            this.panel3.Location = new System.Drawing.Point(9, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 34);
            this.panel3.TabIndex = 3;
            // 
            // certificateNoRadioButton
            // 
            this.certificateNoRadioButton.AutoSize = true;
            this.certificateNoRadioButton.Checked = true;
            this.certificateNoRadioButton.Location = new System.Drawing.Point(59, 8);
            this.certificateNoRadioButton.Name = "certificateNoRadioButton";
            this.certificateNoRadioButton.Size = new System.Drawing.Size(45, 17);
            this.certificateNoRadioButton.TabIndex = 2;
            this.certificateNoRadioButton.TabStop = true;
            this.certificateNoRadioButton.Text = "Não";
            this.certificateNoRadioButton.UseVisualStyleBackColor = true;
            this.certificateNoRadioButton.CheckedChanged += new System.EventHandler(this.certificateNoRadioButton_CheckedChanged);
            // 
            // certificateYesRadioButton
            // 
            this.certificateYesRadioButton.AutoSize = true;
            this.certificateYesRadioButton.Location = new System.Drawing.Point(10, 8);
            this.certificateYesRadioButton.Name = "certificateYesRadioButton";
            this.certificateYesRadioButton.Size = new System.Drawing.Size(42, 17);
            this.certificateYesRadioButton.TabIndex = 1;
            this.certificateYesRadioButton.Text = "Sim";
            this.certificateYesRadioButton.UseVisualStyleBackColor = true;
            this.certificateYesRadioButton.CheckedChanged += new System.EventHandler(this.certificateYesRadioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apresenta certificado em \r\nbiossegurança?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qual seu cadastro SISGEN?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabalha com OGMs?";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.removeSampleButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.newProcessedSampleTextBox);
            this.groupBox2.Controls.Add(this.addSampleButton);
            this.groupBox2.Controls.Add(this.processedSamplesListBox);
            this.groupBox2.Location = new System.Drawing.Point(367, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 262);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amostras";
            // 
            // removeSampleButton
            // 
            this.removeSampleButton.Location = new System.Drawing.Point(77, 228);
            this.removeSampleButton.Name = "removeSampleButton";
            this.removeSampleButton.Size = new System.Drawing.Size(64, 23);
            this.removeSampleButton.TabIndex = 9;
            this.removeSampleButton.Text = "Remover";
            this.removeSampleButton.UseVisualStyleBackColor = true;
            this.removeSampleButton.Click += new System.EventHandler(this.removeSampleButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Que tipos de amostras são processadas\r\nno local? (ex.: urina, tecido, etc.)";
            // 
            // newProcessedSampleTextBox
            // 
            this.newProcessedSampleTextBox.Location = new System.Drawing.Point(5, 197);
            this.newProcessedSampleTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.newProcessedSampleTextBox.Name = "newProcessedSampleTextBox";
            this.newProcessedSampleTextBox.Size = new System.Drawing.Size(166, 20);
            this.newProcessedSampleTextBox.TabIndex = 7;
            // 
            // addSampleButton
            // 
            this.addSampleButton.Location = new System.Drawing.Point(6, 228);
            this.addSampleButton.Margin = new System.Windows.Forms.Padding(8);
            this.addSampleButton.Name = "addSampleButton";
            this.addSampleButton.Size = new System.Drawing.Size(60, 23);
            this.addSampleButton.TabIndex = 6;
            this.addSampleButton.Text = "Adicionar";
            this.addSampleButton.UseVisualStyleBackColor = true;
            this.addSampleButton.Click += new System.EventHandler(this.addSampleButton_Click);
            // 
            // processedSamplesListBox
            // 
            this.processedSamplesListBox.FormattingEnabled = true;
            this.processedSamplesListBox.Location = new System.Drawing.Point(6, 53);
            this.processedSamplesListBox.Name = "processedSamplesListBox";
            this.processedSamplesListBox.Size = new System.Drawing.Size(165, 134);
            this.processedSamplesListBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 274);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agentes Biológicos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editBioAgentButotn);
            this.panel2.Controls.Add(this.removeBioResidueButton);
            this.panel2.Controls.Add(this.addBiologicalResidueButton);
            this.panel2.Controls.Add(this.bioAgentData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 255);
            this.panel2.TabIndex = 0;
            // 
            // editBioAgentButotn
            // 
            this.editBioAgentButotn.Location = new System.Drawing.Point(123, 221);
            this.editBioAgentButotn.Margin = new System.Windows.Forms.Padding(9);
            this.editBioAgentButotn.Name = "editBioAgentButotn";
            this.editBioAgentButotn.Size = new System.Drawing.Size(96, 25);
            this.editBioAgentButotn.TabIndex = 4;
            this.editBioAgentButotn.Text = "Editar";
            this.editBioAgentButotn.UseVisualStyleBackColor = true;
            this.editBioAgentButotn.Click += new System.EventHandler(this.editBioAgentButotn_Click);
            // 
            // removeBioResidueButton
            // 
            this.removeBioResidueButton.Location = new System.Drawing.Point(237, 221);
            this.removeBioResidueButton.Margin = new System.Windows.Forms.Padding(9);
            this.removeBioResidueButton.Name = "removeBioResidueButton";
            this.removeBioResidueButton.Size = new System.Drawing.Size(96, 25);
            this.removeBioResidueButton.TabIndex = 3;
            this.removeBioResidueButton.Text = "Remover";
            this.removeBioResidueButton.UseVisualStyleBackColor = true;
            this.removeBioResidueButton.Click += new System.EventHandler(this.removeBioResidueButton_Click);
            // 
            // addBiologicalResidueButton
            // 
            this.addBiologicalResidueButton.Location = new System.Drawing.Point(9, 221);
            this.addBiologicalResidueButton.Margin = new System.Windows.Forms.Padding(9);
            this.addBiologicalResidueButton.Name = "addBiologicalResidueButton";
            this.addBiologicalResidueButton.Size = new System.Drawing.Size(96, 25);
            this.addBiologicalResidueButton.TabIndex = 2;
            this.addBiologicalResidueButton.Text = "Adicionar";
            this.addBiologicalResidueButton.UseVisualStyleBackColor = true;
            this.addBiologicalResidueButton.Click += new System.EventHandler(this.addBiologicalResidueButton_Click);
            // 
            // bioAgentData
            // 
            this.bioAgentData.AllowUserToAddRows = false;
            this.bioAgentData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bioAgentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bioAgentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bioAgentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.riskClass,
            this.usage});
            this.bioAgentData.Location = new System.Drawing.Point(3, 3);
            this.bioAgentData.Name = "bioAgentData";
            this.bioAgentData.Size = new System.Drawing.Size(346, 213);
            this.bioAgentData.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "Nomenclatura Binomial";
            this.name.Name = "name";
            // 
            // riskClass
            // 
            this.riskClass.HeaderText = "Classe de Risco";
            this.riskClass.Name = "riskClass";
            this.riskClass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.riskClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // usage
            // 
            this.usage.HeaderText = "Uso do Material";
            this.usage.Name = "usage";
            this.usage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.usage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BiologicalAgentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BiologicalAgentsControl";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.BiologicalAgentsBetter_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bioAgentData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView bioAgentData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBiologicalResidueButton;
        private System.Windows.Forms.Button removeBioResidueButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox processedSamplesListBox;
        private System.Windows.Forms.Button addSampleButton;
        private System.Windows.Forms.TextBox newProcessedSampleTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox sisgenRegistryNumberTextBox;
        private System.Windows.Forms.RadioButton ogmYesRadioButton;
        private System.Windows.Forms.RadioButton ogmNoRadioButton;
        private System.Windows.Forms.RadioButton certificateYesRadioButton;
        private System.Windows.Forms.RadioButton certificateNoRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox bioStorageTextBox;
        private System.Windows.Forms.TextBox bioResidueDestinationTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn usage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button removeSampleButton;
        private System.Windows.Forms.Button editBioAgentButotn;
    }
}
