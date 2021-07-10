using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioFix4 : MonoBehaviour
{

    public AudioSource uiBeep;

    public AudioClip beep1;
    public AudioClip beep2;
    public AudioClip beep3;

    public Menu signal;

    public bool kill;
   
    // Update is called once per frame
    void Update()
    {
          if (signal.whyUnity == true)
        {
           var randomBeep = Random.Range(0,2);
           //switches not working for some reason??

           if (randomBeep == 0)
           {
               uiBeep.PlayOneShot(beep1, 0.15f);
               signal.whyUnity = false;
           }
           else if(randomBeep == 1)
           {
                uiBeep.PlayOneShot(beep2, 0.15f);
                signal.whyUnity = false;
           }
           else if(randomBeep == 2)
           {
                uiBeep.PlayOneShot(beep3, 0.15f);
                signal.whyUnity = false;
           }

         
        }
    }
}
