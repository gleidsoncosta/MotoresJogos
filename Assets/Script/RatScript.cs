using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatScript : MonoBehaviour
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

        if(transform.position.z < -9.0f || transform.position.x >=7.0f){
            transform.position = new Vector3(-7.8f, 0.0f, 24.9f);
        }
    }
}
