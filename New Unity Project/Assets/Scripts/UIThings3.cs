using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIThings3 : MonoBehaviour
{

    public float startingHealth;
    public float remainingHealth;

    public float remainingFocus;
    public float startingFocus;
    public Slider healthBar;

    public float smoothing = 5;

    public bool placeBlockDeplete;
    public bool heal;
    public bool healCoolDown1;
    public Gameplay gameplaying;

    public DamageScript damageScript;
    
    public Animator Ink;

    void Start()
    {
        remainingHealth = startingHealth;
        healthBar.maxValue = startingHealth;
        healthBar.value = remainingHealth;
        gameplaying.blockPlaced = false;
    }

    // Update is called once per frame
    void Update()
    {
       if (healthBar.value != remainingHealth)
       {
           healthBar.value = Mathf.Lerp(healthBar.value, remainingHealth, smoothing * Time.fixedDeltaTime);
       }

       if (gameplaying.blockPlaced == true)
       {
           InkDeplete(17);
           gameplaying.blockPlaced = false;
           healCoolDown1 = true;   
       }

       if (remainingHealth > 20)
       {
           gameplaying.canPlace = true;
       }

       if (damageScript.damaged == true)
       {
           DamageTaken(10);
          
       }
    
       
      
      
    }

    void FixedUpdate()
    {
        Healing(0.15f);
    }

    

    IEnumerator shakeCooldown()
    {
        yield return new WaitForSeconds(0.15f);
        Ink.SetBool("shake", false);
    }



   
    public void InkDeplete(float damage)
    {
        if (remainingHealth - damage >= 0)
        {
            remainingHealth -= damage;
             
        }
        else 
        {
            gameplaying.canPlace = false;
            Ink.SetBool("shake", true);
            StartCoroutine(shakeCooldown());
            
            
        }
    }

    public void DamageTaken(float damage)
    {
         if (remainingHealth - damage >= 0)
        {
            remainingHealth -= damage;
             
        }
        else 
        {   
          remainingHealth = 0;
          damageScript.gonered = true;   
        }
    }

    public void Healing(float increase)
    {
        if (remainingHealth + increase <= startingHealth)
        {
            remainingHealth += increase;
        }
        else
        {
            remainingHealth = startingHealth;
        }
    }

    public void FocusDeplete(float damage)
    {
        if (remainingHealth - damage >= 0)
        {
            remainingHealth -= damage;
             
        }
        else 
        {   
          remainingHealth = 0;
          damageScript.gonered = true;   
        }
    }
}
