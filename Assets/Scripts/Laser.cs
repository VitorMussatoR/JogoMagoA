using UnityEngine;
using UnityEngine.SceneManagement;

public class Laser : MonoBehaviour
{
    public float distanciaLaser = 20f;

    void Update()
    {
        RaycastHit hit;

       
        Debug.DrawRay(
            transform.position,
            transform.forward * distanciaLaser,
            Color.red
        );

      
        if (Physics.Raycast(
            transform.position,
            transform.forward,
            out hit,
            distanciaLaser))
        {
        
            if (hit.collider.CompareTag("Player"))
            {
                SceneManager.LoadScene(
                    SceneManager.GetActiveScene().buildIndex
                );
            }
        }
    }
}