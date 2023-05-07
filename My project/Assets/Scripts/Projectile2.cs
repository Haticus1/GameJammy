using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2 : MonoBehaviour
{
    [SerializeField] SpriteRenderer sr;
    public float bulletForce = 5f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletForce;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (!sr.isVisible)
        {
            gameObject.SetActive(false);
        }
    }



        void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.EditHealth(-1);
        }
    }
}
