using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(gameObject.GetComponent<Animator>().GetCurrentAnimatorClipInfo(0)[0].clip.name=="nothing")
        {
            Destroy(gameObject);
            Debug.Log("dead");
        }
    }
}
