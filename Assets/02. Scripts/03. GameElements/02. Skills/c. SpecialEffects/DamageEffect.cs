using System.Collections.Generic;
using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "SOSettings/Skills/SkillEffects/Damage", fileName = "Damage#", order = 0)]
public class DamageEffect : SpecialEffects
{
    public override void ApplySkillEffect(Unit caster, Unit target)
    {
        float typeMultiplier = GameManager.Instance.TypeEffectiveness.GetTypeMultiplier(caster.GetUnitType(), target.GetUnitType());
        int damageAmount = CalculateDamage(caster, target, typeMultiplier);
        target.AdjustHealth(-damageAmount);
    }

    private int CalculateDamage(Unit caster, Unit target, float typeMultiplier)
    {
        int damageAmount = 0;
        if (skill.isFixedDamage)
        {
            for (int i = 0; i < skill.stats.Length; i++)
            {
                Stat damageStat = skill.stats[i];
                int damageStatValue = caster.GetStatValue(damageStat);
                damageAmount += Mathf.RoundToInt(damageStatValue * skill.multipliers[i]);
            }
        }
        else
        {
            for(int i = 0; i < skill.stats.Length; i++)
            {
                Stat damageStat = skill.stats[i];
                int damageStatValue = caster.GetStatValue(damageStat);

                Stat responsiveStat = GetResponsiveStat(damageStat);
                int targetDefense = target.GetStatValue(responsiveStat);
                float effectiveDefense = targetDefense * skill.defenseMultiplier;

                damageAmount += Mathf.RoundToInt((damageStatValue - effectiveDefense) * skill.multipliers[i]);
	        }

            float randomFactor = Random.Range(skill.randomFactorMin, skill.randomFactorMax);
            damageAmount = Mathf.RoundToInt(damageAmount * randomFactor);
        }
        damageAmount = Mathf.RoundToInt(damageAmount * typeMultiplier);
        return Mathf.Max(1, damageAmount);
    }
}
