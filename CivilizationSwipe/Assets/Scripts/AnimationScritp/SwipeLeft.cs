using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeLeft : MonoBehaviour
{
    private Animator animator; // ������ �� ��������� Animator

    private void FindAnimat()
    {
       // GameObject obj = GameObject.Find("NormalCard(Clone)"); // ������� ������ �� �����
       // if (obj != null)
        //{
            animator = MainStorage.thisGameCard.GetComponent<Animator>(); // �������� ��������� Animator
      //  }
    }

    public void Startuem()
    {
        FindAnimat();
        if (animator != null)
        {
            animator.SetBool("Left", true); // ��������� �������� ���������� � ���������
        }
    }

    public void Finish()
    {
        FindAnimat();
        if (animator != null)
        {
            animator.SetBool("Left", false); // ��������� �������� ���������� � ���������
        }
    }
}
