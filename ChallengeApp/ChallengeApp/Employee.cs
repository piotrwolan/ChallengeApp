using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        private List<int> points = new List<int>();
        public Employee(string surname, string name, int age)
        {
            this.Surname = surname;
            this.Name = name;
            this.Age = age;
        }
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }


        public List<int> Points { get { return points;} }

        public void AddPoints(int points)
        {
            this.points.Add(points);
        }

    }
}
