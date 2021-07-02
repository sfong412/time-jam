using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageScript : MonoBehaviour
{
    public bool damaged;

    public bool triggerDamaged;
    public bool gonered;

    public Animator cameraMain;

    public UIThings stopnow;

    void OnTriggerEnter2D(Collider2D other)
    {
          if (other.tag == "goner")
        {
            triggerDamaged = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
         if (other.tag == "goner")
        {
            if (triggerDamaged == false)
            {
                triggerDamaged = true;
            }

        }
    }

    void Update()
    {
        if (gonered == true)
        {
            SceneManager.LoadScene(1);
        }

        if (triggerDamaged == true)
        {
            if (!stopnow)
            {
            StartCoroutine(damaged2());
            triggerDamaged = false;
            }
           
        }
    }

    IEnumerator damaged2()
    {
        cameraMain.SetBool("shook", true);
        damaged = true;
        yield return null;
        damaged = false;
        yield return new WaitForSeconds(0.15f);
        cameraMain.SetBool("shook", false);
        yield return new WaitForSeconds(2);

    }

   
}
