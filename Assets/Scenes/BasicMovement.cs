using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : DontDestroySingleton<BasicMovement>
{
    private void Awake()
    {
        Debug.Log("Basic Movement");
    }
}
