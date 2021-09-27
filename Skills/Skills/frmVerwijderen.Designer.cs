
namespace Skills
{
    partial class frmVerwijderen
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
            this.lbGames = new System.Windows.Forms.ListBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnnStoppen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGames
            // 
            this.lbGames.FormattingEnabled = true;
            this.lbGames.Location = new System.Drawing.Point(22, 12);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(147, 407);
            this.lbGames.TabIndex = 0;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(281, 119);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 1;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnnStoppen
            // 
            this.btnnStoppen.Location = new System.Drawing.Point(281, 209);
            this.btnnStoppen.Name = "btnnStoppen";
            this.btnnStoppen.Size = new System.Drawing.Size(75, 23);
            this.btnnStoppen.TabIndex = 2;
            this.btnnStoppen.Text = "Stoppen";
            this.btnnStoppen.UseVisualStyleBackColor = true;
            this.btnnStoppen.Click += new System.EventHandler(this.btnnStoppen_Click);
            // 
            // frmVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.btnnStoppen);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.lbGames);
            this.Name = "frmVerwijderen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verwijderen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVerwijderen_FormClosing);
            this.Load += new System.EventHandler(this.frmVerwijderen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbGames;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnnStoppen;
    }
}