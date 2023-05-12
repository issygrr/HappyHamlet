using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimate : MonoBehaviour
{
    [SerializeField] Animator animator;
    NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        animator.SetBool("Moving", agent.velocity.magnitude > 0.1f);
        if(agent.velocity.magnitude > 0.1f)
        {
            print("now moving");
       }
    }
}
