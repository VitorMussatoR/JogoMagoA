using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public GameObject esferaMagica;

    public Transform pontoDoTiro;

    public float distancia = 5f;
    public float raio = 3f;
    public float dano = 40f;

    void Update()
    {
        if (!gameObject.activeSelf) return;

        if (Input.GetMouseButtonDown(0))
        {
            Atirar();
        }
    }

    void Atirar()
    {
        Vector3 posicao = pontoDoTiro.position +
                           pontoDoTiro.forward * distancia;

        
        GameObject esfera = Instantiate(
            esferaMagica,
            posicao,
            Quaternion.identity
        );

        Destroy(esfera, 0.3f);

        Collider[] objetos = Physics.OverlapSphere(
            posicao,
            raio
        );

        foreach (Collider col in objetos)
        {
            Entidade inimigo = col.GetComponent<Entidade>();

            if (inimigo != null)
            {
                inimigo.Health -= dano;
            }
        }
    }
}