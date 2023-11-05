using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeRight2 : MonoBehaviour
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
            animator.SetBool("Right", true); // ��������� �������� ���������� � ���������
        }
    }

    public void Finish()
    {
        if (animator != null)
        {
            animator.SetBool("Right", false); // ��������� �������� ���������� � ���������
        }
    }
}