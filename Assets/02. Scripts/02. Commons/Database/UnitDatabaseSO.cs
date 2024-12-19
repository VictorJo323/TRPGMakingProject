using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Unit Database", menuName = "SOSettings/Unit Database", order = 0)]
public class UnitDatabaseSO : DatabaseSO<UnitSO>
{
    public List<UnitSO> assaultTypeUnits;
    public List<UnitSO> counterTypeUnits;
    public List<UnitSO> grapplingTypeUnits;
    public List<UnitSO> supportTypeUnits;

    public string assaultTypePath = "ScriptableOjects/01. Units/A. AssaultType";
    public string counterTypePath = "ScriptableObjects/01. Units/B. CounterType";
    public string grapplingTypePath = "ScriptableObjects/01. Units/C. GrapplingType";
    public string supportTypePath = "ScriptableObjects/01. Units/D. SupportType";

    private void OnEnable()
    {
        assaultTypeUnits = LoadItemFromResources(assaultTypePath);
        counterTypeUnits = LoadItemFromResources(counterTypePath);
        grapplingTypeUnits = LoadItemFromResources(grapplingTypePath);
        supportTypeUnits = LoadItemFromResources(supportTypePath);
    }

    public UnitSO GetRandomAssaultTypeUnit()
    {
        if (assaultTypeUnits.Count != 0)
        {
            int index = Random.Range(0, assaultTypeUnits.Count);
            return assaultTypeUnits[index];
        }
        return null;
    }


    public UnitSO GetRandomCounterTypeUnit()
    {
	if(counterTypeUnits.Count != 0)
        {
            int index = Random.Range(0, counterTypeUnits.Count);
            return counterTypeUnits[index]; 
	    }
        return null;
    }
}
