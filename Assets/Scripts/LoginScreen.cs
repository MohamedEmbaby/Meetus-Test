using RTLTMPro;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginScreen : MonoBehaviour
{
    public InputField Name_InputField;
    public RTLTextMeshPro WarningMsg;

    void Start()
    {
        // shuould check data online, but this test is not online supported
        if (!string.IsNullOrEmpty(PlayerPrefs.GetString(Prefs.PREF_PLAYER_NAME))) {
            Login();
        }
        
    }

    public void AttemptLogin()
    {
        // check if name is valid length
        if (Name_InputField.text.Length > 0
            && Name_InputField.text.Length < 32)
        {
            ////////////////////////
            /// Here should send creds to server and wait for response, if response is true continue to save the creds offline and login
            /// But this test is not server supported
            ///////////////////////
            PlayerController.Instance.SaveCreds(Name_InputField.text);
            Login();
        }
        else {
            WarningMsg.enabled = true;
        }

    }


    private void Login()
    {
        SceneManager.LoadScene("Room");
    }


}
