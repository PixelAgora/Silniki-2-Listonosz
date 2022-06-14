using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static Dieplease.DeathScreen;

namespace Enemy{

public class EnemyAI : MonoBehaviour{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;

    //Patrolling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Kill
    //States
    public float sightRange, KillRange;
    public bool playerInSightRange, playerInKillRange;

    private void Awake(){
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update(){
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInKillRange = Physics.CheckSphere(transform.position, KillRange, whatIsPlayer);

        if (!playerInSightRange && !playerInKillRange) Patrolling();
        if (playerInSightRange && !playerInKillRange) ChasePlayer();
        if (playerInKillRange && playerInSightRange) KillPlayer();
    }

    private void Patrolling(){
        if (!walkPointSet) SearchWalkPoint();
        if (walkPointSet)
            agent.SetDestination(walkPoint);
        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //when reaches walkpoint
        if (distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;
    }
    private void SearchWalkPoint(){
        //piotrek wyjasnij pls
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkPointSet = true;
    }
    private void ChasePlayer(){
        agent.SetDestination(player.position);
    }
    private void KillPlayer(){
        //Setup();
        //Destroy(gameObject);
        Debug.Log(" no i jest ");
    }

}
}
