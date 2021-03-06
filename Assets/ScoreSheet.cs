﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ScoreSheet : MonoBehaviour {

    private static int  gameScore = 0;

	// Use this for initialization
	void Start()
    {
       
    }

    //// Update is called once per frame
    //void Update () {
    //}

    
    private static bool created = false;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            //gameScore = 0;
            Debug.Log("Awake: " + this.gameObject);
        }
    }

    public int AddScore(int value)
    {
        return gameScore += value;
    }

    public int GetScore()
    {
        return gameScore;
    }

    public void ResetScore()
    {
        gameScore = 0;
    }

    public string ScoreText()
    {
        return ("Score: " + gameScore);
    }
}
