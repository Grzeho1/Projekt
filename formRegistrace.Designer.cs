﻿namespace Projekt
{
    partial class formRegistrace
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxHeslo = new System.Windows.Forms.TextBox();
            this.textBoxPotvrzeni = new System.Windows.Forms.TextBox();
            this.tlacitkoRegistruj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Heslo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(42, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Potvrzení hesla";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxLogin.Location = new System.Drawing.Point(42, 72);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(267, 23);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxHeslo
            // 
            this.textBoxHeslo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxHeslo.Location = new System.Drawing.Point(42, 138);
            this.textBoxHeslo.Name = "textBoxHeslo";
            this.textBoxHeslo.Size = new System.Drawing.Size(267, 23);
            this.textBoxHeslo.TabIndex = 1;
            // 
            // textBoxPotvrzeni
            // 
            this.textBoxPotvrzeni.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPotvrzeni.Location = new System.Drawing.Point(42, 204);
            this.textBoxPotvrzeni.Name = "textBoxPotvrzeni";
            this.textBoxPotvrzeni.Size = new System.Drawing.Size(267, 23);
            this.textBoxPotvrzeni.TabIndex = 1;
            // 
            // tlacitkoRegistruj
            // 
            this.tlacitkoRegistruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoRegistruj.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tlacitkoRegistruj.ForeColor = System.Drawing.Color.SteelBlue;
            this.tlacitkoRegistruj.Location = new System.Drawing.Point(91, 251);
            this.tlacitkoRegistruj.Name = "tlacitkoRegistruj";
            this.tlacitkoRegistruj.Size = new System.Drawing.Size(159, 41);
            this.tlacitkoRegistruj.TabIndex = 3;
            this.tlacitkoRegistruj.Text = "Registruj";
            this.tlacitkoRegistruj.UseVisualStyleBackColor = true;
            this.tlacitkoRegistruj.Click += new System.EventHandler(this.tlacitkoRegistruj_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(42, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zpět na přihášení";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formRegistrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(351, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tlacitkoRegistruj);
            this.Controls.Add(this.textBoxPotvrzeni);
            this.Controls.Add(this.textBoxHeslo);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRegistrace";
            this.Text = "formRegistrace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxLogin;
        private TextBox textBoxHeslo;
        private TextBox textBoxPotvrzeni;
        private Button tlacitkoRegistruj;
        private Button button1;
    }
}