using System;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //public GameObject body;
    public GameObject explosionPoint;
    public Camera cam;

    public float mouseSensitivity = 100.0f;
    public float clampAngle = 80.0f;

    private float rotY = 0.0f; // rotation around the up/y axis
    private float rotX = 0.0f; // rotation around the right/x axis

    public bool following = false;

    [SerializeField] private float _speed = 7f;
    [SerializeField] private float _mouseSensitivity = 50f;
    [SerializeField] private float _minCameraview = -70f, _maxCameraview = 80f;
    private CharacterController _charController;
    private Camera _camera;
    private float xRotation = 0f;

    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX += mouseY * mouseSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;
        //body.transform.rotation = localRotation;
        //Vector3 forward = transform.forward;
        //Debug.Log("Forward: " + forward);
        //explosionPoint.transform.position = -forward;
        //explosionPoint.transform.position = cam.transform.forward * -1;
    }
}