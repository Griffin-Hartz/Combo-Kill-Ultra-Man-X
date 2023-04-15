using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Gameplay;
using UnityEngine;

public class DashFunction : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerCharacterController characterController;
    public Rigidbody rb;
    public float DashMultiplier = 10;
    public bool isDashing;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(gameObject.transform.forward * 10);
        }*/
        if (Input.GetKeyDown(KeyCode.F))
        {
            Dash();
        }
    }

    private void Dash()
    {
        //characterController.enabled = false;
        Quaternion quat = Camera.main.transform.rotation;
        Vector3 force = new Vector3(quat.x, quat.y, quat.z);
        Debug.Log("DashClick");
        rb.AddForce(force * DashMultiplier, ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        
    }
}
