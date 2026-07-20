using UnityEngine;


public class ClickToOpen : MonoBehaviour
{
    public GameObject CanvasUI;
      void OnMouseDown()
    {
        CanvasUI.SetActive(true);
    }
}
