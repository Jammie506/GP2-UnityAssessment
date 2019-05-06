using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Persistence : MonoBehaviour
{
    Text MainMenu;

    string playerName; 
    public float mouseSensitivity;

    void GetState()
    {
        if(PlayerPrefs.HasKey("playerName"))
        {
            playerName = PlayerPrefs.GetString("playerName");
            mouseSensitivity = PlayerPrefs.GetFloat("mouseSensitivity");
        }
    }
    
    void SetState()
    {
        PlayerPrefs.SetString("playerName", playerName);
        PlayerPrefs.SetFloat("mouseSensitivity", mouseSensitivity);

        PlayerPrefs.Save();
    }

    void ShowStatus()
    {
        string stuff = "";
        stuff += "Player Name: " + playerName;
        stuff += "Mouse Sensitivity: " + mouseSensitivity;

        MainMenu.text = stuff;
    }

    void Awake()
    {
        MainMenu = GetComponent<Text>();
        GetState();
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            SetState();
            Debug.Log("pause");
        }
        else
        {
            GetState();
            Debug.Log("resume");
        }
    }

    void OnApplicationQuit()
    {
        SetState();
    }

    void Start()
    {
        if (!PlayerPrefs.HasKey("playerName"))
        {
            playerName = "Jamie";
            mouseSensitivity = 5.0f;
        }
    }

    void Update()
    {
        
    }
}
