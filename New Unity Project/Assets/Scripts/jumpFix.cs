using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpFix : MonoBehaviour
{
   public CharacterController2D characterController2D;
   public Animator PlayerFix;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground2")
        {
            characterController2D.isgrounded = true;
            PlayerFix.SetBool("Jumped", false);
            PlayerFix.SetBool("grounded", true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ground2")
        {
            characterController2D.isgrounded = false;
              PlayerFix.SetBool("grounded", false);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Ground2")
        {
            characterController2D.isgrounded = true;
            PlayerFix.SetBool("Jumped", false);
              PlayerFix.SetBool("grounded", true);
        }

      
    }
}
