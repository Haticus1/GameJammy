using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bubblePrefab;

    public float bubbleForce = 20f;
    public float timer = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            timer += Time.deltaTime;
            if (timer >= 0.1f)
            {
                Shoot();
                timer = 0f;
            }
         
        }
    }

    void Shoot()
    {
        GameObject bubble = Instantiate(bubblePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bubble.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bubbleForce, ForceMode2D.Impulse);
    }


}
