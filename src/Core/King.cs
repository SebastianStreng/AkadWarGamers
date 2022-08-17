namespace Core;

public class King
{
    public King(
        string name,
        double warriors,
        double strength,
        double weapon_strength,
        double armor_strength)
    {
        this.name = name;
        this.warriors = warriors;
        this.strength = strength;
        this.weapon_strength = weapon_strength;
        this.armor_strength = armor_strength;
    }

    public string name { get; set; }
    public double warriors { get; set; }
    public double strength { get; set; }
    public double weapon_strength { get; set; }
    public double armor_strength { get; set; }

    public void attack(King king, int damageStrength)
    {
        king.warriors = king.warriors * 0.7;
        Console.WriteLine($"{this.name} has attacked {king.name}´s armee. " +
            $"\n {king.name} has now {king.warriors} warriors left.");
    }
}