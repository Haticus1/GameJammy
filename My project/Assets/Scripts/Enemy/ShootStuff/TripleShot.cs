using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShot : MonoBehaviour
{
    public GameObject Bullet;
    public Transform bulletPos;
    public float AttackTime;
    public float ShotTime = 0.2f;
    int shotcount = 0;

    private void Update()
    {
        AttackTime += Time.deltaTime;

        if (AttackTime > 2)
        {
            ShotTime += Time.deltaTime;
            if (ShotTime >= 0.2f &&shotcount < 3) 
            {
                shoot();
            }
        }

        

    }


    void shoot()
    {
        Instantiate(Bullet, bulletPos.position, Quaternion.identity);
        shotcount++;
        ShotTime = 0;
        if (shotcount >= 3) 
        {
            AttackTime = 0;
            shotcount = 0;
        }
    }

}
