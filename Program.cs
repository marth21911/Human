using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human sariah = new Human("Sariah");
            Human guinevere = new Human("Guinevere", 3,5,2,1000);
            Console.WriteLine ($"My name is {sariah.Name} and chemistry is my game");
            Console.WriteLine ($"My name is {guinevere.Name} and you'll never beat me cause I have {guinevere.hp} hit points!");
            guinevere.takeDmg(guinevere);
        }
    }
}
