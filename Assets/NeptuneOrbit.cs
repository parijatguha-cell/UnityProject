using UnityEngine;

public class NeptuneOrbit : MonoBehaviour
{
    public float orbitSpeed = 2f;

    void Update()
    {
        transform.Rotate(0, orbitSpeed * Time.deltaTime, 0);
    }
}