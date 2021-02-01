﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour
{
    public Vector3 vel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vel * Time.deltaTime);
        
        if(transform.position.z < -9.0f){
            float repos = 45.0f - (-9.0f - transform.position.z);
            transform.position = new Vector3(transform.position.x, transform.position.y, repos);
        }
    }
}
