using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    [SerializeField] private Exploder exploder;
    // Start is called before the first frame update
    void Start()
    {
        exploder = GetComponent<Exploder>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (exploder != null)
        {
            exploder.Explode();
            GameObject.Destroy(exploder.gameObject);
        }
    }
}
