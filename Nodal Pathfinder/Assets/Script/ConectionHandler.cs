using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConectionHandler : MonoBehaviour
{
    public Material conectedMaterial;
    private Node node;

    private void OnEnable()
    {
        node = this.GetComponentInParent<Node>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Conection")){
            this.GetComponent<Renderer>().material = conectedMaterial;
            SetNodeConection(other.transform.GetComponentInParent<Node>());
        }
    }

    private void SetNodeConection(Node neighbourNode)
    {
        node.Neighbour.Add(neighbourNode);
    }
}
