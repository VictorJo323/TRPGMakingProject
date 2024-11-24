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
    Wisdom,
    Defence,
    Resistance,
    MoveRange,
    AtkRange,
}


///<summary>
/// Represents character or skill types.
///</summary>
public enum Type
{ 
    Assault,
    Counter,
    Grappling,
    Support,
}