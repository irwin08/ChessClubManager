using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessClubManager
{
    class ChessClubManager
    {
        List<Player> player = new List<Player>(); 


        public void addPlayer(string fName, string lName, double rating=800)
        {
            player.Add(new Player(fName, lName, rating));
        }

        public void removePlayer(string fName, string lName)
        {
            for (int i = 0; i < player.Count; i++)
            {
                if ((player[i].firstName.Equals(fName)) && (player[i].lastName.Equals(lName)))
                {
                    player.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Player> rankPlayers()
        {
            List<Player> rankedList = player;
            rankedList.Sort();
            return rankedList;
        }
    }
}
