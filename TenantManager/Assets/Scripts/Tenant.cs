using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tenant : MonoBehaviour
{
//    private NavMeshAgent navMeshAgent;
//    private Needs needs;
//    private SmartObject currentObject;
//    private float interactionStartTime;

//    private Node rootNode;

//    private void Start()
//    {
//        navMeshAgent = GetComponent<NavMeshAgent>();
//        needs = new Needs();

//        // Create the behavior tree nodes
//        Node isAtLocationNode = new IsAtLocationNode(navMeshAgent);
//        Node moveToLocationNode = new MoveToLocationNode(navMeshAgent, new Vector3(1, 0, 1));
//        Node isObjectInRangeNode = new IsObjectInRangeNode(transform, currentObject.gameObject, 1f);
//        Node timeLimitNode = new TimeLimitNode(5f);
//        Node interactWithObjectNode = new InteractWithObjectWithNeedsNode(currentObject, needs);

//        // Create the behavior tree
//        rootNode = new SelectorNode(new Node[]
//        {
//            new SequenceNode(new Node[] { isAtLocationNode, moveToLocationNode }),
//            new SequenceNode(new Node[] { isObjectInRangeNode, timeLimitNode, interactWithObjectNode })
//        });
//    }

//    private void Update()
//    {
//        rootNode.Execute();

//        // Update needs over time
//        needs.Update(Time.deltaTime);
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        // Check if the sim character has collided with an interactable object
//        InteractableObject interactableObject = other.gameObject.GetComponent<InteractableObject>();
//        if (interactableObject != null)
//        {
//            currentObject = interactableObject;
//        }
//    }

//    private void OnTriggerExit(Collider other)
//    {
//        // Reset the current object when the sim character leaves the trigger area
//        InteractableObject interactableObject = other.gameObject.GetComponent<InteractableObject>();
//        if (interactableObject != null && currentObject == interactableObject)
//        {
//            currentObject = null;
//        }
//    }
//}

//// Behavior tree nodes

//public abstract class Node
//{
//    public abstract bool Execute();
//}

//public class SelectorNode : Node
//{
//    private Node[] childNodes;

//    public SelectorNode(Node[] nodes)
//    {
//        childNodes = nodes;
//    }

//    public override bool Execute()
//    {
//        foreach (Node childNode in childNodes)
//        {
//            if (childNode.Execute())
//            {
//                return true;
//            }
//        }

//        return false;
//    }
//}

//public class SequenceNode : Node
//{
//    private Node[] childNodes;

//    public SequenceNode(Node[] nodes)
//    {
//        childNodes = nodes;
//    }

//    public override bool Execute()
//    {
//        foreach (Node childNode in childNodes)
//        {
//            if (!childNode.Execute())
//            {
//                return false;
//            }
//        }

//        return true;
//    }
//}

//public class IsAtLocationNode : Node
//{
//    private NavMeshAgent navMeshAgent;

//    public IsAtLocationNode(NavMeshAgent agent)
//    {
//        navMeshAgent = agent;
//    }

//    public override bool Execute()
//    {
//        return !navMeshAgent.pathPending && navMesh
//            }
}

