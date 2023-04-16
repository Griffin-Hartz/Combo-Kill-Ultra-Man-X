using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject body;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float moveForce;
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
    /*void Update()
    {
        /*lookDir = new Vector3(cam.transform.rotation.x, cam.transform.rotation.y, cam.transform.rotation.z).normalized;
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("dubyah");
            rb.AddForce(transform.forward * moveForce);
        }*/
        /*if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce( * moveForce);
        }*/

        /*float xMove = Input.GetAxisRaw("Horizontal"); // d key changes value to 1, a key changes value to -1
        float zMove = Input.GetAxisRaw("Vertical"); // w key changes value to 1, s key changes value to -1

        rb.velocity = new Vector3(xMove, rb.velocity.y, zMove) * moveForce; // Creates velocity in direction of value equal to keypress (WASD). rb.velocity.y deals with falling + jumping by setting velocity to y. 

    }*/

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
    }
}
