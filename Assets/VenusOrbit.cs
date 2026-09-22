using UnityEngine;

public class VenusOrbit : MonoBehaviour
{
    public float orbitSpeed = 12f;

    void Update()
    {
        transform.Rotate(0, orbitSpeed * Time.deltaTime, 0);
    }
}