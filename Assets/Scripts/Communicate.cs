using UnityEngine;

public class Communicate: MonoBehaviour
{
    public LayerMask Layer;
    public float Radius;
    public void Update()

    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D coll = Physics2D.OverlapCircle(transform.position, Radius, Layer);
            
            if (coll != null)
            {
                Interactables interactive = coll.gameObject.GetComponent<Interactables>();
                interactive.Interact(gameObject);//oshibka?
                
            }
        }

    }
}
