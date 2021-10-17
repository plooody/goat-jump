using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosive : MonoBehaviour
{

    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector3 pos = transform.position;
            Quaternion rotation = transform.rotation;
            Instantiate(explosion, new Vector3(pos.x,pos.y,pos.z), rotation);
            Destroy(gameObject);
        }
        else
        {
            
        }
    }

}
