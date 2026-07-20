using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class temperaturesuka : MonoBehaviour
{
    public ParticleSystem hotmilk;
    public Slider SliderVariable;
    public knopka_pitcher pitcherVariable;
    public TMP_Text TextTemperature;
    public float speed=1;
    public float speedmnogo = 1;

    public void Update()
    {
       
        if (pitcherVariable.SteamerInside&&SliderVariable.value==SliderVariable.maxValue&&pitcherVariable.MolokoIsExist)
        {
            float CurrentTemp = pitcherVariable.temp;
            CurrentTemp += Time.deltaTime * speed*speedmnogo;
            CurrentTemp = Mathf.Clamp(CurrentTemp, 0, 80);
            TextTemperature.text = $"{(int)CurrentTemp}°";
           pitcherVariable.temp = CurrentTemp;
            if (CurrentTemp>=60)
            {
                hotmilk.gameObject.SetActive(true);
            }
            if (CurrentTemp >= 49)
            {
                speedmnogo = 1.5f;
            }

           
        }
        else hotmilk.gameObject.SetActive(false);
        
           
    }



    //public bool isopen;
    //public bool SteamerInside;
    //public Animator animator;
    //public float temp;
    //public bool MolokoIsExist;
}
