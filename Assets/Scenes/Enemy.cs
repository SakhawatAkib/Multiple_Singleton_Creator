using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Singleton<Enemy>
{
    private void Awake()
    {
        Debug.Log("Enemy Called");
    }
}
