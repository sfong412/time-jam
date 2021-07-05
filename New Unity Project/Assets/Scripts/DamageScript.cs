using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageScript : MonoBehaviour
{
    public bool damaged;

    public bool damaged3;

    public bool triggerDamaged;
    public bool triggerDamaged2;
    public bool gonered;

    public Animator cameraMain;

    public UIThings stopnow;

    void OnTriggerEnter2D(Collider2D other)
    {
          if (other.tag == "goner")
        {
            triggerDamaged = true;
            Debug.Log("hit");
        }

        if (other.tag == "goner2")
        {
            triggerDamaged2 = true;
            Debug.Log("hit2");
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
            if (stopnow.stopping == false)
            {
            StartCoroutine(damaged2());
            triggerDamaged = false;
            }
           
        }

        if (triggerDamaged2 == true)
        {
            if (stopnow.stopping ==  false)
            {
                StartCoroutine(damaged4());
                triggerDamaged2 = false;
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

     IEnumerator damaged4()
    {

        cameraMain.SetBool("shook", true);
        damaged3 = true;
        yield return null;
        damaged3 = false;
        yield return new WaitForSeconds(0.15f);
        cameraMain.SetBool("shook", false);
        yield return new WaitForSeconds(2);

    }

   
}
