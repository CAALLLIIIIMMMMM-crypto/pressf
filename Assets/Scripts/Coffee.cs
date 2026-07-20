using UnityEngine;

public class Coffee : MonoBehaviour
{
    public CoffeData coffeeData;
    public static Coffee instance;
    public bool IsDone;
    public void Start()
    {
        if (instance == null)
            instance = this;
    }
    
    public void AddMilk()
    {
        coffeeData.isMilk = true;
    }
    public void SetTemperature(float temp)
    {
        coffeeData.temperature = (int)temp;
    }
}
