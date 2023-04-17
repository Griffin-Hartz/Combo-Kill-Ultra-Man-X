using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    public Rigidbody rb;
    public Transform ExplosionPoint;
    [SerializeField] private float explosionPower;
    [SerializeField] private float explosionRadius;

    private void Start()
    {
        try
        {
            rb = GetComponent<Rigidbody>();
        }
        catch { }
    }

    public void Explode()
    {
        //Debug.Log("Exploding");
        Vector3 pos = ExplosionPoint.position;
        rb.AddExplosionForce(explosionPower, pos, explosionRadius, 3.0F, ForceMode.Impulse);
    }
}
