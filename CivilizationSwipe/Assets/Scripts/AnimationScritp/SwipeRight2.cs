using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeRight2 : MonoBehaviour
{
    private Animator animator; // ������ �� ��������� Animator

    private void FindAnimat()
    {
       // GameObject obj = GameObject.Find("NormalCard(Clone)"); // ������� ������ �� �����
        //if (obj != null)
        //{
            animator = MainStorage.thisGameCard.GetComponent<Animator>(); // �������� ��������� Animator
       // }
    }

    public void Startuem()
    {
        Finish();
        FindAnimat();
        if (animator != null)
        {
            animator.SetBool("Right", true); // ��������� �������� ���������� � ���������
        }
    }

    public void Finish()
    {
        FindAnimat();
        if (animator != null)
        {
            animator.SetBool("Right", false); // ��������� �������� ���������� � ���������
        }
    }
}