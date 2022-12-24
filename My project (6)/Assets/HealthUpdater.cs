using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthUpdater : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    public HealthSystem system;

    void Update()
    {
        text.SetText("Health: " + system.health);
        text2.SetText("Coins: " + system.coins);
    }
}
