using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rbody;
    private float input;
    private float vel=19f;
    
   
    void Awake(){
        rbody=GetComponent<Rigidbody2D>();
    }
    void Update(){
        input=Input.GetAxis("Horizontal");
    }
    void FixedUpdate(){
        rbody.velocity=new Vector2(input*vel,0);
    }
}
