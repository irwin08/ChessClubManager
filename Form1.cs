using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChessClubManager
{
    public partial class Form1 : Form
    {
        ChessClubManager manager;

        public Form1()
        {
            InitializeComponent();

            manager = new ChessClubManager();
        }

        private void playersTab_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //create pop up box with fields for first and last name
            //manager.addPlayer(

            string fName;
            string lName;

            AddPlayerForm playerForm = new AddPlayerForm();

            if (playerForm.ShowDialog(this) == DialogResult.OK)
            {
                fName = playerForm.firstNameBox.Text;
                lName = playerForm.lastNameBox.Text;

                manager.addPlayer(fName, lName);
                updateListView();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void updateListView()
        {
            for (int i = 0; i < manager.rankPlayers().Count; i++)
            {
                ListViewItem addPlayer = new ListViewItem();
                addPlayer.Text = manager.rankPlayers()[i].firstName;
                addPlayer.SubItems.Add(manager.rankPlayers()[i].lastName);
                addPlayer.SubItems.Add(manager.rankPlayers()[i].wins.ToString());
                addPlayer.SubItems.Add(manager.rankPlayers()[i].losses.ToString());
                addPlayer.SubItems.Add(manager.rankPlayers()[i].draws.ToString());
                addPlayer.SubItems.Add(manager.rankPlayers()[i].rating.ToString());

                playersList.Items.Add(addPlayer);
            }
        }
    }
}
