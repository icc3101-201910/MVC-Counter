﻿namespace EjemploMVCContador
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
            this.incrementarButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incrementarButton
            // 
            this.incrementarButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.incrementarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incrementarButton.Location = new System.Drawing.Point(270, 236);
            this.incrementarButton.Name = "incrementarButton";
            this.incrementarButton.Size = new System.Drawing.Size(193, 95);
            this.incrementarButton.TabIndex = 0;
            this.incrementarButton.Text = "Incrementar";
            this.incrementarButton.UseVisualStyleBackColor = false;
            this.incrementarButton.Click += new System.EventHandler(this.IncrementarButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(343, 133);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 56);
            this.label.TabIndex = 1;
            this.label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.incrementarButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button incrementarButton;
        private System.Windows.Forms.Label label;
    }
}

