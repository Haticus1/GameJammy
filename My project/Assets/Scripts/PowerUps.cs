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
    Vector3 Move;
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Move = new Vector3(0, -0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Move);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.instance.XP++;
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(me, 3);
        }
    }
}
    
       


