﻿using UnityEngine;
using System.Collections;

public class ExampleBehaviorScript : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
