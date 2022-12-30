using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public HealthSystem system;
    private bool debounce = false;

    private void Start()
    {
        debounce = false;
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && !debounce)
        {
            debounce = true;
            system.coins++;
            this.gameObject.SetActive(false);
        }
    }
}
