﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botoes : MonoBehaviour
{
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(camera.transform.position);
    }
}
