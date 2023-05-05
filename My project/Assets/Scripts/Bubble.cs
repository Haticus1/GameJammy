using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] SpriteRenderer sr;

    private void Update()
    {
        if (!sr.isVisible)
        {
           gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        gameObject.SetActive(false);
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.SendMessage("DealDamage", -1);
        }
    }

}
