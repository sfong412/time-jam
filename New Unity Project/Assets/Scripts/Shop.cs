using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;

public class Shop : MonoBehaviour
{
    public GameObject blackFade;
    UIThings2 ui;

    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.Find("Selectors").GetComponent<UIThings2>();

        if (UIThings2.blockTypeLoadout == null)
        {
            UIThings2.blockTypeLoadout = new int[5] { 1, 2, 3, 4, 5 };
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(UIThings2.blockTypeLoadout[1]);
    }

    void Awake()
    {
        StartCoroutine(blackFade22());
    }

    public void GetItem()
    {
        UIThings2.blockTypeLoadout[1] = 5;
        UIThings2.loadouts[2].sprite = ui.blockType5;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(3);
    }

    IEnumerator blackFade22()
    {
        yield return new WaitForSeconds(1);
        blackFade.SetActive(false);
    }
}
