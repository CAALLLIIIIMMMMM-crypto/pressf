using System;
using TMPro;
using UnityEngine;

public class TipsSystem : MonoBehaviour
{
        public TMP_Text TMPText;

        public bool isShown;

        public static TipsSystem Instance;

        public Animator tipAnim;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
        }

        public void ShowTip(string tip)
        {
        if (!isShown)
        {
            TMPText.text = tip;
            return;
        }
        tipAnim.Play("Show");
        isShown = true;
        TMPText.text = tip;
    }
    public void HideTip()
    {
        tipAnim.Play("Hide"); isShown = false;
        TMPText.text = "";
    }

    
}

