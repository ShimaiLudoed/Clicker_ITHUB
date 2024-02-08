using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    public int wood;
    public static int wd2;
    public Text woodText;
    public Text wd2Text;
 
    public void addwood()
    {        
        wood += 1;

    }
    
    public void Change()
    {
        wd2 += wood;
    }
    
  
    void FixedUpdate()
    {

        woodText.text = wood.ToString();
        wd2Text.text = wd2.ToString();
        
    }
}
