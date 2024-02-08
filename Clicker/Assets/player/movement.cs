using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{

    public float moveSpeed = 5f; // �������� �������� �������
    public float maxMoveTime = 5f; // ������������ ����� �������� � ����� �����������
   

    private float currentMoveTime; // ������� ����� �������� � ����� �����������
    private int direction = 1; // ����������� �������� ������� (1 ��� �������� �����, -1 ��� �������� �����)

    private void Update()
    {
        // ��������� ����� �������� � ����� �����������
        currentMoveTime += Time.deltaTime;

        // ���� ����� �������� �������� ������������� ��������, ������ ����������� �������� � ���������� �����
        if (currentMoveTime >= maxMoveTime)
        {
            direction *= -1;
            currentMoveTime = 0f;

            // ����������� ������ �� ��� X ��� ���������
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }

        // ��������� ����� ������� ������� � ������ ����������� � ��������
        float movement = moveSpeed * direction * Time.deltaTime;
        transform.Translate(movement, 0, 0);
    }
}
