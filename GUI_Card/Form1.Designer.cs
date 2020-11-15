namespace GUI_Card
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
            this.panel_Card = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_Card
            // 
            this.panel_Card.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Card.Location = new System.Drawing.Point(0, 0);
            this.panel_Card.Name = "panel_Card";
            this.panel_Card.Size = new System.Drawing.Size(250, 350);
            this.panel_Card.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1349, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 715);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_Card);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Card;
        private System.Windows.Forms.Button button1;
    }
}

