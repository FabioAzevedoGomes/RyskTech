
namespace RyskTech.Forms.Unit.Controls
{
    partial class StructureControl
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
            this.InternalStructureDataGridView = new System.Windows.Forms.DataGridView();
            this.building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usage_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usage_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surroundingsInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editSpaceButton = new System.Windows.Forms.Button();
            this.removeSpaceButton = new System.Windows.Forms.Button();
            this.addSpaceButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternalStructureDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.InternalStructureDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.533916F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.4639F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.221006F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // InternalStructureDataGridView
            // 
            this.InternalStructureDataGridView.AllowUserToAddRows = false;
            this.InternalStructureDataGridView.AllowUserToDeleteRows = false;
            this.InternalStructureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InternalStructureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InternalStructureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.building,
            this.room,
            this.level,
            this.usage_start,
            this.usage_end,
            this.surroundingsInfo,
            this.weekDays});
            this.mainTableLayoutPanel.SetColumnSpan(this.InternalStructureDataGridView, 2);
            this.InternalStructureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InternalStructureDataGridView.Location = new System.Drawing.Point(8, 46);
            this.InternalStructureDataGridView.Name = "InternalStructureDataGridView";
            this.InternalStructureDataGridView.ReadOnly = true;
            this.InternalStructureDataGridView.Size = new System.Drawing.Size(580, 379);
            this.InternalStructureDataGridView.TabIndex = 2;
            // 
            // building
            // 
            this.building.HeaderText = "Prédio";
            this.building.Name = "building";
            this.building.ReadOnly = true;
            // 
            // room
            // 
            this.room.HeaderText = "Sala";
            this.room.Name = "room";
            this.room.ReadOnly = true;
            // 
            // level
            // 
            this.level.HeaderText = "Andar";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            // 
            // usage_start
            // 
            this.usage_start.HeaderText = "Início do turno";
            this.usage_start.Name = "usage_start";
            this.usage_start.ReadOnly = true;
            // 
            // usage_end
            // 
            this.usage_end.HeaderText = "Fim do turno";
            this.usage_end.Name = "usage_end";
            this.usage_end.ReadOnly = true;
            // 
            // surroundingsInfo
            // 
            this.surroundingsInfo.HeaderText = "Comentários";
            this.surroundingsInfo.Name = "surroundingsInfo";
            this.surroundingsInfo.ReadOnly = true;
            // 
            // weekDays
            // 
            this.weekDays.HeaderText = "Dias";
            this.weekDays.Name = "weekDays";
            this.weekDays.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Preencha a tabela abaixo com as informações sobre prédios, salas e espaços utiliz" +
    "ados na unidade";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.editSpaceButton);
            this.panel1.Controls.Add(this.removeSpaceButton);
            this.panel1.Controls.Add(this.addSpaceButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 428);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 34);
            this.panel1.TabIndex = 4;
            // 
            // editSpaceButton
            // 
            this.editSpaceButton.Location = new System.Drawing.Point(87, 5);
            this.editSpaceButton.Name = "editSpaceButton";
            this.editSpaceButton.Size = new System.Drawing.Size(75, 23);
            this.editSpaceButton.TabIndex = 2;
            this.editSpaceButton.Text = "Editar";
            this.editSpaceButton.UseVisualStyleBackColor = true;
            this.editSpaceButton.Click += new System.EventHandler(this.editSpaceButton_Click);
            // 
            // removeSpaceButton
            // 
            this.removeSpaceButton.Location = new System.Drawing.Point(168, 5);
            this.removeSpaceButton.Name = "removeSpaceButton";
            this.removeSpaceButton.Size = new System.Drawing.Size(75, 23);
            this.removeSpaceButton.TabIndex = 1;
            this.removeSpaceButton.Text = "Remover";
            this.removeSpaceButton.UseVisualStyleBackColor = true;
            this.removeSpaceButton.Click += new System.EventHandler(this.removeSpaceButton_Click);
            // 
            // addSpaceButton
            // 
            this.addSpaceButton.Location = new System.Drawing.Point(6, 5);
            this.addSpaceButton.Name = "addSpaceButton";
            this.addSpaceButton.Size = new System.Drawing.Size(75, 23);
            this.addSpaceButton.TabIndex = 0;
            this.addSpaceButton.Text = "Adicionar";
            this.addSpaceButton.UseVisualStyleBackColor = true;
            this.addSpaceButton.Click += new System.EventHandler(this.addSpaceButton_Click);
            // 
            // StructureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "StructureControl";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.TestStructureControl_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternalStructureDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView InternalStructureDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addSpaceButton;
        private System.Windows.Forms.Button removeSpaceButton;
        private System.Windows.Forms.Button editSpaceButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn building;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn usage_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn usage_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn surroundingsInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekDays;
    }
}
