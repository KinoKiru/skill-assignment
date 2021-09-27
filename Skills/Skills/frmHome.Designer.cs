
namespace Skills
{
    partial class frmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beheerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verwijderenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUser = new System.Windows.Forms.Button();
            this.lbGames = new System.Windows.Forms.ListBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beheerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beheerToolStripMenuItem
            // 
            this.beheerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toevoegenToolStripMenuItem,
            this.verwijderenToolStripMenuItem});
            this.beheerToolStripMenuItem.Name = "beheerToolStripMenuItem";
            this.beheerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.beheerToolStripMenuItem.Text = "Beheer";
            // 
            // toevoegenToolStripMenuItem
            // 
            this.toevoegenToolStripMenuItem.Name = "toevoegenToolStripMenuItem";
            this.toevoegenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.toevoegenToolStripMenuItem.Text = "Toevoegen";
            this.toevoegenToolStripMenuItem.Click += new System.EventHandler(this.toevoegenToolStripMenuItem_Click);
            // 
            // verwijderenToolStripMenuItem
            // 
            this.verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
            this.verwijderenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.verwijderenToolStripMenuItem.Text = "Verwijderen";
            this.verwijderenToolStripMenuItem.Click += new System.EventHandler(this.verwijderenToolStripMenuItem_Click);
            // 
            // btnUser
            // 
            this.btnUser.Enabled = false;
            this.btnUser.Location = new System.Drawing.Point(725, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 23);
            this.btnUser.TabIndex = 1;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // lbGames
            // 
            this.lbGames.FormattingEnabled = true;
            this.lbGames.Location = new System.Drawing.Point(49, 49);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(120, 290);
            this.lbGames.TabIndex = 2;
            this.lbGames.SelectedIndexChanged += new System.EventHandler(this.lbGames_SelectedIndexChanged);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(202, 49);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(291, 290);
            this.txtInfo.TabIndex = 3;
            // 
            // pbGame
            // 
            this.pbGame.Location = new System.Drawing.Point(516, 80);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(246, 218);
            this.pbGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGame.TabIndex = 4;
            this.pbGame.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbGame);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lbGames);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beheerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toevoegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verwijderenToolStripMenuItem;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.ListBox lbGames;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.PictureBox pbGame;
    }
}