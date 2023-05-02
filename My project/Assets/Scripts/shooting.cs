using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bubblePrefab;

    public float bubbleForce = 20f;
    public float timer = 0.1f;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            timer += Time.deltaTime;
            if (timer >= 0.1f)
            {
                SpawnProjectile();
            }

        }
    }


    void SpawnProjectile()
    {
        GameObject bubble = PlayerObjectPool.instance.GetPoolObject();
        if (bubble == null) return;
        bubble.transform.position = firePoint.position;
        bubble.transform.rotation = firePoint.rotation;
        bubble.SetActive(true);
        Rigidbody2D rb = bubble.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bubbleForce, ForceMode2D.Impulse);
        timer = 0f;
    }
}
