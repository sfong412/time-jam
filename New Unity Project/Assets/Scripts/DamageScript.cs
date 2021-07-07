using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageScript : MonoBehaviour
{
    public bool damaged;

    public bool damaged3;

    public bool damaged5;

    public bool damaged7;

    public bool triggerDamaged;
    public bool triggerDamaged2;

    public bool triggerDamaged3;

    public bool triggerDamaged4;
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

        if (other.tag == "gonerspike")
        {
            triggerDamaged3 = true;
        }

        if (other.tag == "cat")
        {
            triggerDamaged4 = true;
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

        if (triggerDamaged3 == true)
        {
            if (stopnow.stopping == false)
            {
                StartCoroutine(damaged6());
                triggerDamaged3 = false;
            }
        }

        if (triggerDamaged4 == true)
        {
            if (stopnow.stopping == false)
            {
                StartCoroutine(damaged8());
                triggerDamaged4 = false;
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

    IEnumerator damaged6()
    {

        cameraMain.SetBool("shook", true);
        damaged5 = true;
        yield return null;
        damaged5 = false;
        yield return new WaitForSeconds(0.15f);
        cameraMain.SetBool("shook", false);
        yield return new WaitForSeconds(2);

    }

     IEnumerator damaged8()
    {

        cameraMain.SetBool("shook", true);
        damaged7 = true;
        yield return new WaitForSeconds(0.005f);
        damaged7 = false;
        yield return new WaitForSeconds(0.15f);
        cameraMain.SetBool("shook", false);
        yield return new WaitForSeconds(2);

    }

   
}
