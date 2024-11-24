using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [Header("NON-MonoBehaviour Managerial Scripts")]
    public CharacterManager characterManager;
    public InventoryManager inventoryManager;
    public TurnManager turnManager;

    // Start is called before the first frame update ㄱ
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
