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
    }

    public void ThrowGrenade()
    {
        Vector3 aim = Vector3.Lerp(trans.position, aimTrans.position, 45);
        GameObject spawn = Instantiate(Grenade, trans.position + new Vector3(0,0,1), Quaternion.identity);
        spawn.GetComponent<Rigidbody>().AddForce(aim * throwForce);
        //huck it man
    }

}
