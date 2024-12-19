using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct StatRange
{
    public int minValue;
    public int maxValue; 
}

[CreateAssetMenu(menuName = "SOSettings/UnitSO", fileName = "UnitSO", order = 1)]
public class UnitSO : BaseData
{
    [Header("Initial Stat")]
    public int initHP;
    public int initSP;
    public int initATK;
    public int initDEF;
    public int initINT;
    public int initRES;
    public int moveRange;
    public int atkRange;
    public int critRate;

    [Header("Added Stats - min/max")]
    public StatRange lvupHP;
    public StatRange lvupSP;
    public StatRange lvupATK;
    public StatRange lvupDEF;
    public StatRange lvupINT;
    public StatRange lvupRES;

    /*[Header("Skills")]
    public SkillSO originalPassive;
    public List<SkillSO> availableSkills = new List<SkillSO>();
    */

    public int GetRandomStatIncrease(StatRange range)
    {
        return Random.Range(range.minValue, range.maxValue + 1);
    }
}
