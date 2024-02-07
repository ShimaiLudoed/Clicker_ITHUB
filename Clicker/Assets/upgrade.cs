using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addlvl_wood : MonoBehaviour
{
    public int level_wood;
    public Text wood_lvlText;
    
    public void upgrade_wood()
    {
        level_wood += 1; 
    }

    void FixedUpdate()
    {
        wood_lvlText.text = level_wood.ToString();
    }
}
