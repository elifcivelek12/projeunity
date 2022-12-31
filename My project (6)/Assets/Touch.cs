using System;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public Movement movement;

    private bool debounce = false;
    private Vector3 startingCoordinates;
    private float timer;

    private void Start()
    {
        timer = 0;
        debounce = false;
        startingCoordinates = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && !debounce)
        {
            debounce = true;
            movement.jumpIncreaseTimer += 600;
            this.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        timer++;
        float sin = Mathf.Sin(timer / 60f) / 2f;

        transform.position = startingCoordinates + new Vector3(0, sin, 0);
    }
}
