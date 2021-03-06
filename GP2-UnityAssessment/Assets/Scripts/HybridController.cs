﻿using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class HybridController : MonoBehaviour
{
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;

    public bool isVisible;
    public bool isAudible;

    public float feildOfViewAngle = 110f;

    private SphereCollider col;
    private GameObject player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        GotoNextPoint();

        col = GetComponent<SphereCollider>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    //Pathing + Waypoints
    void GotoNextPoint()
    {
        if (points.Length == 0)
            return;

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }

    //Decision Tree 
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();

        if(isVisible && isAudible)
        {
            Debug.Log("Fucken found him");
        }
        else if(!isVisible && !isAudible)
        {
            Debug.Log("Fucken lost him");
        }
    }

    //Check enemy Line of Sight for Player tag
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject == player)
        {
            isVisible = false;

            Vector3 direction = other.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.forward);

            if(angle < feildOfViewAngle * 0.5f)
            {
                RaycastHit hit;

                if(Physics.Raycast(transform.position + transform.up, direction.normalized, out hit, col.radius))
                {
                    if(hit.collider.gameObject == player)
                    {
                        isVisible = true;
                    }
                }
            }
        }
    }

    //Check enemy Hearing Range for Player tag
    void Audible()
    {

    }
}