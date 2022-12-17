using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public int forcee=100;
    void Update()
    {
        rb.AddForce(forcee*Time.deltaTime,0,0);

        
    }

    
}
