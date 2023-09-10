using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    private DateTime sessionStartTime;
    private DateTime sessionEndTime;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        sessionStartTime = DateTime.Now;
        Debug.Log("Game session start @: "+ DateTime.Now);
    }
    private void OnApplicationQuit()
    {
        sessionEndTime = DateTime.Now;
        TimeSpan timeDifference = sessionEndTime.Subtract(sessionStartTime);
        Debug.Log("Game session ended @:" + DateTime.Now);
        Debug.Log("Game session lasted:" + timeDifference);
    }
    // Update is called once per frame
    public void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
