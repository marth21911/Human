using System;

namespace Human{

class Human 
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;

    public int takeDmg(Human target)
    {
        Console.WriteLine($"An attack! {target} lost 10 hp!");
        this.health -= 10;
        Console.WriteLine($"{target.Name} now has {this.health} hit points!"); 
        return(this.health);
    }
    public Human(string name)
    {
        Name = name;
        Strength = 5;
        Intelligence = 5;
        Dexterity = 5;
        health = 50;
    }
    public Human(string n, int s, int i, int d, int h)
    {
        Name = n;
        Strength = s;
        Intelligence = i;
        Dexterity = d;
        health = h;
    }
    public int hp
    {
        get{
            return (health);
        }
    }

}
}
