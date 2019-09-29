using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickController : MonoBehaviour
{   
    private LayerMask nodeLayer;
    private LayerMask cylinderLayer;

    public Material pathMaterial;
    
    public Image selectionCircle;

    public CylinderController cylinder;

    private Node startNode, targetNode;

    private Pathfinder pathfinder;

    private bool isCircleSeleted = false;

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
            isCircleSeleted = true;
            selectionCircle.enabled = true;
        }
        else if (Physics.Raycast(ray, out hit, Mathf.Infinity, nodeLayer))
        {
            if (isCircleSeleted)
            {
                startNode = cylinder.NodeCollided;
                targetNode = hit.collider.GetComponent<Node>();

                pathfinder.FindPath(startNode, targetNode);
                //DrawPath();
                cylinder.GetComponent<CylinderController>().Move();
            }
        }
    }
}
