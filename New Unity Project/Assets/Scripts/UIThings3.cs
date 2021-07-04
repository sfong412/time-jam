using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIThings3 : MonoBehaviour
{

    public float startingHealth;
    public float remainingHealth;

    public float InkRegenRate;

    public float enemyDamageAmount;

    public float currentEnemyDamageAmount;

    public float healthCounter;

    public float remainingFocus;
    public float startingFocus;

    public float startingEraser;
    public float remainingEraser;
    public Slider healthBar;
    public Slider focusBar;

    public Slider eraserBar;

    public TextMeshProUGUI healthCounter2;

    public float smoothing = 5;

    public bool canErase;
    public bool heal;
    public bool healCoolDown1;

    public bool hey;

    public bool erased;

    public Gameplay gameplaying;

    public DamageScript damageScript;
    
    public Animator Ink;
    public Animator Eraser;

    public UIThings pleaseStop;

    void Start()
    {
        remainingHealth = startingHealth;
        healthBar.maxValue = startingHealth;
        healthBar.value = remainingHealth;
        gameplaying.blockPlaced = false;
        remainingFocus = startingFocus;
        focusBar.maxValue = startingFocus;
        focusBar.value = remainingFocus;
        remainingEraser = startingEraser;
        eraserBar.maxValue = startingEraser;
        eraserBar.value = remainingEraser;
        currentEnemyDamageAmount = enemyDamageAmount;
    }

    void Awake()
    {
        gameplaying.canPlace = true;
        canErase = true;
    }

    // Update is called once per frame
    void Update()
    {
       if (healthBar.value != remainingHealth)
       {
           healthBar.value = Mathf.Lerp(healthBar.value, remainingHealth, smoothing * Time.fixedDeltaTime);
       }

       if (focusBar.value != remainingFocus)
       {
           focusBar.value = Mathf.Lerp(focusBar.value, remainingFocus, smoothing * Time.fixedDeltaTime);
       }

       if (eraserBar.value != remainingEraser)
       {
           eraserBar.value = Mathf.Lerp(eraserBar.value, remainingEraser, smoothing * Time.fixedDeltaTime);
       }

       if (gameplaying.blockPlaced == true)
       {
           InkDeplete(gameplaying.currentInkCost);
           healthCounter = remainingHealth;
           gameplaying.blockPlaced = false;
           healCoolDown1 = true;   
       }

      

       if (remainingFocus > 1)
       {
            gameplaying.canSlow = true;
       }

       if (damageScript.damaged == true && pleaseStop.stopping == false)
       {
          
         DamageTaken(currentEnemyDamageAmount);
                              
       }
       


       if (healthCounter > remainingHealth)
       {
           healthCounter--;
       }

       if (healthCounter < remainingHealth)
       {
           healthCounter++;
       }

       if (gameplaying.slowDownThereBuster == true)
       {
           FocusDeplete(0.3f);
       }

       if (remainingHealth < gameplaying.currentInkCost)
       {
           gameplaying.canPlace = false;
       }

       if (remainingHealth > gameplaying.currentInkCost)
       {
           gameplaying.canPlace = true;
       }

       if (gameplaying.shake == true)
       {
           Ink.SetBool("shake", true);
            StartCoroutine(shakeCooldown());
            gameplaying.shake = false;
       }

       if (erased == true)
       {
           EraserDeplete(20);
           erased = false;
       }

       if (remainingEraser < 20)
       {
            canErase = false; 
       }




        healthCounter2.SetText($"{Mathf.RoundToInt(healthCounter)}");
    
       
      
      
    }

    void FixedUpdate()
    {
        
        
            Healing(InkRegenRate); 
        HealingFocus(0.6f);
        
        
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
            heal = false;
            remainingHealth -= damage;
            
           
            
             
        }
        else if (remainingHealth - damage <= 0)
        {
            gameplaying.canPlace = false;
            heal = true;
            remainingHealth = 0;
            
            
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
        if (remainingFocus - damage >= 0)
        {
            remainingFocus -= damage;
             gameplaying.canSlow = true;
             
        }
        else 
        {   
          //something idk
          gameplaying.canSlow = false;   
        }
    }

    public void HealingFocus(float increase)
    {
        if (remainingFocus + increase <= startingFocus)
        {
            remainingFocus += increase;
        }
        else
        {
            remainingFocus = startingFocus;
        }
    }

    public void EraserDeplete(float damage)
    {
         if (remainingFocus - damage >= 0)
        {
            remainingEraser -= damage;
             
        }
        else 
        {   
          canErase = false; 
        }
    }

    
}
