/*
 * EnumDefinitions.cs
 * 
 * Description:
 *     - Contains common enums used across the project.
 *     - Centralized management of all enumeration types.
 * 
 * Author: [VictorJ]
 * Date: [2024-11-23]
 */


/// <summary>
/// Represents character stats.
/// </summary>
public enum Stat
{
    Health,
    Mana,
    Strength,
    Intelligence,
    Defence,
    Resistance,
    MoveRange,
    AtkRange,
    CritRate,
}


///<summary>
/// Represents character or skill types.
///</summary>
public enum Type
{ 
    Assault = 0,
    Counter = 1,
    Grappling = 2,
    Support = 3,
}

public enum TargetType
{
    Self,
    Ally,
    Enemy,
    Location, 
}


public enum Buffs
{
    ATKup,                  // Encreases ATK stat for n%
    INTup,                   // Encreases INT stat for n%
    DEFup,                  // Encreases DEF stat for n%
    RESup,                  // Encreases RES stat for n%
    Haste,                   // Encreases Move range (int)
    CritRateUp,           // Encreases Crit rate (int)
    Enchanted,            // Adds specific fixed date
    Blessed,                 // Heals when turn ends
    Divinity,                 // Heals when get hit
}


public enum Debuffs
{
    ATKdown,
    INTdown,            
    DEFdown,
    RESdown,            // Decreases designated stats
    Slow,                   // Decreases move range
    Bleeding,             // Decreases current HP by %
    Ignited,                // Deals additional fixed damage when hit by other "Fiery" skills.
    Frostbite,            // Deals additional fixed damage when hit by other "Glacial" skills and then turns into "Frozen"
    Frozen,                // Stops the target unit from acting during their next turn. Prolongs when hit by other "Glacial" skills
    Electrified,           // Deals additional fixed damage when hit by other "Electric" skills.
    Stun,                    // Stops the target unit from acting during their next turn. Lasts for 1 turn.
    Sleep,                   // Stops the target unit from acting during their next turn, but disappears when hit for the first time.
    Blind,                    // Decreases attack range. 
}