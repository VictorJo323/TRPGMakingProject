using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BuffOrDebuffEffect : ScriptableObject
{
    public abstract void ApplyEffect();
    public abstract void RemoveEffect();
}
