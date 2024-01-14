using UnityEngine;

//Closing the window
public class CloseCanvas : MonoBehaviour
{
    public GameObject canvasSetting;
    public void Click()
    {
        Pashalka.counter = 0;
        canvasSetting.SetActive(false);
    }
}
