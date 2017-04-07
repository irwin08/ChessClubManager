using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessClubManager
{
    public class ChessClubManager
    {
        List<Player> player = new List<Player>();
        List<Game> game = new List<Game>();


        public ChessClubManager()
        {
            loadFromFile("players.csv", "games.csv");
        }

        public void addGame(string wN, string bN, double r, DateTime d)
        {
            Game nG = new Game(wN, bN, r, d);
            game.Add(nG);

            string[] name = wN.Split(' ');
            string[] bName = bN.Split(' ');

            foreach (Player p in player)
            {
                if ((name[0] == p.firstName) && (name[1] == p.lastName))
                {
                    foreach (Player bP in player)
                    {
                        if ((bName[0] == bP.firstName) && (bName[1] == bP.lastName))
                        {
                            if (r == 1)
                            {
                                p.wins++;
                                bP.losses++;
                                Player.updateRatings(p, bP, false);
                            }
                            else if (r == 0)
                            {
                                p.losses++;
                                bP.wins++;
                                Player.updateRatings(bP, p, false);
                            }
                            else if (r == 0.5)
                            {
                                p.draws++;
                                bP.draws++;
                                Player.updateRatings(p, bP, true);
                            }
                            
                            
                        }
                    }
                }
            }
        }

        public void addPlayer(string fName, string lName, double rating=800)
        {
            Player newPlayer = new Player(fName, lName, rating);
            player.Add(newPlayer);
            addToFile(newPlayer);
        }

        public void removePlayer(string fName, string lName)
        {
            List<int> index = new List<int>();
            int count = 0;
            foreach (Player p in player)
            {
                if ((fName.CompareTo(p.firstName) == 0) && (lName.CompareTo(p.lastName) == 0))
                {
                    index.Add(count);
                }
                count++;
            }

            foreach (int i in index)
            {
                removeFromFile(player[i]);
                player.RemoveAt(i);
            }
        }

        public List<Player> rankPlayers()
        {
            List<Player> rankedList = player;
            rankedList.Sort();
            return rankedList;
        }

        public List<Game> getGames()
        {
            game.Sort();
            return game;
        }

        private void addToFile(Player aPlayer)
        {
            string line = aPlayer.firstName + "," + aPlayer.lastName + "," + aPlayer.wins.ToString() + "," + aPlayer.losses.ToString() +"," + aPlayer.draws.ToString() + "," + aPlayer.rating.ToString();

            System.IO.StreamWriter file = new System.IO.StreamWriter("players.csv", true);
            file.WriteLine(line);

            file.Close();
        }

        private void addGameToFile(Game g)
        {
            string line = g.whiteName + "," + g.blackName + "," + g.result.ToString() + "," + g.date.ToString();

            System.IO.StreamWriter file = new System.IO.StreamWriter("games.csv", true);
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

        private void loadFromFile(string fileString, string gamesFileString)
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

            string line2;
            string[] words2;

            System.IO.StreamReader file2 = new System.IO.StreamReader(gamesFileString);
            while((line2 = file2.ReadLine()) != null)
            {
                words2 = line2.Split(',');
                game.Add(new Game(words2[0], words2[1], Double.Parse(words2[2]), DateTime.Parse(words2[3])));
            }

            file2.Close();
        }
    }
}
