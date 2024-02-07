using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public int wood;
    public int rock;
    public int iron;
    public int rope;
    public int cloth;
    public Text woodText;
    public Text rockText;
    public Text ironText;
    public Text ropeText;
    public Text clothText;

    public void addwood()
    {
        wood += 1;
    }
    public void addwrock()
    {
        rock += 1;
    }
    public void addiron()
    {
        iron += 1;
    }
    public void addrope()
    {
        rope += 1;
    }
    public void addcloth()
    {
        cloth += 1;
    }
    void FixedUpdate()
    {
        woodText.text = wood.ToString();
        rockText.text = rock.ToString();
        ironText.text = iron.ToString();
        ropeText.text = rope.ToString();
        clothText.text = cloth.ToString();
    }
}
