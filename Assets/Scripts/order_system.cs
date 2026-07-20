using System;
using UnityEngine;


public class ZakazSystem : MonoBehaviour
{
    public ZakazInfo currentZakaz;

    public static ZakazSystem Instance;
    public bool isZakazGoing;
    
    
    private void Start()
    {
        if (Instance == null)
            Instance = this;
    }

    public void StartZakaz(ZakazInfo zakaz)
    {
        if (isZakazGoing)
            return;

        currentZakaz = zakaz;
        isZakazGoing = true;
    }

    public void Finish(CoffeData coffeData, out bool isCorrect) 
    {
        isCorrect = IsCorrect(coffeData);
        isZakazGoing = false;

        if (Coffe.Instance != null)
        {
            Coffe.Instance.coffeData = default;
            Coffe.Instance.isDone = false;
        }
    }

    public bool IsCorrect(CoffeData coffeData)
    {
        if (currentZakaz == null || currentZakaz.CoffeData == null)
        {
            Debug.LogWarning("Нет активного заказа для проверки!");
            return false;
        }
        float tempDiff = Mathf.Abs(coffeData.temperature - currentZakaz.CoffeData.temperature);

        bool isTempCorrect = tempDiff < 1;
        bool isMilkCorrect = coffeData.isMilk == currentZakaz.CoffeData.isMilk;

        return isTempCorrect && isMilkCorrect;
    }

    public void SetZakaz(string coffeType)
    {

        ZakazInfo orderInfo = null;

        if (coffeType == "Capuchino")
        {
            orderInfo = new ZakazInfo() { CoffeData = new CoffeData() { isMilk = true, temperature = 30 } };
        }
        else if (coffeType == "Americano")
        {
            orderInfo = new ZakazInfo() { CoffeData = new CoffeData() { isMilk = false, temperature = 50 } };
        }
        if (ZakazSystem.Instance != null)
        {
            ZakazSystem.Instance.StartZakaz(orderInfo);
            Debug.Log($"Заказ на {coffeType} успешно отправлен в order_system!");
        }
        
    }

    
}

public class Coffe : MonoBehaviour 
{
    public static Coffe Instance;

    public CoffeData coffeData;
    public bool isDone;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
}

[System.Serializable]
public class CoffeData
{
    public bool isMilk;         
    public int temperature;     
}

[System.Serializable]
public class ZakazInfo
{
    public CoffeData CoffeData; 
}




//uch