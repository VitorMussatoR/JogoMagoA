using UnityEngine;
using System.Collections;
public class Gerar : MonoBehaviour{


public GameObject objetoOriginal;
    public int limiteMaximo = 20;
    private int quantidadeAtual = 0;

    void Start()
    {
        StartCoroutine(GerarObjetos());
    }

    IEnumerator GerarObjetos()
    {
        while (quantidadeAtual < limiteMaximo)
        {
            float xAleatorio = Random.Range(-22.39f, 23.57f);
            float zAleatorio = Random.Range(-25.69f, 22.57f);
            float y = 32f;
            Vector3 posicaoFinal = new Vector3(xAleatorio, y, zAleatorio);

            Instantiate(objetoOriginal, posicaoFinal, Quaternion.identity);
            quantidadeAtual++;

            yield return new WaitForSeconds(1.0f);
        }
    }
}

