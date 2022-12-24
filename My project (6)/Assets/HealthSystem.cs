using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int coins;

    public void Damage(int damage)
    {
        health = Math.Max(0, health - damage);
    }

    public void Start() { health = 100; }
}
