using UnityEngine;

public class SaturnOrbit : MonoBehaviour
{
    public float orbitSpeed = 4f;

    void Update()
    {
        transform.Rotate(0, orbitSpeed * Time.deltaTime, 0);
    }
}