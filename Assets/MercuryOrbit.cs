using UnityEngine;

public class MercuryOrbit : MonoBehaviour
{
    public float orbitSpeed = 20f;

    void Update()
    {
        transform.Rotate(0, orbitSpeed * Time.deltaTime, 0);
    }
}