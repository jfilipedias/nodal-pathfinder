using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ConectionHandler : MonoBehaviour
{
    public Material materialEnabled, materialConected;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Boundary")){
            this.GetComponent<Renderer>().material = materialConected;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Boundary"))
        {
                this.GetComponent<Renderer>().material = materialEnabled;
        }
    }
}
