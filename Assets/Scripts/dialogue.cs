using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using Unity.Collections;


public class dialogue : MonoBehaviour
{
    
    public TextMeshProUGUI dialogueText;
    int iin=-1;
    bool zdr = true;
    public string[] lines =
    {
        "Здрасьте",
        "Хорошо",
        "Забей",
        "Так себе"
    };
    private int index = 0;
    void Start()
    {
        dialogueText.text = lines[index];
    }
    public void NextLine()

    {
        index++;
        if (index < lines.Length)
        {
            dialogueText.text = lines[index];
        }
        else
        {
            Debug.Log("Диалог окончен");
        }
    }
    public void GoodAnswer()
    {
        iin = 0;

    }
    
    public void BadAnswer()
    {
        iin = 1;
    }
    public void FixedUpdate()
    {
        if (iin == 0)
        {
            zdr = false;
            dialogueText.text = lines[1];
           
        }
        if (iin == 1)
        {
            zdr = false;
            dialogueText.text = lines[2];
            
        }
        if (zdr == true)
        {
            dialogueText.text=lines[0];
        }


    }
}