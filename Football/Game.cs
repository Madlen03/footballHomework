using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Game
    {
        private Team team1, team2;
        private Referee referee, refereeAss1, refereeAss2;
        private List<Goal> goals;
        
        public Team Team1
        {
            get { return team1; }
            set 
            {
                if (value.Players.Count == 11)
                {
                    this.team1 = value;
                }
                else
                    throw new Exception("Играчите трябва да са 11");
            }
        }
        public Team Team2
        {
            get { return team2; }
            set
            {
                if (value.Players.Count == 11)
                {
                    this.team2 = value;
                }
                else
                    throw new Exception("Играчите трябва да са 11");
            }
        }
        public Referee Referee
        {
            get { return this.referee; }
            set { this.referee = value; }
        }
        public Referee RefereeAss1
        {
            get { return this.refereeAss1; }
            set { this.refereeAss1 = value; }
        }
        public Referee RefereeAss2
        {
            get { return this.refereeAss2; }
            set { this.refereeAss2 = value; }
        }
        public void Goal(int minute, FootballPlayer player)
        {
            goals.Add(new Goal(minute, player));
        }
        public void GameResult()
        {
            int counterTeam1=0, counterTeam2 = 0;
            foreach (var x in goals)
            {
                if (Team1.Players.Contains(x.Player))
                {
                    counterTeam1++;
                }
                if (Team2.Players.Contains(x.Player))
                {
                    counterTeam2++;
                }
            }
            Console.WriteLine($"Отбор 1 има {counterTeam1} вкарани голове");
            Console.WriteLine($"Отбор 2 има {counterTeam2} вкарани голове");
        }
        public void Winner()
        {
            int counterTeam1 = 0, counterTeam2 = 0;
            foreach (var x in goals)
            {
                if (Team1.Players.Contains(x.Player))
                {
                    counterTeam1++;
                }
                if (Team2.Players.Contains(x.Player))
                {
                    counterTeam2++;
                }
            }
            if(counterTeam1 == counterTeam2)
            {
                Console.WriteLine("Отборите са с равен брой голове");
            }
            else
            {
                if(counterTeam1 < counterTeam2)
                {
                    Console.WriteLine("Отбор 2 печели");

                }
                else
                {
                    Console.WriteLine("Отбор 1 печчели");
                }
            }
        }
        public Game(Team team1, Team team2, Referee referee, Referee referee1, Referee referee2)
        {
            goals = new List<Goal>();
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            RefereeAss1 = referee1;
            RefereeAss2 = referee2;
        }
    }
}
