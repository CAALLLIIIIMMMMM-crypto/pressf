using UnityEngine;

[CreateAssetMenu(fileName = "ZakazDialogue", menuName = "Game/Zakaz")]
public class ZakazDialogues : ScriptableObject
{
    public DialogueData onStart;
    public DialogueData onWait;
    public DialogueData onFinishTrue;
        public DialogueData onFinishFalse;

}
 