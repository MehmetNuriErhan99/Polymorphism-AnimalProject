

using PolymorphismPet.Model;

Animal animal = new Bird()
{ 

Name = "Osman",
Age = 24,
Type = "Mongolian",
Price = 100.000,
Beaks = true,

};

if (animal.GetType() == typeof(Horse))
{
    Console.WriteLine("Horse");
    animal.Voice();
}
else if (animal.GetType() == typeof(Cat))
{
    Console.WriteLine("Cat");
    animal.Voice();
}
else if (animal.GetType() == typeof(Dog))
{
    Console.WriteLine("Dog");
    animal.Voice();
}
else if (animal.GetType() == typeof(Bird))
{
    Console.WriteLine("Bird");
    animal.Voice();
}

