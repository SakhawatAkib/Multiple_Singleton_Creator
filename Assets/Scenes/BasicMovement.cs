using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : Singleton<BasicMovement>
{
    protected override void Awake()
    {
        base.Awake();
        Debug.Log("Basic Movement");
    }
}
