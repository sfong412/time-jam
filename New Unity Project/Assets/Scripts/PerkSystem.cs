using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerkSystem : MonoBehaviour
{

  //  UIThings3 ui;
    static public bool inkRegenUpPerk = false;

    static public bool eraserUseUpPerk = false;

    static public bool focusCapacityUpPerk = false;

    static public bool inkRegenDownPerk = false;

    static public bool eraserUseDownPerk = false;

    static public bool focusCapacityDownPerk = false;

    static public float inkRegenRate2 = 0.1f;
    static public float eraserUseRate = 0.1f;
    static public float focusCapacityRate = 0.5f;
    static public float startingHealth = 100;

    static public float startingEraser = 100;

    static public float startingFocus = 150;

    static public float inkRegenMultiplier;

    static public float eraserUseMultiplier;

    static public float focusCapacityMultiplier;

    public UIThings3 fix;

    // Start is called before the first frame update
    void Update()
    {
        if (inkRegenUpPerk == true)
        {
            inkRegenMultiplier = 2f;
        }
        else if (inkRegenDownPerk == true)
        {
            inkRegenMultiplier = 0.5f;
        }
        else if (inkRegenUpPerk == false && inkRegenDownPerk == false)
        {
            inkRegenMultiplier = 1;
        }

        if (eraserUseUpPerk == true)
        {
            eraserUseMultiplier = 0.5f;
        }
        else if (eraserUseDownPerk == true)
        {
            eraserUseMultiplier = 1.2f;
        }
        else if (eraserUseUpPerk == false && eraserUseDownPerk == false)
        {
            eraserUseMultiplier = 1;
        }

        if (focusCapacityUpPerk == true)
        {
            focusCapacityMultiplier = 1.5f;
        }
        else if (focusCapacityDownPerk == true)
        {
            focusCapacityMultiplier = 0.666666f;
        }
        else if (focusCapacityUpPerk == false && focusCapacityDownPerk == false)
        {
            focusCapacityMultiplier = 1;
        }

        inkRegenRate2 = 0.1f * inkRegenMultiplier;
        eraserUseRate = 0.1f * eraserUseMultiplier;
        startingFocus = 150f * focusCapacityMultiplier;
/*
        if (inkRegenUpPerk == true)
        {
            inkRegenRate2 = 0.1f * 2;
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
            startingFocus = 100f;
        }
        else
        {
            startingFocus = 150f;
        }
*/
    }
}
