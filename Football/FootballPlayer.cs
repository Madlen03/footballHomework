using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace Football
{
    public class FootballPlayer : Person
    {
        public int Number { get; }
        public double Height { get; }

        public FootballPlayer(string name,int number,int age, double height) : base(name, age)
        {
            this.Number = number;
            this.Height = height;

        }
    }
}
