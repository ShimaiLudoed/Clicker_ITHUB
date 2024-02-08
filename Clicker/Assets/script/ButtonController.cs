using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button[] buttons;
    private int currentIndex = -1;

    private void Start()
    {
        ShowNextButton();
    }

    public void OnButtonClick()
    {
        HideCurrentButton();
        ShowNextButton();
    }

    private void HideCurrentButton()
    {
        if (currentIndex >= 0 && currentIndex < buttons.Length)
        {
            buttons[currentIndex].gameObject.SetActive(false);
        }
    }

    private void ShowNextButton()
    {
        currentIndex++;

        if (currentIndex >= 0 && currentIndex < buttons.Length)
        {
            buttons[currentIndex].gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}