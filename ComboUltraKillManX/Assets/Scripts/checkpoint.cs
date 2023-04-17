using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{

    private Vector3 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = gameObject.transform.position;
    }

    
    // Update is called once per frame
    void Update()
    {
        //die if fall off map
        if(gameObject.transform.position.y < -20f)
        {
            playerDie();
        }
    }
    

    void playerDie()
    {
        gameObject.transform.position = spawnPoint;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Checkpoint")
        {
            spawnPoint = collision.gameObject.transform.position + new Vector3(0,2,0);
        }
    }
}