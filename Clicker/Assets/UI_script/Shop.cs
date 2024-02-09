using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public string objectName;
    public int price;
    public int access = 0;
    public GameObject block;
    public Text objectPrice;

    void Awake()
    {
        AccessUpdate();
    }
    public void onButtonDown()
    {
        Click.WoodValue = PlayerPrefs.GetInt("WoodValue");

        if (access == 0)
        {
            if (Click.WoodValue >= price)
            {
                PlayerPrefs.SetInt(objectName + "Access", 1);
                PlayerPrefs.SetInt("WoodValue", Click.WoodValue - price);
                AccessUpdate();
            }
        }
    }
    public void AccessUpdate()
    {
        access = PlayerPrefs.GetInt(objectName + "Access");
        objectPrice.text=price.ToString();

        if(access == 1 )
        {
            block.SetActive(false);
            objectPrice.gameObject.SetActive(false);
        }
    }
    
    
}
