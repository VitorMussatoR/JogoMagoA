using UnityEngine;

public class TrocarArma : MonoBehaviour
{
    public GameObject armaNormal;
    public GameObject shotgun;

    public GameObject RaioArcano;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            armaNormal.SetActive(true);
            shotgun.SetActive(false);
            RaioArcano.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            armaNormal.SetActive(false);
            shotgun.SetActive(true);
            RaioArcano.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            armaNormal.SetActive(false);
            shotgun.SetActive(false);
            RaioArcano.SetActive(true);
        }
    }
}