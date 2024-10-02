

using System;

namespace PolymorphismPet.Model;

public class Horse : Animal
{
    public bool BackFire { get; set; }
    public override void Voice()
    {
        Console.WriteLine($"Name : {Name}, Type : {Type}, Age : {Age}, Price : {Price}, Does it Bite ? : {BackFire} Voice : IHW IHW IHW IHW IHW IHW IHW IHW ");

    }
}
