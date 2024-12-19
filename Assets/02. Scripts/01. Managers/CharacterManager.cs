using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    List<Unit> playerUnits = new List<Unit>();

    private void AddUnitToPlayerUnits(Unit unit)
    {
        playerUnits.Add(unit);
    }
}
