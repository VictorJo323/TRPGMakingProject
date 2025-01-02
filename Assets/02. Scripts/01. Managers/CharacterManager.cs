using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private PlayerUnitDatabase unitDatabase;

    List<Unit> playerUnits = new List<Unit>();

    private void AddUnitToPlayerUnits(Unit unit)
    {
        playerUnits.Add(unit);
    }

    public void CreatePlayerUnitDatabase()
    {
        unitDatabase = ScriptableObject.CreateInstance<PlayerUnitDatabase>();
    }

    public  UnitSO SelectTypeUnit(Type type)
    {
        switch (type)
        {
            case Type.Assault:
                return unitDatabase.GetRandomItem(unitDatabase.attackerTypeUnits);
            case Type.Counter:
                return unitDatabase.GetRandomItem(unitDatabase.counterTypeUnits);
            case Type.Grappling:
                return unitDatabase.GetRandomItem(unitDatabase.grapplingTypeUnits);
            case Type.Support:
                return unitDatabase.GetRandomItem(unitDatabase.supportTypeUnits);
            default:
                return null;
        }
    }

    private void UnloadPlayerUnitDatabase()
    {
        if (unitDatabase != null)
            unitDatabase = null; 
    }

    private Unit CreatePlayerUnit(UnitSO unitSO)
    {
        Unit unitToCreate = new Unit();
        unitToCreate.unitInfo = unitSO;
        return unitToCreate;
    }

    public  void CreateRandomTeam()
    {
        if (unitDatabase == null)
            CreatePlayerUnitDatabase();
        playerUnits.Clear();
        UnitSO assault = SelectTypeUnit(Type.Assault);
        //AddUnitToPlayerUnits(CreatePlayerUnit(assault));
        UnitSO counter = SelectTypeUnit(Type.Counter);
        //AddUnitToPlayerUnits(CreatePlayerUnit(counter));
        UnitSO grappling = SelectTypeUnit(Type.Grappling);
        //AddUnitToPlayerUnits(CreatePlayerUnit(grappling));
        UnitSO support = SelectTypeUnit(Type.Support);
        //AddUnitToPlayerUnits(CreatePlayerUnit(support));
        Debug.Log($"{assault.id} loaded");
        Debug.Log($"{counter.id} loaded");
        Debug.Log($"{grappling.id} loaded");
        Debug.Log($"{support.id} loaded");
    }

    public  void RestartSelectedTypeUnit(Type type)
    { 
        switch(type)
        {
            case Type.Assault:
                if (playerUnits[0] != null)
                    playerUnits[0] = null;
                UnitSO assault = SelectTypeUnit(Type.Assault);
                //AddUnitToPlayerUnits(CreatePlayerUnit(assault));
                Debug.Log($"{assault.id} loaded");
                break;
            case Type.Counter:
                if (playerUnits[1] != null)
                    playerUnits[1] = null;
                UnitSO counter = SelectTypeUnit(Type.Counter);
                //AddUnitToPlayerUnits(CreatePlayerUnit(counter));
                Debug.Log($"{counter.id} loaded");
                break;
            case Type.Grappling:
                if (playerUnits[2] != null)
                    playerUnits[2] = null;
                UnitSO grappling = SelectTypeUnit(Type.Grappling);
                //AddUnitToPlayerUnits(CreatePlayerUnit(grappling));
                Debug.Log($"{grappling.id} loaded");
                break;
            case Type.Support:
                if (playerUnits[3] != null)
                    playerUnits[3] = null;
                UnitSO support = SelectTypeUnit(Type.Support);
                //AddUnitToPlayerUnits(CreatePlayerUnit(support));
                Debug.Log($"{support.id} loaded");
                break;
            default:
                break;
	    }
    }
}
