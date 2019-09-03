using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConectionHandler : MonoBehaviour
{
    public Material materialEnabled, materialConected;
    private Node nodeParent;

    private void OnEnable()
    {
        nodeParent = this.GetComponentInParent<Node>();
    }

    /*private void Start()
    {
        Debug.Log(node.name + ", " + this.name);
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Conection")){
            this.GetComponent<Renderer>().material = materialConected;
            SetNodeConection(other.transform.GetComponentInParent<Node>());
        }
    }

    private void SetNodeConection(Node nodeConected)
    {
        /*if (nodeConected == null)
            Debug.Log("Invalid conection");
        else
            Debug.Log("Valid conection with " + nodeConected);
        */

        switch (this.name)
        {
            case "PF_conection_0":
                nodeParent.Neighbour[0] = nodeConected;
                break;
            case "PF_conection_1":
                nodeParent.Neighbour[1] = nodeConected;
                break;
            case "PF_conection_2":
                nodeParent.Neighbour[2] = nodeConected;
                break;
            case "PF_conection_3":
                nodeParent.Neighbour[3] = nodeConected;
                break;
        }
    }
}
