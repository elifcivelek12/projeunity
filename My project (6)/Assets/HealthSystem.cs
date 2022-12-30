using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int coins;

    public void Damage(int damage)
    {
        health = Math.Max(0, health - damage);
        if(health <= 0)
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }

    public void Start() { health = 100; coins = 0; }
}
