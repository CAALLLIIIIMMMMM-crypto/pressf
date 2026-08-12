using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragables : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    public bool isdraging;
    public void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = rectTransform.root.GetComponent<Canvas>();
    }
    public void Update()
    {
        if (isdraging == false) return;
        Vector2 localPoint;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform,
            Input.mousePosition,
            canvas.worldCamera,
            out localPoint);

        rectTransform.anchoredPosition = Vector2.Lerp(
        rectTransform.anchoredPosition,
        localPoint,
        20f * Time.deltaTime);
    }   
    public void StopDrag()
    {
        isdraging = false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isdraging = true; 
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isdraging = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
    }
}
