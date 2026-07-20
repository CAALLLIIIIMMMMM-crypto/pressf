using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    public UnityEvent onEnter;
    public UnityEvent onExit;

    public LayerMask layer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (IsInLayerMask(other.gameObject))
        {
            onEnter?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (IsInLayerMask(other.gameObject))
        {
            onExit?.Invoke();
        }
    }

    private bool IsInLayerMask(GameObject obj)
    {
        return (layer.value & (1 << obj.layer)) != 0;
    }
}