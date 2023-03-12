using System.Collections;
using System.Collections.Generic;
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
            sessionData.currentPlayerName = "Player";
            sessionData.currentHighScore = 0;
            SessionManager.instance.gameSession = sessionData;
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
