using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SessionManager : MonoBehaviour
{
    public static SessionManager instance;
    public SessionData gameSession;
    public SessionData bestGameSession;
    // Start is called before the first frame update
    void Awake()
    {
        if(SessionManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();
    }

    [Serializable]
    public class SessionData
    {
        public string currentPlayerName;
        public int currentHighScore;
    }

    public void SaveIfHighScore()
    {
        string jsonData = JsonUtility.ToJson(bestGameSession);
        File.WriteAllText(Application.persistentDataPath + "savefile.json", jsonData);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "savefile.json";

        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            SessionData data = JsonUtility.FromJson<SessionData>(jsonData);
            bestGameSession = data;

        }
        else
        {
            bestGameSession = new SessionData();
            bestGameSession.currentHighScore = 0;
            bestGameSession.currentPlayerName = "";
        }
    }


}
