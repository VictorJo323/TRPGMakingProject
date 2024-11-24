/*
 * GenericClasses.cs
 * 
 * Description:
 *     - Contains utility classes for efficient game development.
 *     - Includes:
 *         1. Singleton<T>: A generic MonoBehaviour singleton implementation.
 *         2. ObjectPool<T>: A generic object pooling system for reusable objects.
 * 
 * Author: VictorJ
 * Date: 2024-11-22
 * Version: 1.0
 */

using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Singleton<T>
/// 
/// A generic Singleton pattern implementation for MonoBehaviour classes.
/// Ensures that only one instance of the class exists throughout the application.
/// 
/// Usage:
///     - Derive from Singleton<T> in any MonoBehaviour.
///     - Access the instance using Singleton<T>.Instance.
/// </summary>
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();
                if (instance == null)
                {
                    GameObject singletonObject = new GameObject(typeof(T).Name);
                    instance = singletonObject.AddComponent<T>();
                    DontDestroyOnLoad(singletonObject);
                }
            }
            return instance;
        }
    }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}

/// <summary>
/// ObjectPool<T>
/// 
/// A generic object pooling class for efficient object reuse.
/// Provides a stack-based pool for managing reusable objects of type T.
/// 
/// Usage:
///     - Create an ObjectPool<T> instance.
///     - Use Get() to fetch an object from the pool.
///     - Use Return() to return an object to the pool.
/// 
/// Example:
///     ObjectPool<MyObject> pool = new ObjectPool<MyObject>();
///     MyObject obj = pool.Get();
///     pool.Return(obj);
/// </summary>
public class ObjectPool<T> where T : new()
{
    private readonly Stack<T> pool = new Stack<T>();

    public T Get()
    {
        return pool.Count > 0 ? pool.Pop() : new T();
    }

    public void Return(T obj)
    {
        pool.Push(obj);
    }
}
