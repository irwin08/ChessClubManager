using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessClubManager
{
    class ChessClubManager
    {
        List<Player> player = new List<Player>();


        public ChessClubManager()
        {
            loadFromFile("players.csv");
        }

        public void addPlayer(string fName, string lName, double rating=800)
        {
            Player newPlayer = new Player(fName, lName, rating);
            player.Add(newPlayer);
            addToFile(newPlayer);
        }

        public void removePlayer(string fName, string lName)
        {
            for (int i = 0; i < player.Count; i++ )
            {
                if ((String.Compare(fName, player[i].firstName) == 0) && (String.Compare(lName, player[i].lastName) == 0))
                {
                    removeFromFile(player[i]);
                    player.RemoveAt(i);
                    i--;
                }
            }
        }

        public List<Player> rankPlayers()
        {
            List<Player> rankedList = player;
            rankedList.Sort();
            return rankedList;
        }

        private void addToFile(Player aPlayer)
        {
            string line = aPlayer.firstName + "," + aPlayer.lastName + "," + aPlayer.wins.ToString() + "," + aPlayer.losses.ToString() +"," + aPlayer.draws.ToString() + "," + aPlayer.rating.ToString();

            System.IO.StreamWriter file = new System.IO.StreamWriter("players.csv", true);
            file.WriteLine(line);

            file.Close();
        }

        private void removeFromFile(Player rPlayer)
        {
            
            string line;
            string[] words;

            System.IO.StreamReader file = new System.IO.StreamReader("players.csv");

            List<string> newFile = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                words = line.Split(',');
                if ((String.Compare(words[0], rPlayer.firstName) == 0) && (String.Compare(words[1], rPlayer.lastName) == 0))
                {
                    continue;
                }

                newFile.Add(line);
            }

            file.Close();

            System.IO.StreamWriter file2 = new System.IO.StreamWriter("players.csv");

            foreach (string newLine in newFile)
            {
                file2.WriteLine(newLine);
            }

            file2.Close();
        }

        private void loadFromFile(string fileString)
        {
            string line;
            string[] words;

            System.IO.StreamReader file = new System.IO.StreamReader(fileString);
            while ((line = file.ReadLine()) != null)
            {
                words = line.Split(',');
                player.Add(new Player(words[0], words[1], Double.Parse(words[5])));
                player[player.Count - 1].wins = int.Parse(words[2]);
                player[player.Count - 1].losses = int.Parse(words[3]);
                player[player.Count - 1].draws = int.Parse(words[4]);
            }

            file.Close();
        }
    }
}
