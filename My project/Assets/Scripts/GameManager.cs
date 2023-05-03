using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int powerLevel = 1;
    public int playerHealth = 5;
    public float slowMeter = 5.0f;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public enum GameState
    {
        Play,
        Win,
        Lose
    }



}
