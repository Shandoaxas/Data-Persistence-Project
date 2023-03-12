using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionManager : MonoBehaviour
{
    public static SessionManager instance;
    public SessionData gameSession;
    public SessionData bestGameSession;
    // Start is called before the first frame update
    void Awake()
    {
        if(SessionManager.instance == null)
        {
            SessionManager.instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [Serializable]
    public class SessionData
    {
        public string currentPlayerName;
        public int currentHighScore;
    }

    public void SaveIfHighScore()
    {

    }

    public void LoadHighScore()
    {

    }


}
