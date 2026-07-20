using UnityEngine;

public class Interactables : MonoBehaviour
{
    public bool isinteract;
    public GameObject CurrentPlayer;
    public float Distance = 3;
    public virtual void Interact(GameObject Player) 
    {
        CurrentPlayer = Player;
        isinteract = true;
    }
    public virtual void Uninteractable()
    {

    }
    public void Update()
    {
        if (isinteract==false) return;
        if (Vector3.Distance(CurrentPlayer.transform.position, transform.position)>Distance&&isinteract==true)
        {
            Uninteractable();
            isinteract = false;

        }
    }

    //



}
