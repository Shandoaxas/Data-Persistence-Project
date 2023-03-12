using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ActionPanelController : MonoBehaviour
{
    public GameObject nameInput;
    public void StartGame()
    {
        SessionManager.SessionData sessionData = SessionManager.instance.gameSession;
        if(sessionData == null)
        {
            sessionData = new SessionManager.SessionData();
            string playerName = nameInput.GetComponent<TMP_InputField>().text;
            if (!string.IsNullOrWhiteSpace(playerName))
            {
                sessionData.currentPlayerName = playerName;
            }
            else
            {
                sessionData.currentPlayerName = "Player";
            }
            sessionData.currentHighScore = 0;
            SessionManager.instance.gameSession = sessionData;
        }
        else
        {
            string playerName = nameInput.GetComponent<TMP_InputField>().text;
            if(!string.IsNullOrWhiteSpace(playerName))
            {
                if(sessionData.currentPlayerName != playerName)
                {
                    sessionData.currentPlayerName = playerName;
                    sessionData.currentHighScore = 0;
                }
            }
        }

        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif
    }
}
