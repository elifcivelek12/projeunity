using System;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public Movement movement;

    private bool debounce = false;
    private Vector3 startingCoordinates;
    private float timer;
    private float disappearTimer;

    private void Start()
    {
        timer = 0;
        disappearTimer = 0;
        debounce = false;
        startingCoordinates = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && !debounce)
        {
            debounce = true;
            disappearTimer = 600;
            movement.jumpIncreaseTimer += 600;
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    private void Update()
    {
        timer++;
        float sin = Mathf.Sin(timer / 60f) / 2f;

        transform.position = startingCoordinates + new Vector3(0, sin, 0);

        if(disappearTimer > 0)
        {
            disappearTimer--;
            if (disappearTimer == 0)
            {
                GetComponent<SpriteRenderer>().enabled = true;
                debounce = false;
            }
        }
    }
}
