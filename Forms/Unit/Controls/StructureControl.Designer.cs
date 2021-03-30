﻿
namespace RyskTech
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.internalStructureGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.InternalStructureDataGridView = new System.Windows.Forms.DataGridView();
            this.building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usage_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usage_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.externalStructureGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SurroundingInfoTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.internalStructureGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternalStructureDataGridView)).BeginInit();
            this.externalStructureGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.72993F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.27007F));
            this.tableLayoutPanel1.Controls.Add(this.internalStructureGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.externalStructureGroupBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.26667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.73333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 435);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // internalStructureGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.internalStructureGroupBox, 2);
            this.internalStructureGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.internalStructureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.internalStructureGroupBox.Location = new System.Drawing.Point(3, 3);
            this.internalStructureGroupBox.Name = "internalStructureGroupBox";
            this.internalStructureGroupBox.Size = new System.Drawing.Size(820, 256);
            this.internalStructureGroupBox.TabIndex = 0;
            this.internalStructureGroupBox.TabStop = false;
            this.internalStructureGroupBox.Text = "Interna";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.InternalStructureDataGridView, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(814, 237);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preencha a tabela abaixo com as informações sobre prédios, salas e espaços utiliz" +
    "ados na unidade";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InternalStructureDataGridView
            // 
            this.InternalStructureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InternalStructureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.building,
            this.room,
            this.level,
            this.usage_start,
            this.usage_end});
            this.tableLayoutPanel2.SetColumnSpan(this.InternalStructureDataGridView, 2);
            this.InternalStructureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InternalStructureDataGridView.Location = new System.Drawing.Point(3, 29);
            this.InternalStructureDataGridView.Name = "InternalStructureDataGridView";
            this.InternalStructureDataGridView.Size = new System.Drawing.Size(808, 205);
            this.InternalStructureDataGridView.TabIndex = 1;
            // 
            // building
            // 
            this.building.HeaderText = "Prédio";
            this.building.Name = "building";
            // 
            // room
            // 
            this.room.HeaderText = "Sala";
            this.room.Name = "room";
            // 
            // level
            // 
            this.level.HeaderText = "Andar";
            this.level.Name = "level";
            // 
            // usage_start
            // 
            this.usage_start.HeaderText = "Início do turno";
            this.usage_start.Name = "usage_start";
            // 
            // usage_end
            // 
            this.usage_end.HeaderText = "Fim do turno";
            this.usage_end.Name = "usage_end";
            // 
            // externalStructureGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.externalStructureGroupBox, 2);
            this.externalStructureGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.externalStructureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.externalStructureGroupBox.Location = new System.Drawing.Point(3, 265);
            this.externalStructureGroupBox.Name = "externalStructureGroupBox";
            this.externalStructureGroupBox.Size = new System.Drawing.Size(820, 167);
            this.externalStructureGroupBox.TabIndex = 1;
            this.externalStructureGroupBox.TabStop = false;
            this.externalStructureGroupBox.Text = "Externa";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.SurroundingInfoTextBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.2973F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.70271F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(814, 148);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(808, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preencha a caixa de texto abaixo com informações relevantes sobre o entorno da su" +
    "a unidade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurroundingInfoTextBox
            // 
            this.SurroundingInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SurroundingInfoTextBox.Location = new System.Drawing.Point(3, 35);
            this.SurroundingInfoTextBox.Multiline = true;
            this.SurroundingInfoTextBox.Name = "SurroundingInfoTextBox";
            this.SurroundingInfoTextBox.Size = new System.Drawing.Size(808, 110);
            this.SurroundingInfoTextBox.TabIndex = 1;
            this.SurroundingInfoTextBox.TextChanged += new System.EventHandler(this.SurroundingInfoTextBox_TextChanged);
            // 
            // StructureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StructureControl";
            this.Size = new System.Drawing.Size(826, 435);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.internalStructureGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternalStructureDataGridView)).EndInit();
            this.externalStructureGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox internalStructureGroupBox;
        private System.Windows.Forms.GroupBox externalStructureGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView InternalStructureDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurroundingInfoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn building;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn usage_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn usage_end;
    }
}