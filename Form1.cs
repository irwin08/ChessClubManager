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
            
            foreach (ListViewItem item in playersList.SelectedItems)
            {
                int count = 0;
                List<int> indexToRemove = new List<int>();
                foreach (Player player in manager.rankPlayers())
                {
                    if (item.Text.Equals(player.firstName))
                        indexToRemove.Add(count);
                    count++;
                }

                foreach(int i in indexToRemove)
                {
                    manager.removePlayer(manager.rankPlayers()[i].firstName, manager.rankPlayers()[i].lastName);
                }
                item.Remove(); 
            }

            updateListView();
        }

        private void updateListView()
        {
            playersList.Items.Clear();
            foreach(Player newPlayer in manager.rankPlayers())
            {

                string[] addPlayerString = new string[6];

                addPlayerString[0] = newPlayer.firstName;
                addPlayerString[1] = newPlayer.lastName;
                addPlayerString[2] = newPlayer.wins.ToString();
                addPlayerString[3] = newPlayer.losses.ToString();
                addPlayerString[4] = newPlayer.draws.ToString();
                addPlayerString[5] = newPlayer.rating.ToString();

                ListViewItem addPlayer = new ListViewItem(addPlayerString);
                playersList.Items.Add(addPlayer);
            }
        }
    }
}
