namespace app1_funker_ikke_så_her_er_den_igjen
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
            this.knapp = new System.Windows.Forms.Button();
            this.tekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // knapp
            // 
            this.knapp.Location = new System.Drawing.Point(553, 123);
            this.knapp.Name = "knapp";
            this.knapp.Size = new System.Drawing.Size(198, 174);
            this.knapp.TabIndex = 0;
            this.knapp.Text = "trykk pls jeg ber";
            this.knapp.UseVisualStyleBackColor = true;
            this.knapp.Click += new System.EventHandler(this.knapp_Click);
            // 
            // tekst
            // 
            this.tekst.AutoSize = true;
            this.tekst.Location = new System.Drawing.Point(156, 160);
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(106, 13);
            this.tekst.TabIndex = 1;
            this.tekst.Text = "jeg kommer til å bytte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tekst);
            this.Controls.Add(this.knapp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button knapp;
        private System.Windows.Forms.Label tekst;
    }
}

