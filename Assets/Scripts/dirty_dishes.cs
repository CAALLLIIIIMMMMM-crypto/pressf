using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
[RequireComponent(typeof(CanvasGroup))]
public class dirty_dishes : MonoBehaviour
{
    public float cleanTime = 3f;
    public float currentCleanTime = 0f;

    private CanvasGroup canvasGroup;
    private bool isFullyCleaned = false;

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1f;
    }

    public void Clean()
    {
        if (isFullyCleaned) return;
        currentCleanTime += Time.deltaTime;
        float progress = currentCleanTime / cleanTime;
        canvasGroup.alpha = 1f - progress;
        if (currentCleanTime >= cleanTime)
        {
            isFullyCleaned = true;
            canvasGroup.alpha = 0f; 
            FinishCleaning();
        }
    }

    private void FinishCleaning()
    {
        Collider2D col = GetComponent<Collider2D>();
        if (col != null) col.enabled = false;

        Destroy(gameObject);
    }
}