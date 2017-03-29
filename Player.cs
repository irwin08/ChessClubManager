using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessClubManager
{
    class Player
    {
        //private members
       
        private string _firstName;
        private string _lastName;

        private double _rating;


        //properties

        public string firstName 
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string lastName 
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public double rating
        {
            get 
            {
                return _rating;
            }
            set
            {
                _rating = value;
            }
        }

        //public methods

        public Player(string fName, string lName, double rating)
        {
            _firstName = fName;
            _lastName = lName;
            _rating = rating;
        }

        public static void updateRatings(Player winner, Player loser, bool draw)
        {
            double kFactor = 32;

            double winnerTransformedRating = Math.Pow(10, (winner.rating/400));
            double loserTransformedRating = Math.Pow(10, (loser.rating / 400));

            double winnerExpectedScore = winnerTransformedRating / (winnerTransformedRating + loserTransformedRating);
            double loserExpectedScore = loserTransformedRating / (winnerTransformedRating + loserTransformedRating);

            double winnerScore;
            double loserScore;

            if (!draw)
            {
                winnerScore = 1;
                loserScore = 0;
            }
            else
            {
                winnerScore = 0.5;
                loserScore = 0.5;
            }

            double updatedWinnerRating = winner.rating + (kFactor * (winnerScore - winnerExpectedScore));
            double updatedLoserRating = loser.rating + (kFactor * (loserScore - loserExpectedScore));

            winner.rating = updatedWinnerRating;
            loser.rating = updatedLoserRating;
        }

    }
}
