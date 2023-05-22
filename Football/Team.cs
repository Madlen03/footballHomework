using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Team
    {
        private Coach coach;
        private List<FootballPlayer> players;

        public Coach Coach
        {
            get { return coach; }
            set { this.coach = value; }
        }
        public List<FootballPlayer> Players
        {
            get { return players; }
            set 
            { 
                if(value.Count>=11||value.Count<=22)
                {
                    players = value;
                }
                else { throw new Exception("Играчите трябва да са между 11 и 12"); }
            }
        }

        public Team(Coach coach, List<FootballPlayer> players)
        {
            this.Coach = coach;
            this.players = players;
        }

        public double AvarageAge()
        {
            double sum = 0;
            foreach(FootballPlayer x in players)
            {
                sum += x.Age;

            }
            double avarage = sum / players.Count;
            return avarage;
        }

    }
}
