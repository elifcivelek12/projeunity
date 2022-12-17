using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraa : MonoBehaviour
{
    public Transform rb;
    public Vector3 kamer;

    void Update()
    {
        transform.position = rb.position + kamer;
   
    }
}

