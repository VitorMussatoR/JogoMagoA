using UnityEngine;

public class Bala : MonoBehaviour
{
    public float dano = 20f;

    private void OnCollisionEnter(Collision collision)
    {
        Entidade inimigo = collision.gameObject.GetComponent<Entidade>();

        if (inimigo != null)
        {
            inimigo.Health -= dano;
        }

        Destroy(gameObject);
    }
}