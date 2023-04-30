using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowers : MonoBehaviour
{
    [SerializeField] float SlowScale = 0.6f;
    [SerializeField] float slowMeter = 10;
    // Start is called before the first frame update

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
            if (slowMeter < 10)
            {
                slowMeter += Time.deltaTime;
            }
            else if (slowMeter > 10) slowMeter = 10;          
        }
    }

    void TimeSlow()
    {
        if (slowMeter > 0)
        {
            slowMeter -= Time.deltaTime; 
            Time.timeScale = SlowScale;
        }
        else Time.timeScale = 1;        
    }
}
