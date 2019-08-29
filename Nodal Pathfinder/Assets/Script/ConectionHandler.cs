using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConectionHandler : MonoBehaviour
{
    public Material materialEnabled, materialConected;
    private Node node;

    private void Awake()
    {
        node = this.GetComponentInParent<Node>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Boundary")){
            this.GetComponent<Renderer>().material = materialConected;
            SetNodeConection(other.transform.GetComponentInParent<Node>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Boundary"))
        {
            this.GetComponent<Renderer>().material = materialEnabled;
            ClearNodeConection(other.transform.GetComponentInParent<Node>());
        }
    }

    private void SetNodeConection(Node nodeConected)
    {
        switch (this.name){
            case "PF_boundary_a":
                this.node.BoundaryA = nodeConected;
                break;
            case "PF_boundary_b":
                this.node.BoundaryB = nodeConected;
                break;
            case "PF_boundary_c":
                this.node.BoundaryC = nodeConected;
                break;
            case "PF_boundary_d":
                this.node.BoundaryD = nodeConected;
                break;
        }
    }

    private void ClearNodeConection(Node nodeConected)
    {
        switch (this.name)
        {
            case "PF_boundary_a":
                this.node.BoundaryA = null;
                break;
            case "PF_boundary_b":
                this.node.BoundaryB = null;
                break;
            case "PF_boundary_c":
                this.node.BoundaryC = null;
                break;
            case "PF_boundary_d":
                this.node.BoundaryD = null;
                break;
        }
    }
}
