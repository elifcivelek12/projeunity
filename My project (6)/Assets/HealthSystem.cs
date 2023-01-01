using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int coins;
    public TextMeshProUGUI text;

    public void Damage(int damage)
    {
        health = Math.Max(0, health - damage);
        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name, LoadSceneMode.Single);
        }
    }

    public void Win()
    {
        text.enabled = true;
    }

    private void Update()
    {
        if(transform.position.y < -20)
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name, LoadSceneMode.Single);
        }
    }

    public void Start() { health = 100; coins = 0; }
}
