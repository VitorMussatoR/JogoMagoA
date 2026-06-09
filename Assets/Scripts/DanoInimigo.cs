using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DanoInimigo : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float radius = 0.3f;
    public float range = 10;

    public LayerMask playerLayer;

    void Update()
    {
        DetectPlayer();
    }

    void DetectPlayer()
    {
        RaycastHit hit;

        bool detected = Physics.CapsuleCast(pointA.position, pointB.position, radius, transform.forward, out hit, range, playerLayer);
         if (detected && hit.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
