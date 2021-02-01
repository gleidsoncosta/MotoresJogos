using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float vel = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1.0F, 1.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*vel);
        transform.Rotate(new Vector3(0.0f, 0.0f, 5.0f)*Time.deltaTime);
    }
}
