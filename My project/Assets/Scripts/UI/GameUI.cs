using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI livesText;
    [SerializeField] Image TimeAmount;

    // Update is called once per frame
    void Update()
    {   
        scoreText.text =  "Score: " + GameManager.instance.score.ToString("D9");
        livesText.text = "Lives: " + new StringBuilder().Insert(0, " X ", GameManager.instance.playerHealth).ToString();
        TimeAmount.fillAmount = GameManager.instance.slowMeter / GameManager.instance.slowMax;
    }
}
