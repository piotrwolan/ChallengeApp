string name = "Ewa";
bool isFemale = true;
int age = 61;

if (isFemale == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }

if (isFemale == false && age < 18)
{ 
    Console.WriteLine("Niepełnoletni mężczyzna");
}

if (isFemale == true && age >=60)
{
    Console.WriteLine("Kobieta osiągnęła wiek emerytalny");
}
