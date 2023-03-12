using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionManager : MonoBehaviour
{
    public static SessionManager instance;
    public SessionData gameSession;
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

    public class SessionData
    {
        public string currentPlayerName;
        public int currentHighScore;
    }

}
