﻿namespace healthy_food
{
    partial class Form9
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
            this.label1 = new System.Windows.Forms.Label();
            this.next5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "To build muscles, you must follow healthy diets such as proteins, vegetables, fru" +
    "its, etc.,\r\n in addition to following a sports system organized by trainers.";
            // 
            // next5
            // 
            this.next5.FlatAppearance.BorderSize = 0;
            this.next5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next5.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.next5.Location = new System.Drawing.Point(635, 321);
            this.next5.Name = "next5";
            this.next5.Size = new System.Drawing.Size(97, 45);
            this.next5.TabIndex = 1;
            this.next5.Text = "NEXT";
            this.next5.UseVisualStyleBackColor = true;
            this.next5.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.next5);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Build  Muscle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button next5;
    }
}