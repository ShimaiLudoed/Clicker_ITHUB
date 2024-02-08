using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{

    public float moveSpeed = 5f; // —корость движени€ спрайта
    public float maxMoveTime = 5f; // ћаксимальное врем€ движени€ в одном направлении
   

    private float currentMoveTime; // “екущее врем€ движени€ в одном направлении
    private int direction = 1; // Ќаправление движени€ спрайта (1 дл€ движени€ вперЄд, -1 дл€ движени€ назад)

    private void Update()
    {
        // ќбновл€ем врем€ движени€ в одном направлении
        currentMoveTime += Time.deltaTime;

        // ≈сли врем€ движени€ достигло максимального значени€, мен€ем направление движени€ и сбрасываем врем€
        if (currentMoveTime >= maxMoveTime)
        {
            direction *= -1;
            currentMoveTime = 0f;

            // «еркалируем спрайт по оси X при развороте
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }

        // ¬ычисл€ем новую позицию спрайта с учЄтом направлени€ и скорости
        float movement = moveSpeed * direction * Time.deltaTime;
        transform.Translate(movement, 0, 0);
    }
}
