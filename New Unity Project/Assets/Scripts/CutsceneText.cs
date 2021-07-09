using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CutsceneText : MonoBehaviour
{

    public TextMeshProUGUI textComponent;

    public string[] lines;

    public float typeSpeed;

    int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        StartDialogue();
        textComponent.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(typeSpeed);
        }
    }
}
