using UnityEngine;
using System.Collections;

public abstract class SpecialEffects : ScriptableObject
{
    public ActiveSkillSO skill;
    public abstract void ApplySkillEffect(Unit catser, Unit target);
    public Stat GetResponsiveStat(Stat stat)
    {
	    switch(stat)
        {
            case Stat.Strength:
                return Stat.Defence;
            case Stat.Intelligence:
                return Stat.Resistance;
            case Stat.Defence:
                return Stat.Defence;
            case Stat.Resistance:
                return Stat.Resistance;
            default:
                return Stat.Defence;
        } 
    }
}

