using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player>
{
    protected override void Awake()
    {
        base.Awake();
        Debug.Log("Player");
    }
}
