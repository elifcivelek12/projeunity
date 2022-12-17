using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public Rigidbody rb;


   
    void OnCollisionEnter (Collision thing){
        Debug.Log(thing.collider.tag);
       
    }
}
