using UnityEngine;

public class MarsOrbit : MonoBehaviour
{
    public float orbitSpeed = 8f;

    void Update()
    {
        transform.Rotate(0, orbitSpeed * Time.deltaTime, 0);
    }
}
