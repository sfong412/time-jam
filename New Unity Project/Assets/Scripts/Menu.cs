using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject back; 

    public GameObject blackFade;

    public GameObject downed;

    public GameObject downed2;

    public GameObject upped;
    public GameObject upped2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
       StartCoroutine(startGame());
    }

    public void QuitGame()
    {
        StartCoroutine(quitGame());
    }

    public void Settings()
    {
        mainMenu.SetActive(false);
        back.SetActive(true);
    }

    public void Back()
    {
        back.SetActive(false);
        mainMenu.SetActive(true);
    }

    IEnumerator startGame()
    {
        blackFade.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }

    IEnumerator quitGame()
    {
         blackFade.SetActive(true);
        yield return new WaitForSeconds(1);
        Application.Quit();
    }

}
