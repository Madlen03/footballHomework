using System.Collections.Generic;
using System;


namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team1;
            Team team2;
            Random ran = new Random();
            Console.WriteLine("Нашата футболна игра започва!");
            Console.WriteLine("Моля въведете колко мача искате да бъдат изиграни!");
            int countGames = int.Parse(Console.ReadLine());
            for(int i = 0; i < countGames; i++)
            {
                Console.WriteLine("Започва игра {0}, нека да съставим първия отбор",i+1);
                team1 = new Team(enterCoach(), enterPlayers());
                Console.WriteLine("Състав на втори отбор: ");
                team2 = new Team(enterCoach(), enterPlayers());
                Game game = new Game(team1, team2, enterReferee(), enterAssistantReferee(), enterAssistantReferee());
                Console.WriteLine("Старт на играта");

                for (int j = 0; j < 11; j++)
                {
                    int teamToScore = ran.Next(2) + 1;
                    if (teamToScore == 1)
                    {
                        int randomPlayer = ran.Next(11);
                        FootballPlayer ranFootballPlayer = team1.Players[randomPlayer];
                        int randomMinutes = ran.Next(90);
                        Console.WriteLine("{0} от отбор 1 вкара гол в {1} минута",ranFootballPlayer.Name,randomMinutes);
                        game.Goal(randomMinutes,ranFootballPlayer);
                    }
                    else
                    {
                        int randomPlayer = ran.Next(11);
                        FootballPlayer ranFootballPlayer = team2.Players[randomPlayer];
                        int randomMinutes = ran.Next(90);
                        Console.WriteLine("{0} от отбор 2 вкара гол в {1} минута",ranFootballPlayer.Name,randomMinutes);
                        game.Goal(randomMinutes,ranFootballPlayer);
                    }
                }
                 game.GameResult();
                 game.Winner();
                Console.WriteLine("Край на играта");
            }



        }
        public static Coach enterCoach()
        {
            Console.Write("Въведете кой ще бъде треньор на отборa:\nИме: ");
            string coachName = Console.ReadLine();
            Console.Write("Години: ");
            int coachAge = int.Parse(Console.ReadLine());
            Coach coach = new Coach(coachName, coachAge);
            return coach;
        }

        public static List<FootballPlayer> enterPlayers()
        {
            List<FootballPlayer> fpList = new List<FootballPlayer>();
            Console.WriteLine("Въведете вашите играчи: ");
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine("Въведете играч {0}", i + 1);
                Console.Write("Име: ");
                string name = Console.ReadLine();
                Console.Write("Години: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Номер: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Височина: ");
                double height = double.Parse(Console.ReadLine());
                FootballPlayer fbP = new FootballPlayer(name, number, age, height);
                fpList.Add(fbP);
            }
            return fpList;
        }

        public static Referee enterReferee()
        {
            Console.WriteLine("Въведете рефер:");
            Console.Write("Въведете име на рефер:");
            string name = Console.ReadLine();
            Console.Write("Въведете години на рефер:" );
            int age = int.Parse(Console.ReadLine());
            Referee referee = new Referee(name,age);
            return referee;
        } 

        public static Referee enterAssistantReferee()
        {
            Console.Write("Въведете име на асистент:");
            string name = Console.ReadLine();
            Console.Write("Въведете години на асистент:");
            int age = int.Parse(Console.ReadLine());
            Referee assistent = new Referee(name, age);
            return assistent;
        }
    }
}
