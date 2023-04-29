using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrack : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D rb;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        float rot = Mathf.Atan2(-direction.y, -direction.x)* Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
        // We need to adjust the rot with a number of degrees so we know where its going try add 45 or 90

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
