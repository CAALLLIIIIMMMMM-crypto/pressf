using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class portafilter : MonoBehaviour
{
    public bool razravnivateltouch;
    public bool tempertouch;
    public bool iscoffee;
    public void SetPosition(Transform pos)
    {
        GetComponent<RectTransform>().position = pos.position;
    }
    public void Razravnit()
    {
        if(iscoffee==true) 
            razravnivateltouch = true;
    }
    public void temperit(Sprite sprite)
    {
        if (iscoffee == true && razravnivateltouch == true)
        {
            tempertouch=true;
            GetComponent<Image>().sprite = sprite;
        }
        
    }
}
