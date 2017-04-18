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

            updateListView();
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
            string itemName = playersList.SelectedItems[0].Text;

            List<int> indexToRemove = new List<int>();
            for (int i = 0; i < manager.rankPlayers().Count; i++)
            {
                List<Player> playersByRank = manager.rankPlayers();
                string fName = playersByRank[i].firstName;
                string lName = playersByRank[i].lastName;
                if (fName.CompareTo(itemName) == 0)
                { 
                    manager.removePlayer(fName, lName);
                    //i--;
                }
            }

            int count2 = 0;
            List<int> indexToRemove2 = new List<int>();
            foreach(ListViewItem p in playersList.Items)
            {
                if(itemName.Equals(p.Text))
                {
                    indexToRemove2.Add(count2);
                }
                count2++;
            }

            foreach(int i in indexToRemove2)
            {
                playersList.Items[i].Remove();
            }
            

            updateListView();
        }

        private void updateListView()
        {
            playersList.Items.Clear();

            for (int i = manager.rankPlayers().Count-1; i >= 0; i--)
            {
                Player newPlayer = manager.rankPlayers()[i];
                string[] addPlayerString = new string[6];
                
                addPlayerString[0] = newPlayer.firstName;
                addPlayerString[1] = newPlayer.lastName;
                addPlayerString[2] = newPlayer.wins.ToString();
                addPlayerString[3] = newPlayer.losses.ToString();
                addPlayerString[4] = newPlayer.draws.ToString();
                addPlayerString[5] = newPlayer.rating.ToString("#");
                
                ListViewItem addPlayer = new ListViewItem(addPlayerString);
                playersList.Items.Add(addPlayer);
                }

            gamesList.Items.Clear();
            foreach (Game newGame in manager.getGames())
            {
                string[] addGameString = new string[4];

                addGameString[0] = newGame.whiteName;
                addGameString[1] = newGame.blackName;
                addGameString[2] = newGame.result.ToString();
                addGameString[3] = newGame.date.ToString("d");

                ListViewItem addGame = new ListViewItem(addGameString);
                gamesList.Items.Add(addGame);
            }
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            AddGameForm gameForm = new AddGameForm(manager);

            if (gameForm.ShowDialog(this) == DialogResult.OK)
            {
                if (gameForm.whiteWinRadio.Checked)
                {
                    manager.addGame(gameForm.whiteList.SelectedItems[0].Text, gameForm.blackList.SelectedItems[0].Text, 1, gameForm.datePicker.Value);
                }
                else if(gameForm.blackWinRadio.Checked)
                {
                    manager.addGame(gameForm.whiteList.SelectedItems[0].Text, gameForm.blackList.SelectedItems[0].Text, 0, gameForm.datePicker.Value);
                }
                else if (gameForm.drawRadio.Checked)
                {
                    manager.addGame(gameForm.whiteList.SelectedItems[0].Text, gameForm.blackList.SelectedItems[0].Text, 0.5, gameForm.datePicker.Value);
                }
                updateListView();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Player> pl = manager.rankPlayers();
            System.IO.StreamWriter file = new System.IO.StreamWriter("players.csv");
            foreach (Player aPlayer in pl)
            {
                string line = aPlayer.firstName + "," + aPlayer.lastName + "," + aPlayer.wins.ToString() + "," + aPlayer.losses.ToString() + "," + aPlayer.draws.ToString() + "," + aPlayer.rating.ToString();

                
                file.WriteLine(line);

               
            }
            file.Close();

            List<Game> gl = manager.getGames();
            System.IO.StreamWriter file2 = new System.IO.StreamWriter("games.csv");
            foreach (Game g in gl)
            {
                string line = g.whiteName + "," + g.blackName + "," + g.result.ToString() + "," + g.date.ToString();

                
                file2.WriteLine(line);

                
            }
            file2.Close();
        }

      
    }
}
