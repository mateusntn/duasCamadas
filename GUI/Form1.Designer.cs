﻿
namespace GUI
{
    partial class Form1
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
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.lblRam = new System.Windows.Forms.Label();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.lblStorage = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(52, 32);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(57, 20);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Marca:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(56, 58);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(372, 26);
            this.txtBrand.TabIndex = 1;
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(56, 124);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(372, 26);
            this.txtRam.TabIndex = 3;
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(52, 98);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(47, 20);
            this.lblRam.TabIndex = 2;
            this.lblRam.Text = "Ram:";
            // 
            // txtStorage
            // 
            this.txtStorage.Location = new System.Drawing.Point(56, 191);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.Size = new System.Drawing.Size(372, 26);
            this.txtStorage.TabIndex = 5;
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Location = new System.Drawing.Point(52, 168);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(131, 20);
            this.lblStorage.TabIndex = 4;
            this.lblStorage.Text = "Armazenamento:";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(353, 246);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 39);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtStorage);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Mr Robot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Button btnSend;
    }
}

