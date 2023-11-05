using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeLeft : MonoBehaviour
{
    private Animator animator; // ������ �� ��������� Animator

    private void Update()
    {
        GameObject obj = GameObject.Find("NormalCard(Clone)"); // ������� ������ �� �����
        if (obj != null)
        {
            animator = obj.GetComponent<Animator>(); // �������� ��������� Animator
        }
    }

    public void Startuem()
    {
        if (animator != null)
        {
            animator.SetBool("Left", true); // ��������� �������� ���������� � ���������
        }
    }

    public void Finish()
    {
        if (animator != null)
        {
            animator.SetBool("Left", false); // ��������� �������� ���������� � ���������
        }
    }
}
