using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Res : MonoBehaviour
{
    public int wd;
    public Text wdText;
    
    public void Change()
    {
        wd = Click.wd2;
    }

    void FixedUpdate()
    {

        wdText.text = wd.ToString();


    }
}

  

