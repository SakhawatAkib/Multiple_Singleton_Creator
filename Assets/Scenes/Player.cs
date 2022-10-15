using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player>
{
    private void Awake()
    {
        Debug.Log("Player");
    }
}
