using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitDatabase : DatabaseSO<UnitSO>
{
    public List<UnitSO> attackerTypeUnits;
    public List<UnitSO> counterTypeUnits;
    public List<UnitSO> grapplingTypeUnits;
    public List<UnitSO> supportTypeUnits;

    public string attackerUnitPath = "ScriptableObjects/01. Units/A. AssaultType";
    public string counterUnitPath = "ScriptableObjects/01. Units/B. CounterType";
    public string grapplingUnitPath = "ScriptableObjects/01. Units/C. GrapplingType";
    public string supportUnitPath = "ScriptableObjects/01. Units/D. SupportType"; 
}
