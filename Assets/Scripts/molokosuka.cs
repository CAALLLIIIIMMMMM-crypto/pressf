using UnityEngine;

public class molokosuka : MonoBehaviour
{
    public dragables dragablesComponent;
    public ParticleSystem ParticleSystemComponent;
    
    public void Start()
    {
        dragablesComponent=GetComponent<dragables>();
    }
    public void Update()
    {
        if (dragablesComponent.isdraging&& Input.GetKey(KeyCode.Mouse1))
        {
            ParticleSystemComponent.gameObject.SetActive(true);
        }
        else
        {
            ParticleSystemComponent.gameObject.SetActive(false);
        }
    }
}
