using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shooting : MonoBehaviour
{

    public Transform[] firePoint;
    public GameObject bubblePrefab;

    public int level2Requirement = 25;
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
                SpawnProjectile(firePoint[0]);
                if (GameManager.instance.powerLevel > level2Requirement)
                {
                    SpawnProjectile(firePoint[1]);
                    SpawnProjectile(firePoint[2]);
                }
                timer = 0f;
            }

        }
    }


    void SpawnProjectile(Transform t)
    {
        GameObject bubble = PlayerObjectPool.instance.GetPoolObject();
        if (bubble == null) return;
        bubble.transform.position = t.position;
        bubble.transform.rotation = t.rotation;
        bubble.SetActive(true);
        Rigidbody2D rb = bubble.GetComponent<Rigidbody2D>();
        rb.AddForce(t.up * bubbleForce, ForceMode2D.Impulse);
    }
}
