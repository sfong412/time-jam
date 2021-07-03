using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Immovable : MonoBehaviour
{

    public Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground2")
        {
            StartCoroutine(freeze());
        }
    }

    IEnumerator freeze()
    {
        yield return new WaitForSeconds(0.5f);
        rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
    }
}
