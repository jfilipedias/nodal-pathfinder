using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
    private Node nodeCollided;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Node"))
        {
            nodeCollided = other.GetComponent<Node>();
        }
    }

    public Node NodeCollided { get => nodeCollided; }
}
