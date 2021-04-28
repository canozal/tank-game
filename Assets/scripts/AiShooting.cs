using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class AiShooting : MonoBehaviour
{

    public AIPath aIPath;


    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    float timer;
    int waitingTime = 3;



    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            if (aIPath.slowdownDistance > aIPath.remainingDistance)
            {
                shoot();
            }
            timer = 0;
        }

    }


    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

}
