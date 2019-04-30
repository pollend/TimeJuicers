﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinFlag : MonoBehaviour
{
    public SceneController scene;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "player")
        {
            scene.NextLevel();
        }
    }
}
