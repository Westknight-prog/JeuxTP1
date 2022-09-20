using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavComponent : MonoBehaviour
{
    private NavMeshAgent nav;
    [SerializeField] GameObject joueur;
    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        nav.destination = joueur.transform.position;
    }
}
