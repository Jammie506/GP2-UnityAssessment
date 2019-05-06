using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public float playerHealth;
    public float timer;

    public Text PlayerHealth;
    public Text Timer;
    
    void Start()
    {
        PlayerHealth = GetComponent<Text>();
        Timer = GetComponent<Text>();
    }
    
    void Update()
    {
        PlayerHealth.text = "Health : " + playerHealth;
        Timer.text = "Tiem : " + Time.deltaTime;
    }
}
