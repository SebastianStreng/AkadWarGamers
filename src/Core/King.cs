namespace Core;

/**   Die King-Klasse stellt die Klasse dar, von der im Spielverlauf die Instanzen "König" gebildet werden können .
 *  Hierbei werden die Eigenschaften und der Konstruktor gesetzt.
 */

public class King
{
    /** Konstruktor mit den definierten Eigenschaften
     */

    public King(
        string name,
        int warriors,
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

    /**Eigenschaften
    */
    public string name { get; set; }

    public int warriors { get; set; }
    public double strength { get; set; }
    public double weapon_strength { get; set; }
    public double armor_strength { get; set; }
}