using UnityEngine;

public class Entidade : MonoBehaviour
{
    public float Health = 100f;

    void Update()
    {
        if (Health <= 0f)
        {
            Destroy(gameObject);
        }
    }
}