namespace Projekt
{
    partial class formTodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTodo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlacitkoPridejItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(181, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 387);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tlacitkoPridejItem
            // 
            this.tlacitkoPridejItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tlacitkoPridejItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoPridejItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tlacitkoPridejItem.Image = ((System.Drawing.Image)(resources.GetObject("tlacitkoPridejItem.Image")));
            this.tlacitkoPridejItem.Location = new System.Drawing.Point(71, 27);
            this.tlacitkoPridejItem.Name = "tlacitkoPridejItem";
            this.tlacitkoPridejItem.Size = new System.Drawing.Size(104, 107);
            this.tlacitkoPridejItem.TabIndex = 2;
            this.tlacitkoPridejItem.UseVisualStyleBackColor = true;
            this.tlacitkoPridejItem.Click += new System.EventHandler(this.tlacitkoPridejItem_Click);
            // 
            // formTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.tlacitkoPridejItem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTodo";
            this.Text = "formTodo";
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button tlacitkoPridejItem;
    }
}