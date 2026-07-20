using Unity.VisualScripting;
using UnityEditor.AdaptivePerformance.Editor;
using UnityEngine;
using UnityEngine.UI;

public class kofemolkaUI : MonoBehaviour
{
    public EventTrigger slot;
    public portafilter son;
    public bool inport;
    



    private void Update()
    {
        if (slot.transform.GetChild(0).position == son.transform.position)
        {
            inport= true;
        }
        else
        {
            inport = false;
        }
        
    }
    public void ChangeSprite(Sprite sprite)
    {
        if (inport==true)
        {
            son.GetComponent<Image>().sprite = sprite;
        }
      
    }
    public void AddCoffee()
    {
        son.iscoffee = true;
    }
    
}
