using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flag : MonoBehaviour
{

    public bool flagCaptured;

    void Awake()
    {
        flagCaptured = false;
    }
   void OnTriggerEnter2D(Collider2D other)
   {
       if (other.tag == "Player")
       {
           flagCaptured = true;
       }
   }
}
