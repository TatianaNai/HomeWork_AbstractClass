using HomeWork_AbstractClass;

Console.WriteLine("Write the name of the dog");

Dog dog = new Dog();
dog.SetName(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"The name of the dog is {dog.GetName()}.");
dog.Eat();

