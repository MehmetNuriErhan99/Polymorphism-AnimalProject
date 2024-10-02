

namespace PolymorphismPet.Model;

public class Dog : Animal
{

    public bool Bite { get; set; }
    public override void Voice()
    {
        Console.WriteLine($"Name : {Name}, Type : {Type}, Age : {Age}, Price : {Price}, Does it Bite ? : {Bite} Voice : HAV HAV HAV HAV HAV HAV HAV HAV  ");
    }
}
