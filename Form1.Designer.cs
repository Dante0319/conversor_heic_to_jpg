﻿namespace conversor_intento2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConvertir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(367, 145);
            btnConvertir.Margin = new Padding(3, 2, 3, 2);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(238, 75);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(987, 758);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "BY DANTE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIG1__2_;
            ClientSize = new Size(1060, 782);
            Controls.Add(btnConvertir);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Heic to JPG";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private Label label1;
    }
}
