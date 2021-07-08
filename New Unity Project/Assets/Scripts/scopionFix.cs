using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scopionFix : MonoBehaviour
{
    public ScopioAI directionguy;
       public audioFix1 jumps;

       void Start()
       {
            jumps = GameObject.Find("AudioController (2)").GetComponent<audioFix1>();
       }
     void OnTriggerEnter2D(Collider2D other)
   {
       if (other.tag == "Ground")
       {
        if (directionguy.direction == 1)
       {
           directionguy.direction = 0;
           directionguy.shouldIReally = true;
           jumps.jumps = true;
          
       }
       else
       {
           directionguy.direction = 1;
           directionguy.shouldIReally = true;
           jumps.jumps = true;
      

       }
       }

       if (other.tag == "scopion")
       {
           if (directionguy.direction == 1)
       {
           directionguy.direction = 0;
           jumps.jumps = true;
          
          
       }
       else
       {
           directionguy.direction = 1;
           jumps.jumps = true;
         
      

       }
       }

       if (other.tag == "jump")
       {
           directionguy.high = true;
       }

       if (other.tag == "stopnow")
       {
           directionguy.stopim = true;
           directionguy.shouldI = false;
       }
       else
       {
           directionguy.shouldI = true;
       }

       if (other.tag == "ice")
       {
           directionguy.slowed = true;
       }
       

    
       }

       void OnTriggerStay2D(Collider2D other)
   {
       if (other.tag == "Ground" || other.tag == "scopion")
       {
        if (directionguy.direction == 1)
       {
           directionguy.direction = 0;
           directionguy.shouldIReally = true;
           jumps.jumps = true;
       
       }
       else
       {
           directionguy.direction = 1;
           directionguy.shouldIReally = true;
           jumps.jumps = true;
    
       }
       }
    
       }

       void OnTriggerExit(Collider2D other)
       {
           if (other.tag == "ice")
           {
               directionguy.slowed = false;
           }
       }

     
}
