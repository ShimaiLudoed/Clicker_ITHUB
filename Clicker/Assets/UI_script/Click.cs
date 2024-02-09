using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    public int wdshop;
    public static int WoodValue;
    public Text WoodValueText;
    public void addwood()
    {
        wdshop += 1;
        WoodValue += 1;
        PlayerPrefs.SetInt("WoodValue", WoodValue);
        
    }
    public static int RockValue;
    public Text RockValueText;
    public void addrock()
    {
        RockValue += 1;
        PlayerPrefs.SetInt("RockValue", RockValue);
    }

    void FixedUpdate()
    {
        WoodValueText.text = WoodValue.ToString(); 
        RockValueText.text = RockValue.ToString();
    } 
}


