using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerkSystem : MonoBehaviour
{

  //  UIThings3 ui;
    static public bool inkRegenUpPerk = true;

    static public bool eraserUseUpPerk = false;

    static public bool focusCapacityUpPerk = false;
    static public float inkRegenRate2 = 0.1f;
    static public float eraserUseRate = 0.1f;
    static public float focusCapacityRate;
    static public float startingHealth = 100;

    static public float startingEraser = 100;

    static public float startingFocus = 150;

    public UIThings3 fix;

    // Start is called before the first frame update
    void Start()
    {
        //ui = GameObject.Find("Ink Bar").GetComponent<UIThings3>();

        if (inkRegenUpPerk == true)
        {
            inkRegenRate2 = 0.1f * 1000;
        }
        else
        {
            inkRegenRate2 = 0.1f;
        }

        if (eraserUseUpPerk == true)
        {
            eraserUseRate = 0.05f;
        }
        else
        {
            eraserUseRate = 0.1f;
        }

        if (focusCapacityUpPerk == true)
        {
            startingFocus = 1000f;
        }
        else
        {
            startingFocus = 150f;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
