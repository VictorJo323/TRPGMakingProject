using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeEffectiveness
{
    private readonly float[,] typeMatrix;

    public TypeEffectiveness()
    {
        typeMatrix = new float[,]
        {
            // Against Assault, Counter, Grappling, Support
            {1.0f, 0.5f, 1.2f, 1.0f},       // AssaultTypeMatrix
            {1.2f, 1.0f, 0.5f, 1.0f},       // CounterTypeMatrix
            {0.5f, 1.2f, 1.0f, 1.0f},       // GrapplingTypeMatrix
            {0.8f, 0.8f, 0.8f, 0.8f}        // SupportTypeMatrix
        };
    }

    public float GetTypeMultiplier(Type atkType, Type defType)
    {
        return typeMatrix[(int)atkType, (int)defType]; 
    }
}
