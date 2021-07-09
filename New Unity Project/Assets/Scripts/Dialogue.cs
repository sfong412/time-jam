using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI textComponent2;

    public GameObject direction;
    public float textSpeed;

    [SerializeField]public int index;
    [SerializeField]public int index2;

    public audioFix2 cutscene;

    public CharacterController2D1 player;

    public DialogueManager dialogueManager;

    public int indexCap;

    public int index3;

    public bool startNextThing;

    public int[] nextDialogueCap;


    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        
    }

    void Awake()
    {
        StartCoroutine(sus());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (textComponent.text == dialogueManager.lines[index])
            {
                NextLine();
            }
        else
        {
            StopAllCoroutines();
            textComponent.text = dialogueManager.lines[index];
        }
        }

       

        
       
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
        cutscene.textPlaying = true;
        player.MovementSpeed = 0;
        player.JumpForce = 0;
    }

    void NextLine()
    {
        if (index < indexCap)
        {
            cutscene.textPlaying = true;
            player.MovementSpeed = 0;
            player.JumpForce = 0;
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            transform.localScale = new Vector3(0, 0, 0);
            cutscene.textPlaying = false;
            StartCoroutine(instructions());
        }
    }

    public void NextEvent()
    {
        dialogueManager.complete = false;
         if (startNextThing == true)
        {
            dialogueManager.complete = false;
            index3 += 1;
            indexCap += nextDialogueCap[index3];
            index2 += 1;
            direction.SetActive(false);
            transform.localScale = new Vector3(1.44f, 1.44f, 0);
            NextLine();
            startNextThing = false;
            Debug.Log("what");
            dialogueManager.eventNumber += 1;
             
        }
    }

    IEnumerator TypeLine()
    {
        foreach(char c in dialogueManager.lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    IEnumerator sus()
    {
        yield return new WaitForSeconds(0.7f);
        StartDialogue();
    }

    IEnumerator instructions()
    {
        textComponent2.text = dialogueManager.lines2[index2];
        yield return new WaitForSeconds(0.5f);
        direction.SetActive(true);
         player.MovementSpeed = 5;
        player.JumpForce = 1.5f;

    }
}
