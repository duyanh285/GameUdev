﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DA.DefrnseBasic
{
    public class GUIManager : MonoBehaviour
    {
        public GameObject homeGUI;
        public GameObject gameGUI;
        public Dialog gameoverDialog;
        public Text mainCoinTxt;
        public Text gameplayCoinTxt;

        // Start is called before the first frame update
        void Start()
        {

        }

        public void ShowGameGui(bool isShow)
        {
            if (gameGUI)
                gameGUI.SetActive(isShow);
            if (homeGUI)
                homeGUI.SetActive(!isShow);
        }

        public void UpdateMainCoins()
        {
            if (mainCoinTxt)
                mainCoinTxt.text = Pref.coins.ToString();
        }

        public void UpdateGameplayCoins()
        {
            if (gameplayCoinTxt)
                gameplayCoinTxt.text = Pref.coins.ToString();
        }


    }
}