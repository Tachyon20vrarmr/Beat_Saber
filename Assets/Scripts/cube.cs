using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public static bool stop;
    // Start is called before the first frame update
    void Start()
    {
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop == false)
        {
            transform.position += Time.deltaTime * transform.forward * 2;
        }
        else
        {
            //gameObject.AddComponent<Rigidbody>();
        }
    }
}
