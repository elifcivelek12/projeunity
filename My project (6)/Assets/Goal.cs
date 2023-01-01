using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public HealthSystem hp;
    private bool debounce = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && !debounce)
        {
            debounce = true;
            hp.Win();
            // You win the game!
        }
    }
}
