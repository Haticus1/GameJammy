using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour
{
    [SerializeField] private Image TimeAmount;

    // Update is called once per frame
    void Update()
    {
        TimeAmount.fillAmount = GameManager.instance.slowMeter / GameManager.instance.slowMax;
    }
}
