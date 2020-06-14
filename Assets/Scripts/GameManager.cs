using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    private int octaves = 1;

    public static GameManager GetInstance()
    {
        return instance; 
    } 

    // Use this for initialization
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    public void setOctaves(int octaves)
    {
        Debug.Log(octaves);
        Debug.Log(this.octaves);
        this.octaves = Math.Min(3, Math.Max(0, octaves));
    }

    public int getOctaves()
    {
        return octaves;
    }
}
