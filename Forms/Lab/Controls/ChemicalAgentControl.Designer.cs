
namespace RyskTech.Forms.Lab.Controls
{
    partial class ChemicalAgentControl
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.hasFISPQRadioButton = new System.Windows.Forms.RadioButton();
            this.noFISPQRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.nbrLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.residuosCheckbox = new System.Windows.Forms.CheckBox();
            this.editResidueButton = new System.Windows.Forms.Button();
            this.editReactorButton = new System.Windows.Forms.Button();
            this.removeReactorButton = new System.Windows.Forms.Button();
            this.addReactorButton = new System.Windows.Forms.Button();
            this.removeResidueButton = new System.Windows.Forms.Button();
            this.addResidueButton = new System.Windows.Forms.Button();
            this.chemicalReactorData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casNumberTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueData = new System.Windows.Forms.DataGridView();
            this.chemicalResidueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResiduePhysicalState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueDangers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dangerCharacteristics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inertState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueStorageLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueContainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalReactorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalResidueData)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.textBox2);
            this.mainPanel.Controls.Add(this.tableLayoutPanel4);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.linkLabel1);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.nbrLinkLabel);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(596, 467);
            this.mainPanel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(391, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Qual o destino dos resíduos químicos? (especificar internamente e externamente)";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(21, 399);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(544, 56);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.hasFISPQRadioButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.noFISPQRadioButton, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 356);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(107, 22);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // hasFISPQRadioButton
            // 
            this.hasFISPQRadioButton.AutoSize = true;
            this.hasFISPQRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hasFISPQRadioButton.Location = new System.Drawing.Point(56, 3);
            this.hasFISPQRadioButton.Name = "hasFISPQRadioButton";
            this.hasFISPQRadioButton.Size = new System.Drawing.Size(48, 16);
            this.hasFISPQRadioButton.TabIndex = 1;
            this.hasFISPQRadioButton.Text = "Sim:";
            this.hasFISPQRadioButton.UseVisualStyleBackColor = true;
            this.hasFISPQRadioButton.CheckedChanged += new System.EventHandler(this.hasFISPQRadioButton_CheckedChanged);
            // 
            // noFISPQRadioButton
            // 
            this.noFISPQRadioButton.AutoSize = true;
            this.noFISPQRadioButton.Checked = true;
            this.noFISPQRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noFISPQRadioButton.Location = new System.Drawing.Point(3, 3);
            this.noFISPQRadioButton.Name = "noFISPQRadioButton";
            this.noFISPQRadioButton.Size = new System.Drawing.Size(47, 16);
            this.noFISPQRadioButton.TabIndex = 0;
            this.noFISPQRadioButton.TabStop = true;
            this.noFISPQRadioButton.Text = "Não";
            this.noFISPQRadioButton.UseVisualStyleBackColor = true;
            this.noFISPQRadioButton.CheckedChanged += new System.EventHandler(this.noFISPQRadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.yesRadioButton);
            this.panel1.Controls.Add(this.noRadioButton);
            this.panel1.Location = new System.Drawing.Point(21, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 26);
            this.panel1.TabIndex = 11;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(52, 6);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(42, 17);
            this.yesRadioButton.TabIndex = 3;
            this.yesRadioButton.Text = "Sim";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            this.yesRadioButton.CheckedChanged += new System.EventHandler(this.yesRadioButton_CheckedChanged);
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Checked = true;
            this.noRadioButton.Location = new System.Drawing.Point(1, 6);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(45, 17);
            this.noRadioButton.TabIndex = 2;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "Não";
            this.noRadioButton.UseVisualStyleBackColor = true;
            this.noRadioButton.CheckedChanged += new System.EventHandler(this.noRadioButton_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(374, 333);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "NBR-14725-4:2014 ?";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Os reagentes possuem rótulo com base na FISPQ, em concordância com a";
            // 
            // nbrLinkLabel
            // 
            this.nbrLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nbrLinkLabel.AutoSize = true;
            this.nbrLinkLabel.Location = new System.Drawing.Point(314, 288);
            this.nbrLinkLabel.Margin = new System.Windows.Forms.Padding(1);
            this.nbrLinkLabel.Name = "nbrLinkLabel";
            this.nbrLinkLabel.Size = new System.Drawing.Size(108, 13);
            this.nbrLinkLabel.TabIndex = 4;
            this.nbrLinkLabel.TabStop = true;
            this.nbrLinkLabel.Text = "NBR-14725-3:2017 ?";
            this.nbrLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbrLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nbrLinkLabel_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Os recipientes de reagentes químicos estão de acordo com a ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.residuosCheckbox);
            this.groupBox1.Controls.Add(this.editResidueButton);
            this.groupBox1.Controls.Add(this.editReactorButton);
            this.groupBox1.Controls.Add(this.removeReactorButton);
            this.groupBox1.Controls.Add(this.addReactorButton);
            this.groupBox1.Controls.Add(this.removeResidueButton);
            this.groupBox1.Controls.Add(this.addResidueButton);
            this.groupBox1.Controls.Add(this.chemicalReactorData);
            this.groupBox1.Controls.Add(this.chemicalResidueData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 278);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agentes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.Resize += new System.EventHandler(this.resized);
            // 
            // residuosCheckbox
            // 
            this.residuosCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.residuosCheckbox.AutoSize = true;
            this.residuosCheckbox.Location = new System.Drawing.Point(267, 253);
            this.residuosCheckbox.Name = "residuosCheckbox";
            this.residuosCheckbox.Size = new System.Drawing.Size(78, 17);
            this.residuosCheckbox.TabIndex = 9;
            this.residuosCheckbox.Text = "Resíduos?";
            this.residuosCheckbox.UseVisualStyleBackColor = true;
            this.residuosCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // editResidueButton
            // 
            this.editResidueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editResidueButton.Location = new System.Drawing.Point(430, 247);
            this.editResidueButton.Margin = new System.Windows.Forms.Padding(8);
            this.editResidueButton.Name = "editResidueButton";
            this.editResidueButton.Size = new System.Drawing.Size(68, 27);
            this.editResidueButton.TabIndex = 8;
            this.editResidueButton.Text = "Editar";
            this.editResidueButton.UseVisualStyleBackColor = true;
            this.editResidueButton.Visible = false;
            this.editResidueButton.Click += new System.EventHandler(this.editResidueButton_Click);
            // 
            // editReactorButton
            // 
            this.editReactorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editReactorButton.Location = new System.Drawing.Point(93, 246);
            this.editReactorButton.Margin = new System.Windows.Forms.Padding(8);
            this.editReactorButton.Name = "editReactorButton";
            this.editReactorButton.Size = new System.Drawing.Size(68, 27);
            this.editReactorButton.TabIndex = 7;
            this.editReactorButton.Text = "Editar";
            this.editReactorButton.UseVisualStyleBackColor = true;
            this.editReactorButton.Click += new System.EventHandler(this.editReactorButton_Click);
            // 
            // removeReactorButton
            // 
            this.removeReactorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeReactorButton.Location = new System.Drawing.Point(177, 246);
            this.removeReactorButton.Margin = new System.Windows.Forms.Padding(8);
            this.removeReactorButton.Name = "removeReactorButton";
            this.removeReactorButton.Size = new System.Drawing.Size(68, 27);
            this.removeReactorButton.TabIndex = 4;
            this.removeReactorButton.Text = "Remover";
            this.removeReactorButton.UseVisualStyleBackColor = true;
            this.removeReactorButton.Click += new System.EventHandler(this.removeReactorButton_Click);
            // 
            // addReactorButton
            // 
            this.addReactorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addReactorButton.Location = new System.Drawing.Point(9, 246);
            this.addReactorButton.Margin = new System.Windows.Forms.Padding(8);
            this.addReactorButton.Name = "addReactorButton";
            this.addReactorButton.Size = new System.Drawing.Size(68, 27);
            this.addReactorButton.TabIndex = 2;
            this.addReactorButton.Text = "Novo";
            this.addReactorButton.UseVisualStyleBackColor = true;
            this.addReactorButton.Click += new System.EventHandler(this.addReactorButton_Click);
            // 
            // removeResidueButton
            // 
            this.removeResidueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeResidueButton.Location = new System.Drawing.Point(498, 246);
            this.removeResidueButton.Margin = new System.Windows.Forms.Padding(8);
            this.removeResidueButton.Name = "removeResidueButton";
            this.removeResidueButton.Size = new System.Drawing.Size(68, 27);
            this.removeResidueButton.TabIndex = 6;
            this.removeResidueButton.Text = "Remover";
            this.removeResidueButton.UseVisualStyleBackColor = true;
            this.removeResidueButton.Visible = false;
            this.removeResidueButton.Click += new System.EventHandler(this.removeResidueButton_Click);
            // 
            // addResidueButton
            // 
            this.addResidueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addResidueButton.Location = new System.Drawing.Point(356, 246);
            this.addResidueButton.Margin = new System.Windows.Forms.Padding(8);
            this.addResidueButton.Name = "addResidueButton";
            this.addResidueButton.Size = new System.Drawing.Size(68, 27);
            this.addResidueButton.TabIndex = 5;
            this.addResidueButton.Text = "Novo";
            this.addResidueButton.UseVisualStyleBackColor = true;
            this.addResidueButton.Visible = false;
            this.addResidueButton.Click += new System.EventHandler(this.addResidueButton_Click);
            // 
            // chemicalReactorData
            // 
            this.chemicalReactorData.AllowUserToAddRows = false;
            this.chemicalReactorData.AllowUserToDeleteRows = false;
            this.chemicalReactorData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chemicalReactorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chemicalReactorData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.casNumberTab,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.chemicalReactorData.Location = new System.Drawing.Point(9, 75);
            this.chemicalReactorData.MinimumSize = new System.Drawing.Size(282, 0);
            this.chemicalReactorData.Name = "chemicalReactorData";
            this.chemicalReactorData.ReadOnly = true;
            this.chemicalReactorData.ShowCellToolTips = false;
            this.chemicalReactorData.Size = new System.Drawing.Size(557, 161);
            this.chemicalReactorData.TabIndex = 4;
            this.chemicalReactorData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chemicalReactorData_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Estado Físico";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Origem";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Unidade de Medida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Mistura";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // casNumberTab
            // 
            this.casNumberTab.HeaderText = "Número CAS";
            this.casNumberTab.Name = "casNumberTab";
            this.casNumberTab.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Características de periculosidade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Inerte?";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Armazenamento";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Recipiente";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // chemicalResidueData
            // 
            this.chemicalResidueData.AllowUserToAddRows = false;
            this.chemicalResidueData.AllowUserToDeleteRows = false;
            this.chemicalResidueData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chemicalResidueData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chemicalResidueData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chemicalResidueName,
            this.chemicalResiduePhysicalState,
            this.chemicalResidueOrigin,
            this.chemicalResidueQuantity,
            this.measurement,
            this.chemicalResidueDangers,
            this.dangerCharacteristics,
            this.inertState,
            this.chemicalResidueStorageLocation,
            this.chemicalResidueContainer});
            this.chemicalResidueData.Location = new System.Drawing.Point(297, 75);
            this.chemicalResidueData.Name = "chemicalResidueData";
            this.chemicalResidueData.ReadOnly = true;
            this.chemicalResidueData.Size = new System.Drawing.Size(269, 161);
            this.chemicalResidueData.TabIndex = 3;
            this.chemicalResidueData.Visible = false;
            // 
            // chemicalResidueName
            // 
            this.chemicalResidueName.HeaderText = "Nome";
            this.chemicalResidueName.Name = "chemicalResidueName";
            this.chemicalResidueName.ReadOnly = true;
            // 
            // chemicalResiduePhysicalState
            // 
            this.chemicalResiduePhysicalState.HeaderText = "Estado Físico";
            this.chemicalResiduePhysicalState.Name = "chemicalResiduePhysicalState";
            this.chemicalResiduePhysicalState.ReadOnly = true;
            // 
            // chemicalResidueOrigin
            // 
            this.chemicalResidueOrigin.HeaderText = "Origem";
            this.chemicalResidueOrigin.Name = "chemicalResidueOrigin";
            this.chemicalResidueOrigin.ReadOnly = true;
            // 
            // chemicalResidueQuantity
            // 
            this.chemicalResidueQuantity.HeaderText = "Quantidade";
            this.chemicalResidueQuantity.Name = "chemicalResidueQuantity";
            this.chemicalResidueQuantity.ReadOnly = true;
            // 
            // measurement
            // 
            this.measurement.HeaderText = "Unidade de Medida";
            this.measurement.Name = "measurement";
            this.measurement.ReadOnly = true;
            // 
            // chemicalResidueDangers
            // 
            this.chemicalResidueDangers.HeaderText = "Perigoso?";
            this.chemicalResidueDangers.Name = "chemicalResidueDangers";
            this.chemicalResidueDangers.ReadOnly = true;
            // 
            // dangerCharacteristics
            // 
            this.dangerCharacteristics.HeaderText = "Características de periculosidade";
            this.dangerCharacteristics.Name = "dangerCharacteristics";
            this.dangerCharacteristics.ReadOnly = true;
            // 
            // inertState
            // 
            this.inertState.HeaderText = "Inerte?";
            this.inertState.Name = "inertState";
            this.inertState.ReadOnly = true;
            // 
            // chemicalResidueStorageLocation
            // 
            this.chemicalResidueStorageLocation.HeaderText = "Armazenamento";
            this.chemicalResidueStorageLocation.Name = "chemicalResidueStorageLocation";
            this.chemicalResidueStorageLocation.ReadOnly = true;
            // 
            // chemicalResidueContainer
            // 
            this.chemicalResidueContainer.HeaderText = "Recipiente";
            this.chemicalResidueContainer.Name = "chemicalResidueContainer";
            this.chemicalResidueContainer.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resíduos";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reagentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indique nas tabelas abaixo os reagentes e resíduos químicos que são manipulados e" +
    "/ou gerados no local.";
            // 
            // ChemicalAgentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "ChemicalAgentControl";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.ChemicalAgentControlBetter_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalReactorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalResidueData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView chemicalResidueData;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResiduePhysicalState;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueDangers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dangerCharacteristics;
        private System.Windows.Forms.DataGridViewTextBoxColumn inertState;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueStorageLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueContainer;
        private System.Windows.Forms.DataGridView chemicalReactorData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn casNumberTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button addResidueButton;
        private System.Windows.Forms.Button removeResidueButton;
        private System.Windows.Forms.Button addReactorButton;
        private System.Windows.Forms.Button removeReactorButton;
        private System.Windows.Forms.LinkLabel nbrLinkLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton hasFISPQRadioButton;
        private System.Windows.Forms.RadioButton noFISPQRadioButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editReactorButton;
        private System.Windows.Forms.Button editResidueButton;
        private System.Windows.Forms.CheckBox residuosCheckbox;
    }
}
