using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Goal
    {
        private FootballPlayer p;
        private int minute;
        public int Minute
        {
            get { return this.minute; }
            set { this.minute = value; }
        }
        public FootballPlayer Player
        {
            get { return this.p; }
            set { this.p = value; }
        }
        public Goal(int min, FootballPlayer f)
        {
            this.Minute = min;
            this.Player = f;
        }
    }
}
