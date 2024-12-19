using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLvupProcess : MonoBehaviour
{
    public Unit unit;

    public void LvupTestUnit()
    {
        unit.ApplyLvupStat();
    }
}
