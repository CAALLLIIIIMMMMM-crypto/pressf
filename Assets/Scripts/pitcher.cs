using UnityEngine;

public class pitcher : MonoBehaviour
{
    public float height;
    public float maxScale;

    public GameObject milk;
    public GameObject spawnPos;

    public Canvas canvas;

    public GameObject cup;

    public Vector3 startSize;


    private void Start()
    {
        startSize = transform.localScale;
    }


    public void SpawnMilk()
    {
        var inst = Instantiate(milk);
        inst.transform.SetParent(cup.transform);
        inst.transform.SetAsLastSibling();

        inst.transform.localScale = new Vector3(maxScale / height, maxScale / height, maxScale / height);
        inst.transform.position = spawnPos.transform.position;
    }

    public void FixedUpdate()
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, UnityEngine.Input.mousePosition, canvas.worldCamera, out var point);

        transform.localPosition = Vector3.Lerp(transform.localPosition, point, Time.deltaTime * 10);

        if (UnityEngine.Input.GetKey(KeyCode.Mouse0))
        {
            SpawnMilk();
        }

        if (UnityEngine.Input.GetKey(KeyCode.W))
        {
            height += 0.1f;
        }

        if (UnityEngine.Input.GetKey(KeyCode.S))
        {
            height -= 0.1f;
        }

        transform.localScale = Vector3.Max(startSize * height, new Vector3(3, 3, 3));
    }
}
