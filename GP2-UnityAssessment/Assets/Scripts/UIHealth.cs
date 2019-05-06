using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealth : MonoBehaviour
{
    public float playerHealth;

    public Text PlayerHealth;

    void Start()
    {
        PlayerHealth = GetComponent<Text>();
    }

    void Update()
    {
        PlayerHealth.text = "Health : " + playerHealth;
    }
}
