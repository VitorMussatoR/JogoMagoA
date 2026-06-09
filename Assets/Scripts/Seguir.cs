using UnityEngine;

public class Seguir : MonoBehaviour
{
    [Header("configura��es de Persegui��o")]

    public Transform alvo;
    public float velocidade = 5f;
    public float distanciaMinima = 1f;

    void Start()
    {

    }


    void Update()
    {
        if (alvo != null)
        {
            float distanciaAtual = Vector3.Distance(transform.position, alvo.position);
            if (distanciaAtual > distanciaMinima)
            {
                transform.position = Vector3.MoveTowards(transform.position, alvo.position, velocidade * Time.deltaTime);
            }
        }
    }
}

