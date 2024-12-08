using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class canskor : MonoBehaviour
{
    public static canskor instance;

    public static int can = 3;
    public static int skor;
    public TMP_Text skoryazi;
    public TMP_Text canyazi;
    private void Awake()
    {
        instance = this;
        canyazi.SetText("Can: " + can.ToString());
        skoryazi.SetText("Skor: " + skor.ToString());
    }
    public void CanAzalt()
    {
        can--;
        canyazi.SetText("Can: " + can.ToString());
    }
    public void SkorArtir()
    {
        skor++;
        skoryazi.SetText("Skor: " + skor.ToString());
    }
}