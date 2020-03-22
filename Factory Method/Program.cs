using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("OOO Brick Story");
            House house2 = dev.Create();

            dev = new WoodDeveloper("Private developer");
            House house = dev.Create();

            Console.ReadLine();
        }
    }
    // абстрактний клас будівельної компанії
    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }
        // фабричний метод
        abstract public House Create();
    }
    // строїть панельні будинки
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
    // строїть дерев'яні будинки
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }

    abstract class House
    { }

    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("The panel house was built");
        }
    }
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("A wooden house was built");
        }
    }
}
