using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossInsult : Hazard
{
    float speed = -12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform1.position = new Vector3(transform1.position.x + speed, transform1.position.y, transform1.position.z);
    }
}
