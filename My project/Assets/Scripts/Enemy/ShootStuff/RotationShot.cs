using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationShot : MonoBehaviour
{
    public GameObject Thirdenemy;
    public GameObject Bullet;
    public Transform bulletPos;
    public float ShotTime = 0.15f;


    private void Update()
    {

            ShotTime += Time.deltaTime;
            if (ShotTime >= 0.15f)
            {
                shoot();
            }

        
            transform.Rotate(0, 0, .3f);
        

    }


    void shoot()
    {
        Instantiate(Bullet, bulletPos.position, bulletPos.rotation);
        ShotTime = 0;

    }

}
