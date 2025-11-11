using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }
    [HideInInspector] public string Name;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); 
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        initCreds();
        
    }

    private void initCreds()
    {
        Name = PlayerPrefs.GetString(Prefs.PREF_PLAYER_NAME);
    }

    public void SaveCreds(string PlayerName) {
        Name = PlayerName;
        PlayerPrefs.SetString(Prefs.PREF_PLAYER_NAME, PlayerName);
    }



}
