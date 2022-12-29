using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this was just a sample - we aren't using it for anything anymore. (at least,I don't think so...?)
public class Spin : MonoBehaviour
{
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0);
        
    }
}
