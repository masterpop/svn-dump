﻿namespace AchieveTool {
	partial class frmAddRequirement {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtParam = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 12, 9 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 35, 13 );
			this.label1.TabIndex = 0;
			this.label1.Text = "Count";
			// 
			// txtCount
			// 
			this.txtCount.Location = new System.Drawing.Point( 53, 6 );
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size( 45, 20 );
			this.txtCount.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 12, 34 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 37, 13 );
			this.label2.TabIndex = 2;
			this.label2.Text = "Param";
			// 
			// txtParam
			// 
			this.txtParam.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.txtParam.Location = new System.Drawing.Point( 53, 31 );
			this.txtParam.Name = "txtParam";
			this.txtParam.Size = new System.Drawing.Size( 160, 20 );
			this.txtParam.TabIndex = 3;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point( 157, 59 );
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size( 56, 23 );
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler( this.btnOK_Click );
			// 
			// frmAddRequirement
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 226, 98 );
			this.Controls.Add( this.btnOK );
			this.Controls.Add( this.txtParam );
			this.Controls.Add( this.label2 );
			this.Controls.Add( this.txtCount );
			this.Controls.Add( this.label1 );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmAddRequirement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAddRequirement";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtParam;
		private System.Windows.Forms.Button btnOK;
	}
}