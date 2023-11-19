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
    public void SwipeLeftCard()
    {
        // ������� ������ �� �����
        GameObject obj = GameObject.Find("NormalCard(Clone)");

        // ���������, ������ �� ������
        if (obj != null)
        {
            obj.name = "Card";

            // �������� ��������� SpriteRenderer
            SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();

            // ���� ��������� ������, ���������� order layer
            if (spriteRenderer != null)
            {
                spriteRenderer.sortingOrder = 10;
            }

            FindAnimat();
        }
    }
    public void SwipeLeftDelete()
    {
        // ������� ������ �� �����   
        GameObject obj = GameObject.Find("Card");

        // �������� ��������� ��������� �������   
        Animator Animarotlocal = obj.GetComponent<Animator>();

        // ������ �������� ���������� DropLeft �� true   
        Animarotlocal.SetBool("DropLeft", true);

        // ��������� ��������   
        StartCoroutine(WaitForAnimation(Animarotlocal, "DropLeft"));
    }

    private IEnumerator WaitForAnimation(Animator animator, string animationName)
    {
        animator.Play(animationName);

        // �������� � ��� �������   
        yield return new WaitForSeconds(0.5f);

        // ������� ������ ����� ��������� ��������  
        Destroy(animator.gameObject);
    }
}
