using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConectionHandler : MonoBehaviour
{
    public Material conectedMaterial;
    private Node nodeParent;

    private void OnEnable()
    {
        nodeParent = this.GetComponentInParent<Node>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Conection")){
            this.GetComponent<Renderer>().material = conectedMaterial;
            SetNodeConection(other.transform.GetComponentInParent<Node>());
        }
    }

    private void SetNodeConection(Node conectedNode)
    {
        switch (this.name)
        {
            case "PF_conection_0":
                nodeParent.Neighbour[0] = conectedNode;
                break;
            case "PF_conection_1":
                nodeParent.Neighbour[1] = conectedNode;
                break;
            case "PF_conection_2":
                nodeParent.Neighbour[2] = conectedNode;
                break;
            case "PF_conection_3":
                nodeParent.Neighbour[3] = conectedNode;
                break;
        }
    }
}
