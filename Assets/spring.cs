using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour
{
    public float time = 0;
    public float hookConstant = 2000000f;
    private float springForce = 0;
    private float initY;
    private bool istriggered = false;

    // Start is called before the first frame update

    void Start(){
        float initY= transform.localScale.y;
    }

// Update is called once per frame
    void Update()
        {
        transform.localScale += new Vector3(0, (1-transform.localScale.y ) * hookConstant + springForce, 0);
        springForce = 0;
        Debug.Log(springForce);

        time -= Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>() && time <= 0 && collision.gameObject.tag=="Player" && collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <  -0.1f && istriggered == false)
        {
            springForce = -0.8f;
            istriggered = true;
            time = 1f;
        }
    }

    void OnTriggerExit(Collider coll)
    {
        istriggered = false;
    }

}
