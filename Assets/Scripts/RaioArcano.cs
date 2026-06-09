using UnityEngine;
using System.Collections;

public class RaioArcano : MonoBehaviour
{
    public Transform pontoDoTiro;

    public float distancia = 100f;
    public float dano = 30f;

    public LineRenderer linha;

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
        Ray ray = new Ray(
            pontoDoTiro.position,
            pontoDoTiro.forward
        );

        RaycastHit[] hits = Physics.RaycastAll(ray, distancia);

        Vector3 pontoFinal = ray.origin + ray.direction * distancia;

    
        foreach (RaycastHit hit in hits)
        {
            Debug.Log("Acertou: " + hit.collider.name);

            Entidade inimigo = hit.collider.GetComponent<Entidade>();

            if (inimigo != null)
            {
                inimigo.Health -= dano;
            }

           
            if (hit.distance < distancia)
            {
                pontoFinal = hit.point;
            }
        }

        StartCoroutine(MostrarLaser(ray.origin, pontoFinal));
    }

    IEnumerator MostrarLaser(Vector3 inicio, Vector3 fim)
    {
        linha.enabled = true;

        linha.SetPosition(0, inicio);
        linha.SetPosition(1, fim);

        yield return new WaitForSeconds(0.05f);

        linha.enabled = false;
    }
}