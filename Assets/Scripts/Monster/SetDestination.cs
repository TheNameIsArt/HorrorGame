using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class SetDestination : MonoBehaviour
{
    // SerializeField gør man kan sætte en værdi på i Unity
    [SerializeField] private float chaseRange; // hvornår monster skal begynde at jage
    [SerializeField] private Transform target; // hvem er target
    [SerializeField] private UnityEngine.AI.NavMeshAgent navMeshAgent; //hvem skal jage
    [SerializeField] private float speedWalk;

    void Update() // calculates the distance between game object position and target position
    {
        // transform.position = game object's position
        // target.position = target's position
        var distanceToTarget = Vector3.Distance(transform.position, target.position); 

        // distance is stored in distanceToTarget
        if (distanceToTarget < chaseRange) // if the distance is less than chaseRange, the character is within the specified chase range, and it sets the destination for the navMeshAgent to the target.position. The enemy will then start chasing
        {
            navMeshAgent.SetDestination(target.position);
            navMeshAgent.speed = speedWalk;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Player")
        {
            SceneManager.LoadScene("HorrorGame");
        }
    }
}
