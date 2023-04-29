using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Bullet;
    public Transform bulletPos;
    public float timer;

    private void Start()
    {
        

    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer > 2)
        {
            
            timer = 0;
            shoot();
        }  
        
       

    }


    void shoot()
    {
        Instantiate(Bullet, bulletPos.position, Quaternion.identity);
    }
}
