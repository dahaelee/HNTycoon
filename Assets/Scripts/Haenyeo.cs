﻿using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Globalization;
using System.Diagnostics;
using System.Runtime.Versioning;

[Serializable]
public class Haenyeo : MonoBehaviour
{
    public static int money, debt, diving_time, farm_number, day, level, payed, interest, coin_time, limit_day = 30; 
    public static float hp, moving_speed;
    public static TodayState todayState = TodayState.day;
    public static int[] sea_item_number = new int[9]; //보유하고있는 자원 개수
    public Text hp_text;
    public Image hp_bg;
    public Sprite hp100, hp80, hp60, hp40, hp20, hp0;

    public static int[] farm_item_number = new int[9]; //보유하고있는 양식 자원 개수

    public static int[] item_inven = new int[4]; // 아이템 : 그물, 체력, 5m, 10m, 15m

    public enum TodayState
    {
        day,
        night
    }

    public enum sea_item_index
    {
        shell = 0,
        seaweed,
        starfish,
        shrimp,
        jellyfish,
        crab,
        octopus,
        abalone,
        turtle
    };


    public enum farm_item_index
    {
        shell= 0,
        seaweed,
        starfish,
        shrimp,
        jellyfish,
        crab,
        octopus,
        abalone,
        turtle
    };
    
    public void Start()
    {
        hp_text.GetComponent<Text>().text = Mathf.CeilToInt(hp).ToString(); // 체력 소수점 부분 버림
        Sprite hp100 = Resources.Load<Sprite>("heart100");
        Sprite hp80 = Resources.Load<Sprite>("heart80");
        Sprite hp60 = Resources.Load<Sprite>("heart60");
        Sprite hp40 = Resources.Load<Sprite>("heart40");
        Sprite hp20 = Resources.Load<Sprite>("heart20");
        Sprite hp0 = Resources.Load<Sprite>("heart0");
    }
    void Update()
    {
        if (hp <= 0)
        {
            hp = 0;
        }

        hp_text.GetComponent<Text>().text = Mathf.CeilToInt(hp).ToString(); // 체력 소수점 부분 버림
        if (hp >= 90)
        {
            hp_bg.GetComponent<Image>().sprite = hp100;
        }
        else if (hp < 90 && hp >= 70)
        {
            hp_bg.GetComponent<Image>().sprite = hp80;
        }
        else if (hp < 70 && hp >= 50)
        {
            hp_bg.GetComponent<Image>().sprite = hp60;
        }
        else if (hp < 50 && hp >= 30)
        {
            hp_bg.GetComponent<Image>().sprite = hp40;
        }
        else if (hp < 30 && hp >= 10)
        {
            hp_bg.GetComponent<Image>().sprite = hp20;
        }
        else if (hp < 10)
        {
            hp_bg.GetComponent<Image>().sprite = hp0;
        }
    }

    void SetHP()
    {
        
        
    }


}
