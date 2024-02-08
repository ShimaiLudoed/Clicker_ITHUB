using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    public int wood;
    public static int WoodValue;
    public Text woodText;

    public void addwood()
    {
        wood += 1;
        PlayerPrefs.SetInt("WoodValue", WoodValue);
    }

    void FixedUpdate()
    {
        woodText.text = wood.ToString();

    }
}
public class Res : MonoBehaviour
{
    public int wd;
    public Text wdText;

    public void addwd()
    {
       
        wd = PlayerPrefs.GetInt("WoodValue");
    }

    void FixedUpdate()
    {
        wdText.text = wd.ToString();
    }
}

