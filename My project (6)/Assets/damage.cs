using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    
    public HealthSystem HealthSystem;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag=="dusman"){
			HealthSystem.Damage(25);
		}
	}

	
}
