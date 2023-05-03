using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowers : MonoBehaviour
{
    [SerializeField] float SlowScale = 0.6f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            TimeSlow();
        }
        else
        {
            Time.timeScale = 1f;
            if (GameManager.instance.slowMeter < 10)
            {
                GameManager.instance.slowMeter += Time.deltaTime/2;
            }
            else if (GameManager.instance.slowMeter > 5) GameManager.instance.slowMeter = 5;          
        }
    }

    void TimeSlow()
    {
        if (GameManager.instance.slowMeter > 0)
        {
            GameManager.instance.slowMeter -= Time.deltaTime; 
            Time.timeScale = SlowScale;
        }
        else Time.timeScale = 1;        
    }
}
