using UnityEngine;

public class UranusOrbit : MonoBehaviour
{
    public float orbitSpeed = 3f;

    void Update()
    {
        transform.Rotate(0, orbitSpeed * Time.deltaTime, 0);
    }
}