﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DA.DefrnseBasic
{
    public static class Pref
    {
        public static int bestScore
        {
            set
            {
                int oldBestScore = PlayerPrefs.GetInt(Const.BEST_SCORE_PREF, 0);//lay du lieu da khai bao key o Const 
                if (oldBestScore < value)
                    PlayerPrefs.SetInt(Const.BEST_SCORE_PREF, value);//luu diem so moi cao nhat luu lai
            }
            get => PlayerPrefs.GetInt(Const.BEST_SCORE_PREF, 0);

        }

        public static int curPlayerId
        {
            set => PlayerPrefs.SetInt(Const.CUR_PLAYER_ID_PREF, value);
            get => PlayerPrefs.GetInt(Const.CUR_PLAYER_ID_PREF, 0);

        }

        public static int coins
        {
            set => PlayerPrefs.SetInt(Const.COIN_PREF, value);
            get => PlayerPrefs.GetInt(Const.COIN_PREF, 0);
        }

        public static float musicVol
        {
            set => PlayerPrefs.SetFloat(Const.MUSIC_VOL_PREF, value);
            get => PlayerPrefs.GetFloat(Const.MUSIC_VOL_PREF, 0.3f);
        }

        public static float soundVol
        {
            set => PlayerPrefs.SetFloat(Const.SOUND_VOL_PREF, value);
            get => PlayerPrefs.GetFloat(Const.SOUND_VOL_PREF, 1f);
        }

        public static  void SetBool(string key,bool value)
        {
            if (value)
                PlayerPrefs.SetInt(key, 1);
            else
                PlayerPrefs.SetInt(key, 0);
        }

      /*  public static bool GetBool(string key)
        {
            return PlayerPrefs.GetInt(key) == 1 ? true : false;
        }*/

        public static bool GetBool(string key)
        {
            int check = PlayerPrefs.GetInt(key);
            if (check == 0)
                return false;
            else if (check == 1)
                return true;

            return false;
        }
    }
}