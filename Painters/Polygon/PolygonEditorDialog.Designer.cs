﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.UniversalControl
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-01-2018
// ***********************************************************************
// <copyright file="PolygonEditorDialog.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.UniversalControl.Editors.PolyEditor
{
    partial class PolygonEditorDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.thematic1501 = new Zeroit.Framework.UniversalControl.ThemeManagers.SpicyLips();
            this.location_Label = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.downButton = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.axesCheckBox = new System.Windows.Forms.CheckBox();
            this.imagePanel = new Zeroit.Framework.UniversalControl.Editors.NoFlickerPanel();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.thematic1501.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // thematic1501
            // 
            this.thematic1501.BackColor = System.Drawing.Color.White;
            this.thematic1501.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.thematic1501.Colors = new Zeroit.Framework.UniversalControl.ThemeManagers.Bloom[0];
            this.thematic1501.Controls.Add(this.location_Label);
            this.thematic1501.Controls.Add(this.closeBtn);
            this.thematic1501.Controls.Add(this.zoomTrackBar);
            this.thematic1501.Controls.Add(this.label3);
            this.thematic1501.Controls.Add(this.downButton);
            this.thematic1501.Controls.Add(this.grid);
            this.thematic1501.Controls.Add(this.addButton);
            this.thematic1501.Controls.Add(this.delButton);
            this.thematic1501.Controls.Add(this.cancelButton);
            this.thematic1501.Controls.Add(this.upButton);
            this.thematic1501.Controls.Add(this.zoomLabel);
            this.thematic1501.Controls.Add(this.okButton);
            this.thematic1501.Controls.Add(this.label1);
            this.thematic1501.Controls.Add(this.axesCheckBox);
            this.thematic1501.Controls.Add(this.imagePanel);
            this.thematic1501.Controls.Add(this.gridCheckBox);
            this.thematic1501.Customization = "";
            this.thematic1501.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thematic1501.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.thematic1501.Image = null;
            this.thematic1501.Location = new System.Drawing.Point(0, 0);
            this.thematic1501.Movable = true;
            this.thematic1501.Name = "thematic1501";
            this.thematic1501.NoRounding = false;
            this.thematic1501.Sizable = false;
            this.thematic1501.Size = new System.Drawing.Size(1154, 793);
            this.thematic1501.SmartBounds = true;
            this.thematic1501.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.thematic1501.TabIndex = 0;
            this.thematic1501.Text = "Polygon Editor";
            this.thematic1501.TransparencyKey = System.Drawing.Color.Empty;
            this.thematic1501.Transparent = false;
            // 
            // location_Label
            // 
            this.location_Label.AutoSize = true;
            this.location_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.location_Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.location_Label.ForeColor = System.Drawing.SystemColors.Control;
            this.location_Label.Location = new System.Drawing.Point(536, 741);
            this.location_Label.Name = "location_Label";
            this.location_Label.Size = new System.Drawing.Size(61, 19);
            this.location_Label.TabIndex = 8;
            this.location_Label.Text = "Location";
            this.location_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.closeBtn.Location = new System.Drawing.Point(1131, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "x";
            this.closeBtn.UseCompatibleTextRendering = true;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.zoomTrackBar.Location = new System.Drawing.Point(267, 669);
            this.zoomTrackBar.Maximum = 23;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(802, 45);
            this.zoomTrackBar.TabIndex = 6;
            this.zoomTrackBar.Value = 2;
            this.zoomTrackBar.ValueChanged += new System.EventHandler(this.zoomTrackBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(17, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(656, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Create and edit the polygon by entering the coordinates of the points which make " +
    "up the polygon";
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.downButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.downButton.ForeColor = System.Drawing.Color.White;
            this.downButton.Location = new System.Drawing.Point(79, 693);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(58, 31);
            this.downButton.TabIndex = 3;
            this.downButton.Text = "&Down";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colX,
            this.colY});
            this.grid.Location = new System.Drawing.Point(18, 64);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid.Size = new System.Drawing.Size(119, 586);
            this.grid.TabIndex = 1;
            this.grid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellValidated);
            this.grid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grid_CellValidating);
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // colX
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colX.DefaultCellStyle = dataGridViewCellStyle3;
            this.colX.HeaderText = "X";
            this.colX.Name = "colX";
            // 
            // colY
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colY.DefaultCellStyle = dataGridViewCellStyle4;
            this.colY.HeaderText = "Y";
            this.colY.Name = "colY";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(18, 656);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(58, 31);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.delButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.delButton.ForeColor = System.Drawing.Color.White;
            this.delButton.Location = new System.Drawing.Point(79, 656);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(58, 31);
            this.delButton.TabIndex = 1;
            this.delButton.Text = "D&el";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelButton.Location = new System.Drawing.Point(120, 741);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 40);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.upButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.upButton.ForeColor = System.Drawing.Color.White;
            this.upButton.Location = new System.Drawing.Point(18, 693);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(58, 31);
            this.upButton.TabIndex = 2;
            this.upButton.Text = "&Up";
            this.upButton.UseVisualStyleBackColor = false;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // zoomLabel
            // 
            this.zoomLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.zoomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomLabel.ForeColor = System.Drawing.Color.White;
            this.zoomLabel.Location = new System.Drawing.Point(204, 667);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(57, 32);
            this.zoomLabel.TabIndex = 2;
            this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.okButton.Location = new System.Drawing.Point(17, 741);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 40);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(150, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zoom:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axesCheckBox
            // 
            this.axesCheckBox.AutoSize = true;
            this.axesCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.axesCheckBox.Checked = true;
            this.axesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.axesCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.axesCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.axesCheckBox.Location = new System.Drawing.Point(1075, 665);
            this.axesCheckBox.Name = "axesCheckBox";
            this.axesCheckBox.Size = new System.Drawing.Size(56, 23);
            this.axesCheckBox.TabIndex = 2;
            this.axesCheckBox.Text = "Axes";
            this.axesCheckBox.UseVisualStyleBackColor = false;
            this.axesCheckBox.CheckedChanged += new System.EventHandler(this.axesCheckBox_CheckedChanged);
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Location = new System.Drawing.Point(144, 64);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(987, 584);
            this.imagePanel.TabIndex = 0;
            this.imagePanel.SizeChanged += new System.EventHandler(this.imagePanel_SizeChanged);
            this.imagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.imagePanel_Paint);
            this.imagePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imagePanel_MouseClick);
            this.imagePanel.MouseEnter += new System.EventHandler(this.imagePanel_MouseEnter);
            this.imagePanel.MouseLeave += new System.EventHandler(this.imagePanel_MouseLeave);
            this.imagePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagePanel_MouseMove);
            // 
            // gridCheckBox
            // 
            this.gridCheckBox.AutoSize = true;
            this.gridCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gridCheckBox.Checked = true;
            this.gridCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.gridCheckBox.Location = new System.Drawing.Point(1075, 701);
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Size = new System.Drawing.Size(54, 23);
            this.gridCheckBox.TabIndex = 3;
            this.gridCheckBox.Text = "Grid";
            this.gridCheckBox.UseVisualStyleBackColor = false;
            this.gridCheckBox.CheckedChanged += new System.EventHandler(this.gridCheckBox_CheckedChanged);
            // 
            // PolygonEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 793);
            this.Controls.Add(this.thematic1501);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PolygonEditorDialog";
            this.Text = "PolygonEditor";
            this.thematic1501.ResumeLayout(false);
            this.thematic1501.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zeroit.Framework.UniversalControl.ThemeManagers.SpicyLips thematic1501;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox axesCheckBox;
        private Editors.NoFlickerPanel imagePanel;
        private System.Windows.Forms.CheckBox gridCheckBox;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label location_Label;
    }
}