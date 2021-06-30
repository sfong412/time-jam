using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageScript : MonoBehaviour
{
    

    void OnTriggerStay2D(Collider2D other)
    {
          if (other.tag == "goner")
        {
            SceneManager.LoadScene(1);
        }
    }
}
