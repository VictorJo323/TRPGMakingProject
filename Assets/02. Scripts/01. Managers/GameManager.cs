using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [Header("NON-MonoBehaviour Managerial Scripts")]
    private CharacterManager characterManager;
    private InventoryManager inventoryManager;
    private TurnManager turnManager;
    private TypeEffectiveness typeEffectiveness;

    public CharacterManager CharacterManager
    {
        get
        {
            if (characterManager == null)
            {
                characterManager = new CharacterManager(); // 비-MonoBehaviour 클래스의 인스턴스 생성
            }
            return characterManager;
        }
    }

    public InventoryManager InventoryManager
    {
        get
        {
            if (inventoryManager == null)
            {
                inventoryManager = new InventoryManager(); // 비-MonoBehaviour 클래스의 인스턴스 생성
            }
            return inventoryManager;
        }
    }

    public TurnManager TurnManager
    {
        get
        {
            if (turnManager == null)
            {
                turnManager = new TurnManager(); // 비-MonoBehaviour 클래스의 인스턴스 생성
            }
            return turnManager;
        }
    }

    public TypeEffectiveness TypeEffectiveness
    {
        get
        {
            if (typeEffectiveness == null)
            {
                typeEffectiveness = new TypeEffectiveness(); // 비-MonoBehaviour 클래스의 인스턴스 생성
            }
            return typeEffectiveness;
        }
    }
}
