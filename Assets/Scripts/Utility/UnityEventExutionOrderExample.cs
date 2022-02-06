using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityEventExutionOrderExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    private void Awake()
    {
        Debug.Log("awake");
    }

    private void OnEnable()
    {
        Debug.Log("on enable");
    }
}
