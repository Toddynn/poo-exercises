using System;
namespace animal;
class Program {

    static void Main(string[] args){
        Dog dog = new Dog(9);
        Cat cat = new Cat(9);

        dog.age_changed += animal_changed_age;
        cat.age_changed += animal_changed_age;
    }

    static void animal_changed_age(string name, int new_age){
        Console.WriteLine($"Age of {name} changed to {new_age}");
    }
}