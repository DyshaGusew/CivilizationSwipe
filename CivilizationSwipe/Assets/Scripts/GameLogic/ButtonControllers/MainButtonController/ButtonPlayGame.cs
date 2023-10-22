using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlayGame : MonoBehaviour
{
    public void OnPlayBut()
    {
        SceneManager.LoadScene(1);
    }
}
