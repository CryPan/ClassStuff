using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class DOAI : MonoBehaviour
{
    //AI

    NavMeshAgent agent = null;
    GameObject TargetPoint = null;

    //RayCast

    public float dist = 10;
    public LayerMask mask = 0;
    private GameObject hitTarget = null;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        TargetPoint = new GameObject("TargetPoint");
        hitTarget = TargetPoint;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = new Vector3(Mathf.Sin(Time.time), 0, 1);
        //agent.Move(transform.forward * Time.deltaTime);

        //agent.SetDestination(TargetPoint.transform.position);

        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * dist, Color.blue);

        if (Physics.Raycast(transform.position, transform.forward, out hit, dist, mask))
        {
            hitTarget = hit.transform.gameObject;
            
        }
        agent.SetDestination(hitTarget.transform.position);
    }
}
