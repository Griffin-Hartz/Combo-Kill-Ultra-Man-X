using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    [SerializeField] private GameObject Grenade;
    [SerializeField] private float throwForce;
    private Transform trans;
    public Transform aimTrans;
    public int inventory = 100;
    public Vector3 throwAngle;
    public AudioSource throwSource;
    // Start is called before the first frame update

    private void Start()
    {
        trans = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && inventory > 0)
        {
            ThrowGrenade();
            inventory--;
        }
        Debug.DrawRay(transform.position, transform.forward, Color.red, 10f);
    }

    public void ThrowGrenade()
    {
        throwSource.Play();
        Vector3 aim = Vector3.Lerp(trans.position, aimTrans.position, 45);
        GameObject spawn = Instantiate(Grenade, trans.position + new Vector3(0,0,1), Quaternion.identity);
        //spawn.transform.LookAt(aim);
        //Quaternion rot = spawn.transform.rotation;
        //Vector3 aimVec = new Vector3(rot.x, rot.y, rot.z);
        spawn.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce, ForceMode.Impulse);

        //huck it man
    }

}
