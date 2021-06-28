using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject back; 
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
        SceneManager.LoadScene("Gameplay");
    }

    public void QuitGame()
    {
        Application.Quit();
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
}
