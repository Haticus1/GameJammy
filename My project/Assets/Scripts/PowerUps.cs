using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D Rigidbody;
    private int time1;
    private int time2;
    public GameObject me;
    Vector2 Move;
    void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Move = new Vector2(0, -1f);
        Rigidbody.velocity = Move;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.instance.LevelUp();
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(me, 3);
        }
    }
}
    
       


