using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{

    float xspeep = 0f;
    float power = 0.001f;
    float friction = 0.95f;
    bool right = false;
    bool left = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Use this for initialization
    void FixedUpdate()
    {


        if (right)
        {
            xspeep += power;
    
        }
        if (left)
        {
            xspeep -= power;
          
        }


    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("up"))
        {
            right = true;
        }
        if (Input.GetKeyUp("up"))
        {
            right = false;
        }
        if (Input.GetKeyDown("down"))
        {
            left = true;
        }
        if (Input.GetKeyUp("down"))
        {
            left = false;
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, 0, 2);
        }
            
        if (Input.GetKey("right"))
            transform.Rotate(0, 0, -2);

        FixedUpdate();

        xspeep *= friction;
        transform.Translate(Vector3.down * -xspeep);

    }
}
