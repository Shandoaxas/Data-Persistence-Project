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
        SessionManager.SessionData data = SessionManager.instance.gameSession;
        if(data != null)
        {
            UpdateWithSessionData(data);
        }
        
        

    }

    void UpdateWithSessionData(SessionManager.SessionData data)
    {
        bestScore.GetComponent<TextMeshProUGUI>().text = $"Best Score : {data.currentPlayerName} {data.currentHighScore}";
        nameInput.GetComponent<TMP_InputField>().text = data.currentPlayerName;
    }
}
