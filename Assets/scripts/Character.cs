using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.acceleration.x < 0) {
            transform.Translate(Vector2.left* speed*Time.deltaTime * Mathf.Abs(Input.acceleration.x));
        }
        else {
            transform.Translate(Vector2.right * speed * Time.deltaTime*Mathf.Abs(Input.acceleration.x));
        }

        if (Input.acceleration.x < 0)
        {
            
        }/*
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

          
            var realWorldPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (realWorldPos.x < 0)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);

            }
            else
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);

            }


        }*/
    }
       
}
