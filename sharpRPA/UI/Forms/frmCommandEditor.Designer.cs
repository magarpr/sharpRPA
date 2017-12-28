﻿namespace sharpRPA.UI.Forms
{
    partial class frmCommandEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommandEditor));
            this.cboSelectedCommand = new System.Windows.Forms.ComboBox();
            this.flw_InputVariables = new System.Windows.Forms.FlowLayoutPanel();
            this.uiBtnCancel = new sharpRPA.UI.CustomControls.UIPictureButton();
            this.uiBtnAdd = new sharpRPA.UI.CustomControls.UIPictureButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnAdd)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSelectedCommand
            // 
            this.cboSelectedCommand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboSelectedCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectedCommand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSelectedCommand.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectedCommand.FormattingEnabled = true;
            this.cboSelectedCommand.Location = new System.Drawing.Point(6, 5);
            this.cboSelectedCommand.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboSelectedCommand.Name = "cboSelectedCommand";
            this.cboSelectedCommand.Size = new System.Drawing.Size(535, 28);
            this.cboSelectedCommand.TabIndex = 2;
            this.cboSelectedCommand.SelectedIndexChanged += new System.EventHandler(this.cboSelectedCommand_SelectedIndexChanged);
            this.cboSelectedCommand.SelectionChangeCommitted += new System.EventHandler(this.cboSelectedCommand_SelectionChangeCommitted);
            // 
            // flw_InputVariables
            // 
            this.flw_InputVariables.AutoScroll = true;
            this.flw_InputVariables.BackColor = System.Drawing.Color.Transparent;
            this.flw_InputVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flw_InputVariables.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flw_InputVariables.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flw_InputVariables.Location = new System.Drawing.Point(2, 35);
            this.flw_InputVariables.Margin = new System.Windows.Forms.Padding(2);
            this.flw_InputVariables.Name = "flw_InputVariables";
            this.flw_InputVariables.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.flw_InputVariables.Size = new System.Drawing.Size(552, 435);
            this.flw_InputVariables.TabIndex = 3;
            this.flw_InputVariables.WrapContents = false;
            // 
            // uiBtnCancel
            // 
            this.uiBtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnCancel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnCancel.DisplayText = "Cancel";
            this.uiBtnCancel.DisplayTextBrush = System.Drawing.Color.White;
            this.uiBtnCancel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("uiBtnCancel.Image")));
            this.uiBtnCancel.IsMouseOver = false;
            this.uiBtnCancel.Location = new System.Drawing.Point(106, 5);
            this.uiBtnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.uiBtnCancel.Name = "uiBtnCancel";
            this.uiBtnCancel.Size = new System.Drawing.Size(88, 49);
            this.uiBtnCancel.TabIndex = 15;
            this.uiBtnCancel.TabStop = false;
            this.uiBtnCancel.Click += new System.EventHandler(this.uiBtnCancel_Click);
            // 
            // uiBtnAdd
            // 
            this.uiBtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnAdd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnAdd.DisplayText = "Ok";
            this.uiBtnAdd.DisplayTextBrush = System.Drawing.Color.White;
            this.uiBtnAdd.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("uiBtnAdd.Image")));
            this.uiBtnAdd.IsMouseOver = false;
            this.uiBtnAdd.Location = new System.Drawing.Point(6, 5);
            this.uiBtnAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.uiBtnAdd.Name = "uiBtnAdd";
            this.uiBtnAdd.Size = new System.Drawing.Size(88, 49);
            this.uiBtnAdd.TabIndex = 14;
            this.uiBtnAdd.TabStop = false;
            this.uiBtnAdd.Click += new System.EventHandler(this.uiBtnAdd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cboSelectedCommand, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flw_InputVariables, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 529);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.uiBtnAdd);
            this.flowLayoutPanel1.Controls.Add(this.uiBtnCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 472);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(556, 57);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // frmCommandEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(556, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Raleway Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmCommandEditor";
            this.Text = "Add New Command";
            this.Load += new System.EventHandler(this.frmNewCommand_Load);
            this.Shown += new System.EventHandler(this.frmCommandEditor_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnAdd)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboSelectedCommand;
        private System.Windows.Forms.FlowLayoutPanel flw_InputVariables;
        private sharpRPA.UI.CustomControls.UIPictureButton uiBtnCancel;
        private sharpRPA.UI.CustomControls.UIPictureButton uiBtnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}