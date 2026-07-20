using UnityEngine;

public class instruments : Interactables
{
    public string showanim, closeanim;
    public Animator animator;
    public bool isShow;
    public override void Interact(GameObject Player)
    {
        isShow = !isShow;
        if (isShow == true)
        {
            animator.Play(showanim);
        }
        else
        {
            animator.Play(closeanim);
        }
        base.Interact(Player);

    }
    public override void Uninteractable()
    {
        animator.Play(closeanim);
        isShow = false;
    }
    

}
