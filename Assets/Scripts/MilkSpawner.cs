using UnityEngine;

public class MilkSpawner : MonoBehaviour
{
    [Header("Height Settings")]
    public float height = 1f;
    public float minHeight = 0.5f;
    public float maxHeight = 5f;
    public float heightStep = 0.1f;
    public float heightSmoothSpeed = 3f;
    public dragables dragables;
    [Header("Milk Settings")]
    public float maxScale = 1f;
    public float spawnCooldown = 0.05f;

    [Header("Movement Settings")]
    public float followSpeed = 15f;

    [Header("References")]
    public GameObject milk;
    public GameObject spawnPos;
    public GameObject cup;

    private Vector3 startSize;
    private float lastSpawnTime;

    private float targetHeight;
    public Animator animator;
    private Camera cam;

    public bool SpawningMilk;

    private void Start()
    {
        startSize = transform.localScale;
        height = Mathf.Clamp(height, minHeight, maxHeight);
        targetHeight = height;
        cam = Camera.main;
        dragables = GetComponent<dragables>();
    }

    private void Update()
    {
        if (dragables.isdraging == false)
        {
            animator.Play("pitcher_animation");
            SpawningMilk = false;
            return;
        }
        if (UnityEngine.Input.GetKey(KeyCode.Z))
            targetHeight = Mathf.Clamp(targetHeight + heightStep * Time.deltaTime * 10f, minHeight, maxHeight);

        if (UnityEngine.Input.GetKey(KeyCode.X))
            targetHeight = Mathf.Clamp(targetHeight - heightStep * Time.deltaTime * 10f, minHeight, maxHeight);

        height = Mathf.Lerp(height, targetHeight, Time.deltaTime * heightSmoothSpeed);

        float scaleFactor = Mathf.Max(height, 0.01f);
        transform.localScale = Vector3.Max(startSize * scaleFactor, new Vector3(1f, 1f, 1f));

        if (UnityEngine.Input.GetKey(KeyCode.Mouse1) || UnityEngine.Input.touchCount > 1)
        {
            animator.Play("pitcher_pouringW");
            if (Time.time - lastSpawnTime >= spawnCooldown)
                SpawnMilk();
            
        }
        else
        {
            animator.Play("pitcher_animation");
            SpawningMilk = false;
        }
    }

    private void SpawnMilk()
    {
        
        SpawningMilk = true;
        lastSpawnTime = Time.time;

        GameObject milkObject = Instantiate(milk);
        milkObject.transform.SetParent(cup.transform);
        milkObject.transform.SetAsLastSibling();

        float milkScale = maxScale / Mathf.Max(height, 0.01f);
        milkObject.transform.localScale = Vector3.one * milkScale;
        milkObject.transform.position = spawnPos.transform.position;
    }



    
}
