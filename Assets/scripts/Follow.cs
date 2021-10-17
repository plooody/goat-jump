using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
 

    public GameObject character;
    public GameObject cloud;
    public GameObject cloud2;

    public GameObject bouncyCloud;

    public float range = 3;
    private float lastheight;
    public float gap = 2f;
    void Start()
    {
        lastheight = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.y - transform.position.y > 0) {
            float change = character.transform.position.y - transform.position.y;
            transform.Translate(new Vector3(0, change, 0));
            if (transform.position.y > lastheight + gap) {
                lastheight = transform.position.y;
                int rand = Random.Range(0, 10);
                if (rand < 2) {
                    Instantiate(bouncyCloud, new Vector2(Random.Range(transform.position.x - range, transform.position.x + range), transform.position.y + 15f), Quaternion.identity);
                }
                else if(rand<5)
                {
                    float num= Random.Range(transform.position.x - range, transform.position.x + range);
                    Instantiate(cloud2, new Vector2(num + 1.5f , transform.position.y + 15f), Quaternion.identity);
                    Instantiate(cloud2, new Vector2(num - 1.5f, transform.position.y + 15f), Quaternion.identity);

                    Instantiate(cloud, new Vector2(num, transform.position.y + 15f), Quaternion.identity);
                }
                else
                {
                    Instantiate(cloud2, new Vector2(Random.Range(transform.position.x - range, transform.position.x + range), transform.position.y + 15f), Quaternion.identity);
                }
            }
        }
    }
}
