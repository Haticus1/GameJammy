using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierFollow : MonoBehaviour
{ 
    [SerializeField]
    private Transform[] Routes;

    private int routeToGo;
    private float tparam;
    private Vector2 Position;
    public float Speed;
    private bool coroutineAllowed;




    // Start is called before the first frame update
    void Start()
    {
        routeToGo = 0;
        tparam = 0f;
        //Speed = 0.5f;
        coroutineAllowed = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (coroutineAllowed)
            StartCoroutine(GoByTheRoute(routeToGo));
    }

    private IEnumerator GoByTheRoute(int routeNumber)
    {
        coroutineAllowed = false;

        Vector2 p0 = Routes[routeNumber].GetChild(0).position;
        Vector2 p1 = Routes[routeNumber].GetChild(1).position;
        Vector2 p2 = Routes[routeNumber].GetChild(2).position;
        Vector2 p3 = Routes[routeNumber].GetChild(3).position;

        while (tparam < 1 )
        {
            tparam += Time.deltaTime * Speed;

            Position = Mathf.Pow(1 - tparam, 3) * p0 +
                3 * Mathf.Pow(1 - tparam, 2) * tparam * p1 +
                3 * (1 - tparam) * Mathf.Pow(tparam, 2) * p2 +
                Mathf.Pow(tparam, 3) * p3;
            transform.position = Position;
            yield return new WaitForEndOfFrame();


        }

        tparam = 0f;
        routeToGo += 1;
        if (routeToGo > Routes.Length - 1)
            routeToGo = 0;

        coroutineAllowed = true;
        


    }





}
