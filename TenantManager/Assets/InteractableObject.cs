using CharacterSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] Camera mainCamera;
    [SerializeField] GameObject button;
    [SerializeField] NavMeshAgent agent;
    //[SerializeField] TextMeshProUGUI characterName;

    Ray ray => Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void InteractionClick()
    {
        if(Physics.Raycast(ray, out hit))
        {
            Transform selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                agent.destination = hit.point;
            }
            //if(hit.transform.gameObject.tag == "Arcade")
            //{
            //    button.SetActive(true);
            //}
        }
        
    }
}
