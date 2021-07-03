using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;

public class Shop : MonoBehaviour
{
    public int coinAmount;

    TextMeshProUGUI coinCounter;

    UIThings2 ui;

    // Start is called before the first frame update
    void Start()
    {
        coinAmount = 1500;

        UIThings2.blockTypeLoadout = new int[5] { 1, 2, 3, 4, 5 };
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(UIThings2.blockTypeLoadout[1]);
    }

    public void BuyItem(int itemCost)
    {
        if (coinAmount >= itemCost)
        {
            coinAmount = coinAmount - itemCost;
            UIThings2.blockTypeLoadout[1] = 5;
         //   UIThings2.loadout2.sprite = ui.blockType5;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
