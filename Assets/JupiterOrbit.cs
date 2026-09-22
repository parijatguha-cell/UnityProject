using UnityEngine;

public class JupiterOrbit : MonoBehaviour
{
    public float orbitSpeed = 5f;

    void Update()
    {
        transform.Rotate(0, orbitSpeed * Time.deltaTime, 0);
    }
}