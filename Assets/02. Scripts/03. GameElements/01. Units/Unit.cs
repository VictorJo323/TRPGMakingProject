using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private UnitSO unitInfo;

    public int level;
    private Type type;
    private int maxLevel = 100;
    private float baseExp = 100f;
    
    private int curHP;
    private int maxHP;

    private int curSP;
    private int maxSP;
    
    private int curATK;
    private int curDEF;
    private int curINT;
    private int curRES;
    private int curMoveRange;
    private int curATKRange;
    private int curCritRate;
    private int exp;
    private int expCap;
    private int initExpCap = 100;
    
    [SerializeField] private AnimationCurve expCurve;

    // Start is called before the first frame update
    void Start()
    {
        level = 1;                                 // Needs to be updated when data save is implemented.
        type = unitInfo.type;
        curHP = unitInfo.initHP;        // Needs to be updated when data save is implemented.
        maxHP = unitInfo.initHP;      // Needs to be updated when data save is implemented.
        curSP = unitInfo.initSP;         // Needs to be updated when data save is implemented.
        maxSP = unitInfo.initSP;       // Needs to be updated when data save is implemented.
        curATK = unitInfo.initATK;    // Needs to be updated when data save is implemented.
        curINT = unitInfo.initINT;      // Needs to be updated when data save is implemented.
        curDEF = unitInfo.initDEF;    // Needs to be updated when data save is implemented.
        curRES = unitInfo.initRES;    // Needs to be updated when data save is implemented.
        curMoveRange = unitInfo.moveRange;   // Needs to be updated when data save is implemented.
        curATKRange = unitInfo.atkRange;         // Needs to be updated when data save is implemented.
        curCritRate = unitInfo.critRate;               // Needs to be updated when data save is implemented.
        expCap = initExpCap;
    }

    public Type GetUnitType()
    {
        return type; 
    }
    public int GetStatValue(Stat stat)
    {
	    switch(stat)
        {
            case Stat.Strength:
                return curATK;
            case Stat.Intelligence:
                return curINT;
            case Stat.Defence:
                return curDEF;
            case Stat.Resistance:
                return curRES;
            case Stat.Health:
                return curHP;
            case Stat.Mana:
                return curSP;
            case Stat.CritRate:
                return curCritRate;
            default:
                return 0; 
	    } 
    }
    
    public void AddExp(int addedExp)
    {
        exp += addedExp;
        while(exp >= expCap)
        {
            exp -= expCap;
            ApplyLvupStat();
	    }
    }

    public int GetNewExpCap()
    {
        if(level == 1)
        {
            return initExpCap; 
	    }
        float normalizedLevel = (float)level / maxLevel;
        float curveValue = expCurve.Evaluate(normalizedLevel);

        float tempCap = curveValue * baseExp;
        int expCap = Mathf.RoundToInt(tempCap * 100);
        return expCap+initExpCap;
    }
    
    public void ApplyLvupStat()
    {
        Debug.Log($"Current level:{level}, current expCap: {expCap}");
        level += 1;

        Debug.Log("LVUP!");

        int hpToAdd = unitInfo.GetRandomStatIncrease(unitInfo.lvupHP);
        int spToAdd = unitInfo.GetRandomStatIncrease(unitInfo.lvupSP);
        curHP += hpToAdd;
        maxHP += hpToAdd;
        curSP += spToAdd;
        maxSP += spToAdd;
        curATK += unitInfo.GetRandomStatIncrease(unitInfo.lvupATK);
        curDEF += unitInfo.GetRandomStatIncrease(unitInfo.lvupDEF);
        curINT += unitInfo.GetRandomStatIncrease(unitInfo.lvupINT);
        curRES += unitInfo.GetRandomStatIncrease(unitInfo.lvupRES);

        expCap = GetNewExpCap();
        Debug.Log($"Current level:{level}, current expCap: {expCap}");
    }
    
    public void TakeDamage(int damageAmount)
    {
        curHP = Mathf.Clamp(curHP - damageAmount, 0, maxHP);
        
        if(curHP<=0)
        {
            OnDeath(); 
	    }
    }

    private void OnDeath()
    {
    }
}
