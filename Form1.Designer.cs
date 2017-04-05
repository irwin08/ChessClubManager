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
            this.playersList = new System.Windows.Forms.ListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.losses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.draws = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.gamesTab = new System.Windows.Forms.TabPage();
            this.gamesList = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.playersTab.SuspendLayout();
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
            this.playersTab.Controls.Add(this.playersList);
            this.playersTab.Controls.Add(this.removeButton);
            this.playersTab.Controls.Add(this.addButton);
            this.playersTab.Location = new System.Drawing.Point(4, 22);
            this.playersTab.Name = "playersTab";
            this.playersTab.Size = new System.Drawing.Size(375, 285);
            this.playersTab.TabIndex = 0;
            this.playersTab.Text = "Players";
            this.playersTab.UseVisualStyleBackColor = true;
            this.playersTab.Click += new System.EventHandler(this.playersTab_Click);
            // 
            // playersList
            // 
            this.playersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.lastName,
            this.wins,
            this.losses,
            this.draws,
            this.rating});
            this.playersList.FullRowSelect = true;
            this.playersList.GridLines = true;
            this.playersList.Location = new System.Drawing.Point(3, 3);
            this.playersList.MultiSelect = false;
            this.playersList.Name = "playersList";
            this.playersList.Size = new System.Drawing.Size(369, 250);
            this.playersList.TabIndex = 2;
            this.playersList.UseCompatibleStateImageBehavior = false;
            this.playersList.View = System.Windows.Forms.View.Details;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 91;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 80;
            // 
            // wins
            // 
            this.wins.Text = "Wins";
            this.wins.Width = 37;
            // 
            // losses
            // 
            this.losses.Text = "Losses";
            this.losses.Width = 47;
            // 
            // draws
            // 
            this.draws.Text = "Draws";
            this.draws.Width = 42;
            // 
            // rating
            // 
            this.rating.Text = "Rating";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(247, 259);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(46, 259);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.Text = "Chess Club Manager";
            this.tabControl.ResumeLayout(false);
            this.playersTab.ResumeLayout(false);
            this.gamesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage gamesTab;
        private System.Windows.Forms.ListBox gamesList;
        private System.Windows.Forms.TabPage playersTab;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView playersList;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader wins;
        private System.Windows.Forms.ColumnHeader losses;
        private System.Windows.Forms.ColumnHeader draws;
        private System.Windows.Forms.ColumnHeader rating;

    }
}

