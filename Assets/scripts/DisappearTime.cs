using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearTime : MonoBehaviour
{
    // Start is called before the first frame update
    public float time = 2;
    void Start()
    {
        Object.Destroy(gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
