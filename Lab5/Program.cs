using System;

// Step 1 - Create Base Class
class Animal
{
    // Vritual method that can be overridden by derived classes
    public virtual void AnimalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Step 2 - Create Derived Classes 
class Cat : Animal
{
// Override the base class method 
public override void AnimalSound()
{
Console.WriteLine("The car says: meow");
}
}

class Dog : Animal
{
// Override the base class method 
public override void AnimalSound()
{
Console.WriteLine("The dog says: bow wow");
}
}

class program
{
    staric void Main()
    {

        // Srep 3 - Test in Main()
        // Create objects using Animal as refrence type 
        Animal myAnimal = new Animal(); // Base class object
        Animal mycat = new Cat(); // Cat object with Animal reference
        Animal myDog = new Dog(); // Dog object with Animal teverence

        // Call the same method on different object
        myAnimal.AnimalSound(); // Output: "The animal makes a sound"
        myCat.AnimalSound(); // Output: "The cat says: meow"
        myDog.AnimalSound(); // Output: "The dog says: bow wow"
    }
}
