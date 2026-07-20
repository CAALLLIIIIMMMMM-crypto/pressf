using UnityEngine;

public class particlesuka : MonoBehaviour
{
    public void OnParticleCollision(GameObject other)
    {
        if (other.TryGetComponent(out knopka_pitcher pitcher))
        {
            pitcher.MolokoIsExist = true;
        }
    }
}
