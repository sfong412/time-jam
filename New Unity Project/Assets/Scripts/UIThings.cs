using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIThings : MonoBehaviour
{

    public bool Timer;
    [SerializeField] Image uiFill;
    [SerializeField] Text uiText;

    public int Duration;
    [SerializeField]private float remainingDuration;
    // Start is called before the first frame update
    void Start()
    {
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
        //End Time do something idk
    }
}
