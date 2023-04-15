using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNav : MonoBehaviour
{
    [SerializeField] private Transform movePosTrans;
    private NavMeshAgent navAgent;
    private void Awake()
    {
        navAgent= GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        navAgent.destination = movePosTrans.position;
    }
}
