using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class knopka_pitcher : MonoBehaviour

{
    public bool isopen;
    public bool SteamerInside;
    public Animator animator;
    public float temp;
    public bool MolokoIsExist;

    public void OnTriggerEnter2D(Collider2D other)
    {
        SteamerInside = true;
        

    }
    public void OnTriggerExit2D(Collider2D other)
    {
        SteamerInside = false;

    }
    public void Update()
    {
        if (SteamerInside == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                animator.Play("animation_stol");
                isopen = true;
            }
            if (Input.GetKeyDown(KeyCode.Space)&&isopen==true)
            {
                isopen = false;
                animator.Play("animation_neshowstol");
            }
        }


    }
   


}
