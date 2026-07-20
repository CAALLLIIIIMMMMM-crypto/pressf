using UnityEngine;

public class tachka : MonoBehaviour
{    public portafilter borning;    public instruments instruments;
    public bool iszdes;
    public GameObject pos;
    private void Update()
    {
        if (borning.iscoffee && borning.razravnivateltouch && borning.tempertouch && iszdes==false)
        {
            if (instruments.isShow==true)
            {
                borning.transform.SetParent(transform);
                borning.transform.SetAsLastSibling();
                borning.SetPosition(pos.transform);
                iszdes=true;
                
            }
        }
        
    }
}
