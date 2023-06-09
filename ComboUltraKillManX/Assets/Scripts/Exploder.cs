using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    public Rigidbody rb;
    public Transform ExplosionPoint;
    [SerializeField] private float explosionPower;
    [SerializeField] private float explosionRadius;
    //public AudioClip soundClip;
    public AudioSource sound;
    private void Start()
    {
        try
        {
            rb = GetComponent<Rigidbody>();
        }
        catch { }
    }

    private void Update()
    {
        if (rb != null)
        {
            //if(rb.)
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
    }

    public void Explode()
    {
        //Debug.Log("Exploding");
        sound.Play();
        Vector3 pos = ExplosionPoint.position;
        rb.AddExplosionForce(explosionPower, pos, explosionRadius, 3.0F, ForceMode.Impulse);
    }
}
