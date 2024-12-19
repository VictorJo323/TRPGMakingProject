using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "SOSettings/Skills/ActiveSkill", fileName = "ActiveSkill#", order = 0)]
public class ActiveSkillSO : SkillData
{
	public Type skillType;
	public TargetType targetType;
	public int castRange;
	public int effectRange;
	public Stat[] stats;
	public float[] multipliers;
	public int coolDown;
	public SpecialEffects[] effects;
	public bool isFixedDamage;

	public float defenseMultiplier = 1f;
	public float randomFactorMin = 0.9f;
	public float randomFactorMax = 1.1f;
	public float sameTypeBonus = 1.2f;


	public void ExecuteSkill(Unit caster, Unit target)
	{
		foreach (SpecialEffects effect in effects)
		{
			effect.skill = this;
			effect.ApplySkillEffect(caster, target); 
		}
    }
}

