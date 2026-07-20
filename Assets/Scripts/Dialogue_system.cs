using TMPro;
using UnityEngine;

using TMPro;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    public ShowHideDialogue ShowHideDialogue;
    public DialogueData data;
    public TMP_Text textField;
    public int curr;
    public bool isGoing = false;
    public Animator animator;
    public static DialogueSystem Instance;
    public void ForceEnd()
    {
        isGoing = false;
        curr = 0;
        animator.Play ("Animation end");
    }

    private void Start()
    {
        Instance = this;
        if (textField == null)
        {
            textField = GetComponentInChildren<TMPro.TMP_Text>();
        }
    }

    public void StartDialogue(DialogueData dialogue)
    {
        if (dialogue == null)
        {
            Debug.LogError("Касса передала пустой диалог!");
            return;
        }

        if (isGoing) return;

        data = dialogue;
        curr = 0;
        isGoing = true;
        ShowNext();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGoing)
        {
            ShowNext();
        }
    }

    public void ShowNext()
    {

        if (data == null || data.textData == null || data.textData.Length == 0)
        {
            isGoing = false;
            return;
        }

        if (curr == data.textData.Length)
        {
            
            isGoing = false;
            animator.Play("Animation end");
            return;
        }
        
        if (textField != null) textField.text = data.textData[curr].text;
        if (data.textData[curr] != null)
        {
            data.textData[curr].OnTextReaded?.Invoke();
        }
        animator.Play("New Animation01");
        curr++;
        
    }
}















//public class ShowHideDialogue : MonoBehaviour
//{
//    public Animator animator;

//    public bool isShow;

//    void Start()
//    {

//    }

//    void Update()
//    {
//        if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
//        {
//            isShow = !isShow;

//            if (isShow)
//                animator.Play("ShowDialogue");
//            else
//            {
//                animator.Play("HideDialogue");
//            }
//        }
//    }
//}

























//uch