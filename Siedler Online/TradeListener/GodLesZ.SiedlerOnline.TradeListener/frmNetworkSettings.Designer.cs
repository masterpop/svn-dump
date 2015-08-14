﻿namespace GodLesZ.SiedlerOnline.TradeListener {
	partial class frmNetworkSettings {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNetworkSettings));
			this.cmbInterfaces = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.imgNetwork = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imgNetwork)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbInterfaces
			// 
			this.cmbInterfaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbInterfaces.FormattingEnabled = true;
			this.cmbInterfaces.Location = new System.Drawing.Point(77, 40);
			this.cmbInterfaces.Name = "cmbInterfaces";
			this.cmbInterfaces.Size = new System.Drawing.Size(264, 21);
			this.cmbInterfaces.TabIndex = 0;
			this.cmbInterfaces.SelectedIndexChanged += new System.EventHandler(this.cmbInterfaces_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(74, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Please choose an interface to listen on:";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(185, 85);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(266, 85);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// imgNetwork
			// 
			this.imgNetwork.Image = global::GodLesZ.SiedlerOnline.TradeListener.Properties.Resources.clients;
			this.imgNetwork.Location = new System.Drawing.Point(13, 13);
			this.imgNetwork.Name = "imgNetwork";
			this.imgNetwork.Size = new System.Drawing.Size(48, 48);
			this.imgNetwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.imgNetwork.TabIndex = 4;
			this.imgNetwork.TabStop = false;
			// 
			// frmNetworkSettings
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(353, 120);
			this.Controls.Add(this.imgNetwork);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbInterfaces);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(361, 147);
			this.Name = "frmNetworkSettings";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DSO Trade Listener - Network Configuration";
			this.Load += new System.EventHandler(this.frmNetworkSettings_Load);
			((System.ComponentModel.ISupportInitialize)(this.imgNetwork)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbInterfaces;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.PictureBox imgNetwork;
	}
}