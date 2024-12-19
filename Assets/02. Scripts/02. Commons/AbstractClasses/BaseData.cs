using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseData : ScriptableObject
{
    [Header("Identifier")]
    public int id;
    public Type type;
    public string callSign;
    public string description;
}
