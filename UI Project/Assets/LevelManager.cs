﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    
    public void LoadLevel(string name)
    {

        Debug.Log("Level Load requested for: " + name);
        Application.LoadLevel(name);
    }

    public void QuitLevel()
    {
        
        Debug.Log("Level quit");
        Application.Quit();

    }

}
