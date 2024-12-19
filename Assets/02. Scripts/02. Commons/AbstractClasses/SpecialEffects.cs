using UnityEngine;
using System.Collections;

public abstract class SpecialEffects : ScriptableObject
{
    public ActiveSkillSO skill;
    public abstract void ApplySkillEffect(Unit catser, Unit target);
}

