using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIThings : MonoBehaviour
{

    public bool Timer;
    [SerializeField] Image uiFill;
    [SerializeField] Text uiText;

    public int Duration;

    public bool stopping;

    public int currentScene;

    public Animator blackFade;

    public GameObject blackFade2;

    public GameObject shadow;
    public GameObject Text1;
    public GameObject Text2;
    [SerializeField]private float remainingDuration;
    // Start is called before the first frame update
    
    void Awake()
    {
         stopping = false;
         Being(Duration);
    }

    // Update is called once per frame
    void Being(int Second)
    {
        remainingDuration = Second;
        StartCoroutine(UpdateTimer()); 
    }

    void Update()
    {
        uiFill.fillAmount = Mathf.InverseLerp(1, Duration, remainingDuration);
    }

    IEnumerator UpdateTimer()
    {
        while(remainingDuration >= 0)
        {
            uiText.text = $"{remainingDuration / 60:00}:{remainingDuration % 60:00}";
            yield return new WaitForSeconds(1f);
        }
        OnEnd();
    }

    void FixedUpdate()
    {
          remainingDuration -= 1 * Time.fixedDeltaTime;
    }

    private void OnEnd()
    {
        stopping = true;
        shadow.SetActive(false);
        StartCoroutine(UIAnimations());
    }

    IEnumerator UIAnimations()
    {
        blackFade.SetBool("transistion", true);
        yield return new WaitForSeconds(0.5f);
        Text1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Text2.SetActive(true);

    }

    IEnumerator NextRound1()
    {
        blackFade2.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(currentScene + 1);
    }

    public void NextRound()
    {
        StartCoroutine(NextRound1());
    
    }
}
