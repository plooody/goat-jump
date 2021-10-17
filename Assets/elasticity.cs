using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elasticity : MonoBehaviour
{
    // Start is called before the first frame update
    float constantY;
    float constantX;

    private bool istriggered = false;
    float suddenChange = 0;

    void Start()
    {
        constantY = transform.localScale.y;
        constantX = transform.localScale.x;

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0, (constantY - transform.localScale.y)*Time.deltaTime*2 + suddenChange, 0);
        transform.localScale += new Vector3((constantY - transform.localScale.x) * Time.deltaTime * 2 - suddenChange, 0, 0);

        if (gameObject.GetComponent<Rigidbody2D>().velocity.y < 0) {
            transform.localScale += new Vector3((constantY - transform.localScale.x) * Time.deltaTime * 100f , (constantY + transform.localScale.y) * Time.deltaTime * 0.2f, 0);
        }
        suddenChange = 0;

    }

    public void Bounce()
    {
        suddenChange = -0.3f;
    }
}
