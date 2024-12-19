using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SkillData : ScriptableObject
{
    public int ID;
    public string skillName;
    public string skillDescription;
    public Sprite skillIcon;
}
