using UnityEngine;
using UnityEngine.Events;



[CreateAssetMenu(fileName = "DialogueData", menuName = "Game/Data")]
public class DialogueData : ScriptableObject
{
    public TextData[] textData;

    public void SetZakaz(string coffeType)
    {
        ZakazInfo orderInfo = null;

        if (coffeType == "Capuchino")
        {
            orderInfo = new ZakazInfo()
            {
                CoffeData = new CoffeData()
                {
                    isMilk = true,         
                    temperature = 60    
                }
            };
        }
        else if (coffeType == "Americano")
        {
            orderInfo = new ZakazInfo()
            {
                CoffeData = new CoffeData()
                {
                    isMilk = false,        
                    temperature = 50       
                }
            };
        }
        if (ZakazSystem.Instance != null)
        {
            ZakazSystem.Instance.StartZakaz(orderInfo);
        }
       

    }
    [System.Serializable]
    public class TextData
    {
        [TextArea] public string text;
        public UnityEvent OnTextReaded;
    }
}


