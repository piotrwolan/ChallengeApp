using ChallengeApp;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

User user1 = new User("Szymon", "321");  
User user2 = new User("Małgorzata", "321");
User user3 = new User("Zuzanna", "321");
User user4 = new User("Magdalena", "321");

user1.AddScore(5);
user1.AddScore(2);

var result = user1.Result;

Console.WriteLine(result);

var name = User.GameName;

//namespace ChallengeApp;

Employee employee1 = new Employee("Haber", "Wiesława", 65);
Employee employee2 = new Employee("Wolan", "Magdalena", 36);
Employee employee3 = new Employee("Wolan", "Maria", 10);

employee1.AddPoints(5);
employee1.AddPoints(2);
employee1.AddPoints(1);
employee1.AddPoints(3);
employee1.AddPoints(7);

int result1 = employee1.Points.Sum();


