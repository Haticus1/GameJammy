using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState gs;
    public int powerLevel = 1;
    public int playerHealth = 5;
    public int score = 0;
    public float slowMeter = 5.0f;
    public GameObject Drops;


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
        switch (gs)
        {
            case GameState.Win:
                //code to win
                break;
            case GameState.Play: break;
            case GameState.Lose:
                //Code to lose
                //pause the game
                //display the lose UI
                    // score
                    //High score
                    //quit button
                    //replay/restart button
                break;
        }

        if(gs == GameState.Lose)
        {
            //code to end the game
        }
    }

    public void EditHealth(int i)
    {
        playerHealth += i;
        if(playerHealth < 1)
        {
            gs = GameState.Lose;
        }
    }

    public enum GameState
    {
        Play,
        Win,
        Lose
    }

  public void LevelUp()
    {
            powerLevel++;       
    }
}
