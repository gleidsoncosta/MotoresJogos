using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Vector3 vel;
    public Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Physics.gravity = new Vector3(0.0f, -9.81f, 0.0f) * 8.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.LeftArrow)){
            if(transform.position.x >= -1.85f){
                transform.Translate(Vector3.left * Time.deltaTime * 10.0f);
            }
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            if(transform.position.x <= 1.85f){
                transform.Translate(Vector3.right * Time.deltaTime * 10.0f);
            }
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            _rigidbody.velocity = new Vector3(0.0f, vel.y, 0.0f);
        }

    }

    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "obstaculo"){
            SceneManager.LoadScene("controles");
        }
    }

    

}
