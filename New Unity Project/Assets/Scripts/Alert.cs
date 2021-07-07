using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour
{

    public GameObject detector;
    public GameObject detector2;

    public Rigidbody2D not;

    public bool had = true;

    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
            if (other.tag == "Ground2")
        {
           
            detector.tag = "notCatchMe";
            detector2.SetActive(true);
            Debug.Log("under");
            not.constraints = RigidbodyConstraints2D.FreezeAll;
            StartCoroutine(lmao());
            
            
        }
        
        
    }

    void Update()
    {
        detector = GameObject.Find("Detection Hitbox");
    }

    IEnumerator lmao()
    {
        Debug.Log("under2");
        yield return new WaitForSeconds(5);
        detector.tag = "catchMe";
        detector2.SetActive(false);
        had = false;
        
    }
}
