using UnityEngine;

public class TipTest : MonoBehaviour
{
    private void Start()
    {
       if(PlayerPrefs.HasKey("KassaTip"))
        {
            TipsSystem.Instance.ShowTip("Подойдите к кассе и возьмите заказ");
            
        }
            
    }
}
