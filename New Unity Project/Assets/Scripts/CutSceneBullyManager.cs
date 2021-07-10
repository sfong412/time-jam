using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneBullyManager : MonoBehaviour
{

    public GameObject one;

    public GameObject two;

    public GameObject three;

    public GameObject four;

    public CutsceneText1 ooga;

    public int indexl = 0;

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                indexl++;
            }

            switch (indexl)
            {
                case 0:
                one.SetActive(true);
                break;

                case 1:
                two.SetActive(true);
                break;

                case 2:
                three.SetActive(true);
                break;

                case 3:
                 one.SetActive(false);
                 two.SetActive(false);
                 three.SetActive(false);
                 four.SetActive(true);
                 break;

            }
        
    }

}
