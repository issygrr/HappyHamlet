using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class TenentCharacter : MonoBehaviour
{
    [SerializeField] NavMeshAgent navAgent;
    [SerializeField] Camera mainCamera;
    //[SerializeField] TextMeshProUGUI characterName;

    Ray ray => Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    // Update is called once per frame
    private void Update()
    {
        CharacterControl();
    }

    public void CharacterControl()
    {
        if (Input.GetMouseButton(1))
        {
            print("clicking");
            Physics.Raycast(ray, out hit);
            navAgent.destination = hit.point;
        }
        
    }
    
}
