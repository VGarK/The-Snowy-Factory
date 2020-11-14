using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : MonoBehaviour {

    NavMeshAgent nav;

    public GameObject target;
    public float patrolspeed = 2f;
    public float attackRange = 5f;
    public Transform[] wayPoints;
    public int curWaypoint;
    public int maxWaypoint;
    public float minWaypointDistance = 0.5f;



	// Use this for initialization
	void Start () 
    {
        
        nav = GetComponent<NavMeshAgent>();
        maxWaypoint = wayPoints.Length;

	}
	
	// Update is called once per frame
	void Update () 
    {

        Patrulla();

    }

    void Patrulla() 
    {
        patrolspeed = nav.speed =5f;

        Vector3 tempLocalPosition;
        Vector3 waypointPosition;


        tempLocalPosition = this.transform.position;
        waypointPosition = wayPoints[curWaypoint].position;

        if (Vector3.Distance(tempLocalPosition, waypointPosition) 
            <= minWaypointDistance) 
        {

            curWaypoint++;

            if (curWaypoint >= maxWaypoint) 
            {
                curWaypoint = 0;
            }

        }

        if (Vector3.Distance(tempLocalPosition, target.transform.position)
           < attackRange) {
            nav.SetDestination(target.transform.position);
        } else 
        {
            nav.SetDestination(wayPoints[curWaypoint].position);
        }

    }



}
