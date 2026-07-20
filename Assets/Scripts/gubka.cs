using UnityEngine;
using UnityEngine.UIElements;


public class gubka : MonoBehaviour
{
    public float radius;
    public LayerMask layer;
    public Vector3 _lastpos;

    private void Update()
    {
        Collider2D col = Physics2D.OverlapCircle(transform.position, radius, layer);

        if (col != null)
        {
            dirty_dishes posuda = col.GetComponent<dirty_dishes>();
            if (posuda != null)
            {
                posuda.Clean();
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
