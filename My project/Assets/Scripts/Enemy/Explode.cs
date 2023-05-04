using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public int health;
    public GameObject Drop;
    public GameObject Myself;

    void Start()
    {
        
    }

    private void Update()
    {
      
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            health--;

            if (health == 0)
            {
                Instantiate(Drop,transform.position,Quaternion.identity);
               
                Destroy(gameObject);
            }
        }


    }



}
