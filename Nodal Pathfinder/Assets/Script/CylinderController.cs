using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
    private Node nodeCollided;

    [SerializeField]
    private Pathfinder pathfinder; 

    private float speed = 2;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Node"))
        {
            nodeCollided = other.GetComponent<Node>();
        }
    }

    public void Move()
    {
        for(int c = 0; c < pathfinder.Path.Count; c++)
        {
            print("Debug " + c++);
            this.transform.position = Vector3.Lerp(this.transform.position, pathfinder.Path[c].transform.position, speed * Time.deltaTime);
        }
    }

    public Node NodeCollided { get => nodeCollided; }
}
