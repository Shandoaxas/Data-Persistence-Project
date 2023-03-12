using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataPanelController : MonoBehaviour
{
    public GameObject bestScore;
    public GameObject nameInput;
    private void Start()
    {
        SessionManager.SessionData bestSessionData = SessionManager.instance.bestGameSession;
        SessionManager.SessionData sessionData = SessionManager.instance.gameSession;
        if(bestSessionData != null && sessionData != null)
        {
            UpdateWithSessionData(bestSessionData, sessionData);
        }
        
        

    }

    void UpdateWithSessionData(SessionManager.SessionData bestSessionData, SessionManager.SessionData sessionData)
    {
        bestScore.GetComponent<TextMeshProUGUI>().text = $"Best Score : {bestSessionData.currentPlayerName} {bestSessionData.currentHighScore}";
        nameInput.GetComponent<TMP_InputField>().text = sessionData.currentPlayerName;
    }
}
