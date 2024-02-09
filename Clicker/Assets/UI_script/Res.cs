using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Res : MonoBehaviour
{
    public static int wd;
    public Text wdText;
    public void addwd()
    {
        
        wd = PlayerPrefs.GetInt("WoodValue");
    }
    public int rk;
    public Text rkText;
    public void addwrk()
    {
        rk = PlayerPrefs.GetInt("RockValue");
    }
    void FixedUpdate()
    {
        wdText.text = Click.WoodValue.ToString();
        rkText.text = Click.RockValue.ToString();
    }
}