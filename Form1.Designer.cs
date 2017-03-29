namespace ChessClubManager
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.playersTab = new System.Windows.Forms.TabPage();
            this.gamesTab = new System.Windows.Forms.TabPage();
            this.gamesList = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.gamesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.playersTab);
            this.tabControl.Controls.Add(this.gamesTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(383, 311);
            this.tabControl.TabIndex = 0;
            // 
            // playersTab
            // 
            this.playersTab.Location = new System.Drawing.Point(4, 22);
            this.playersTab.Name = "playersTab";
            this.playersTab.Size = new System.Drawing.Size(375, 285);
            this.playersTab.TabIndex = 0;
            this.playersTab.Text = "Players";
            this.playersTab.UseVisualStyleBackColor = true;
            // 
            // gamesTab
            // 
            this.gamesTab.Controls.Add(this.gamesList);
            this.gamesTab.Location = new System.Drawing.Point(4, 22);
            this.gamesTab.Name = "gamesTab";
            this.gamesTab.Size = new System.Drawing.Size(375, 285);
            this.gamesTab.TabIndex = 1;
            this.gamesTab.Text = "Games";
            this.gamesTab.UseVisualStyleBackColor = true;
            // 
            // gamesList
            // 
            this.gamesList.FormattingEnabled = true;
            this.gamesList.Location = new System.Drawing.Point(3, 3);
            this.gamesList.Name = "gamesList";
            this.gamesList.Size = new System.Drawing.Size(369, 277);
            this.gamesList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 335);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.gamesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage playersTab;
        private System.Windows.Forms.TabPage gamesTab;
        private System.Windows.Forms.ListBox gamesList;

    }
}

