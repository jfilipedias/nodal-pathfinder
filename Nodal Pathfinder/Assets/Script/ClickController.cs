using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickableLayer;

    [SerializeField]
    private Material pathMaterial;

    private Node startNode, targetNode;
    private bool isFirstClick = true;
    private Pathfinder pathfinder;

    private void Awake()
    {
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

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, clickableLayer))
        {
            if (isFirstClick)
            {
                isFirstClick = false;
                startNode = hit.collider.GetComponent<Node>();
            }
            else
            {
                isFirstClick = true;
                targetNode = hit.collider.GetComponent<Node>();

                pathfinder.FindPath(startNode, targetNode);
                DrawPath();
            }
        }
    }

    private void DrawPath()
    {
        startNode.gameObject.transform.GetChild(0).GetComponent<Renderer>().material = pathMaterial;
        foreach(Node node in pathfinder.Path)
        {
            GameObject nodeCore = node.gameObject.transform.GetChild(0).gameObject;
            nodeCore.GetComponent<Renderer>().material = pathMaterial;
        }
    }
}
