using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounciness = 7;
    public float time = 0;
    private bool istriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>() && collision.gameObject.GetComponent<Rigidbody2D>().velocity.y < -0.1 && !istriggered ) {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,bounciness));
            collision.gameObject.GetComponent<elasticity>().Bounce();
            istriggered = true;
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        istriggered = false;
        Debug.Log("exit");
    }

}
