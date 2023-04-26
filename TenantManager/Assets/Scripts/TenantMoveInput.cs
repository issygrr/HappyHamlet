using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class TenantMoveInput : MonoBehaviour
{
    [SerializeField] NavMeshAgent navAgent;
    [SerializeField] Camera mainCamera;
    //[SerializeField] TextMeshProUGUI characterName;

    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    // Update is called once per frame
    private void Update()
    {

    }

    public void CharacterControl()
    {
        if (Input.GetMouseButton(1))
        {
            Physics.Raycast(ray, out hit);

        }
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                NavMeshAgent newAgent = hit.transform.GetComponent<NavMeshAgent>();
                if (newAgent != null)
                {
                    navAgent = newAgent;
                }
            }
        }
    }
}
