using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject body;
    [SerializeField] private Exploder exploder;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float moveForce;
    [SerializeField] private float jumpForce;
    [SerializeField] private Camera cam;
    [SerializeField] private Vector3 lookDir;
    [SerializeField] private Vector3[] directions;
    //public Transform left;
    //public Transform right;
    // Start is called before the first frame update
    void Start()
    {
        rb = body.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            exploder.Explode();
        }
        //if()
    }

    private void FixedUpdate()
    {
        Quaternion quat = transform.rotation;
        Vector3 right = transform.right;
        Vector3 left = -right;
        Vector3 vec = new Vector3(quat.x, quat.y, quat.z);
        //Quaternion.Lerp();

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity += transform.forward.normalized * moveForce;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity += -transform.forward.normalized * moveForce;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().velocity += left.normalized * moveForce;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().velocity += right.normalized * moveForce;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity += transform.up.normalized * jumpForce;
        }
    }
}
