using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{   
    private LayerMask nodeLayer;
    private LayerMask cylinderLayer;

    private CylinderController cylinder;

    private Node startNode, targetNode;

    private Pathfinder pathfinder;

    private void Awake()
    {
        nodeLayer = LayerMask.GetMask("Node");
        cylinderLayer = LayerMask.GetMask("Cylinder");
        pathfinder = this.GetComponent<Pathfinder>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckRayHit();
        }
    }

    private void CheckRayHit()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, cylinderLayer))
        {
            if(cylinder != null)
            {
                cylinder.IsSelected = false;
            }

            cylinder = hit.transform.GetComponent<CylinderController>();
            cylinder.IsSelected = true;
        }
        else if (Physics.Raycast(ray, out hit, Mathf.Infinity, nodeLayer))
        {
            if (cylinder.IsSelected)
            {
                startNode = cylinder.NodeCollided;
                targetNode = hit.collider.GetComponent<Node>();

                pathfinder.FindPath(startNode, targetNode);
                cylinder.Move();
            }
        }
    }
}
