using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void OnPlayBut()
    {
        SceneManager.LoadScene(1);
    }
}
