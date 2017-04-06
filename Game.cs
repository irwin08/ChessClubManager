using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessClubManager
{
    public class Game
    {
        private DateTime _date;
        private string _whiteName;
        private string _blackName;

        //1=whitewin 0=blackwin 0.5=draw
        private double _result;

        public DateTime date
        {
            set
            {
                _date = value;
            }
            get
            {
                return date;
            }
        }

        public string whiteName
        {
            set
            {
                _whiteName = value;
            }
            get
            {
                return _whiteName;
            }
        }

        public string blackName
        {
            set
            {
                _blackName = value;
            }
            get
            {
                return _blackName;
            }
        }

        public double result
        {
            set
            {
                _result = value;
            }
            get
            {
                return _result;
            }
        }

        public Game(string wName, string bName, double r, DateTime d)
        {
            _whiteName = wName;
            _blackName = bName;
            _result = r;
            _date = d;
        }
    }
}
