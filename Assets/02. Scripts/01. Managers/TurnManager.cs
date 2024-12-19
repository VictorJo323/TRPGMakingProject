using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private bool isPlayerTurn;
    private Queue<Unit> enemyUnitsQueue = new Queue<Unit>();


    public void EnemyQueue(List<Unit> units)
    {
	     for(int i= 0; i<units.Count; i++)
        {
            enemyUnitsQueue.Enqueue(units[i]);
	    }
    }

    public void ChangeTurn()
    {
        if (isPlayerTurn)
            isPlayerTurn = false;
        else
            isPlayerTurn = true; 
    }
}
