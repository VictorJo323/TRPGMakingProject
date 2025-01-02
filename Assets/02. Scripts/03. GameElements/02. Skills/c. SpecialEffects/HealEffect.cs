using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "SOSettings/Skills/SkillEffects/Heal", fileName = "Heal#", order = 1)]
public class HealEffect : SpecialEffects
{
    public override void ApplySkillEffect(Unit caster, Unit target)
    {
        int healAmount = CalculateHealAmount(caster);
        target.AdjustHealth(healAmount);
    }

    private int CalculateHealAmount(Unit caster)
    {
        int healAmount = 0;

        for (int i = 0; i < skill.stats.Length; i++)
        {
            Stat requiredStat = skill.stats[i];
            int stat = caster.GetStatValue(requiredStat);
            float requiredMultiplier = skill.multipliers[i];
            healAmount += Mathf.RoundToInt(stat * requiredMultiplier);
        }
        return healAmount;
    }
}

