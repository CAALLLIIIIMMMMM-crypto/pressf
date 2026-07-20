using UnityEditor.Build;
using UnityEngine;




using static ZakazSystem;

public class Cassa : Interactables
{
    [SerializeField] internal DialogueData[] Dialogues;
    public DialogueSystem DialoguesSystem;
    public ZakazDialogues[] zakazez;
    public int CurrentZakazIndex;

    public override void Interact(GameObject Player)
    {
        
        base.Interact(Player);
       


        if (!ZakazSystem.Instance.isZakazGoing)
        {
            if (!PlayerPrefs.HasKey("KassaTip"))
            {
                if (TipsSystem.Instance != null)
                {
                    TipsSystem.Instance.HideTip();
                }
                PlayerPrefs.SetInt("KassaTip", 1);
            }

            CurrentZakazIndex = Random.Range(0, zakazez.Length);
            if (DialogueSystem.Instance != null && zakazez.Length > 0 && zakazez[CurrentZakazIndex] != null)
            {
                DialogueSystem.Instance.StartDialogue(zakazez[CurrentZakazIndex].onStart);
            }
        }
        else
        {
            if (Coffe.Instance != null && Coffe.Instance.isDone)
            {

                ZakazSystem.Instance.Finish(Coffe.Instance.coffeData, out bool isCorrect);

                if (isCorrect)
                {
                    Debug.Log("Игрок сделал правильный кофе!");

                    if (DialogueSystem.Instance != null)
                    {
                        DialogueSystem.Instance.StartDialogue(zakazez[CurrentZakazIndex].onFinishTrue);
                    }
                }
                else
                {
                    Debug.Log("Кофе неправильный, клиент недоволен.");

                    if (DialogueSystem.Instance != null)
                    {
                        DialogueSystem.Instance.StartDialogue(zakazez[CurrentZakazIndex].onFinishFalse);
                    }
                }
            }
            else
            {
                if (DialogueSystem.Instance != null && zakazez != null)
                {
                    DialogueSystem.Instance.StartDialogue(zakazez[CurrentZakazIndex].onWait);
                }
            }
        }

    }

    public override void Uninteractable()
    {
            DialogueSystem.Instance.ForceEnd();
        Debug.Log("Uninteractable called on Cassa");
    }
}















































//uch

