﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoMov : MonoBehaviour
{   
    public Vector3 vel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vel*Time.deltaTime);
    }
}
