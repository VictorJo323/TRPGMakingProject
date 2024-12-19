using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SavedData
{
    public int slotNo;
    public int[] unitIDs; //new int[4];
    public UnitInfo[] unitStats;
}

public struct UnitInfo
{
    public int curLevel;
    public int curExp;
    public int curHp;
    public int maxHp;
    public int curSp;
    public int maxSp;
    public int curStr;
    public int curDef;
    public int curInt;
    public int curRes;
}

public class DataManager : MonoBehaviour
{
    public int maxSaveSlot = 4;
    public SavedData[] savedJsonData = new SavedData[4];
    public int[] unitIDs = new int[4];
    public UnitSO[] unitSOs = new UnitSO[4];

    private void Start()
    {
        
    }

    private string GetFilePath(int slotIndex)
    {
	    return Application.persistentDataPath + "/gameData" + slotIndex + ".json";
    }

    public void SaveData(int slotIndex)
    {
        string json = JsonUtility.ToJson(savedJsonData[slotIndex], true);
        System.IO.File.WriteAllText(GetFilePath(slotIndex), json);
        Debug.Log($"Data saved to slot {slotIndex}");
    }

    public void LoadData(int slotIndex)
    {
        string filePath = GetFilePath(slotIndex);
        if(System.IO.File.Exists(filePath))
        {
            string json = System.IO.File.ReadAllText(filePath);
            savedJsonData[slotIndex] = JsonUtility.FromJson<SavedData>(json);
            Debug.Log($"Data loaded from slot {slotIndex}");
        }
        else
        {
            Debug.Log("NO DATA TO LOAD"); 
	    }
    }

    private void FillUnitList()
    {
        UnitDatabaseSO unitDatabase = new UnitDatabaseSO();  // need revision;
	    if(unitIDs!= null)
        {
            for(int i = 0; i <4; i++)
            {
                UnitSO unitToEnter = unitDatabase.GetById(unitIDs[i]);
                unitSOs[i] = unitToEnter;
	        }
	    } 
    }
}
