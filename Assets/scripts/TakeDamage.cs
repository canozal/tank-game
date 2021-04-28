using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{

    public int health;

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // Debug.Log(collision.gameObject.tag);

        if(collision.gameObject.tag == "damage")
        {
            health--;
            if(health == 0)
            {
                //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
                // Destroy(effect, 1f);
                Destroy(gameObject);
               
            }
        }
    }
}
