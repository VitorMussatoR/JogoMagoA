using UnityEngine;
using System.Collections;

public class MagiaNormal : MonoBehaviour
{
    public float distancia = 100f;
    public float dano = 20f;

    public Transform pontoDoTiro;

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

        RaycastHit hit;

        Vector3 pontoFinal = ray.origin + ray.direction * distancia;

        if (Physics.Raycast(ray, out hit, distancia))
        {
            pontoFinal = hit.point;

            Debug.Log("Acertou: " + hit.collider.name);

            Entidade inimigo = hit.collider.GetComponent<Entidade>();

            if (inimigo != null)
            {
                inimigo.Health -= dano;
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