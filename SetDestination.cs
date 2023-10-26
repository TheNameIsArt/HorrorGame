using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDestination : MonoBehaviour
{

    [SerializeField] private float chaseRange;
    [SerializeField] private Transform target;
    [SerializeField] private UnityEngine.AI.NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var distanceToTarget = Vector3.Distance(transform.position, target.position);

        if (distanceToTarget < chaseRange)
        {
            navMeshAgent.SetDestination(target.position);
        }


    }
}
