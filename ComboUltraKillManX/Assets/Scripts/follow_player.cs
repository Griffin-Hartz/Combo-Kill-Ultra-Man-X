using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{
    private GameObject player;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.AI.NavMeshAgent>().destination = player.transform.position;
    }
}
