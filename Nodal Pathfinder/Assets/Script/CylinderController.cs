using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CylinderController : MonoBehaviour
{
    private Node nodeCollided;

    public Pathfinder pathfinder;

    private bool isSelected = false;

    private Image selectionCircle;

    private void Awake()
    {
        selectionCircle = transform.GetComponentInChildren<Image>();
    }

    private void Update()
    {
        if (isSelected)
        {
            selectionCircle.enabled = true;
        }
        else
        {
            selectionCircle.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Node"))
        {
            nodeCollided = other.GetComponent<Node>();
        }
    }

    public void Move()
    {
        StartCoroutine(MoveBetweenNodes());
    }

    private IEnumerator MoveBetweenNodes()
    {
        foreach (Node node in pathfinder.Path)
        {
            Vector3 startPosition = this.transform.position;
            float elapsedTime = 0;
            float time = 0.3f;

            while (elapsedTime < time)
            {
                this.transform.position = Vector3.Lerp(startPosition, node.transform.position, elapsedTime / time);
                elapsedTime += Time.deltaTime;

                yield return null;
            }
        }
    }

    //Property
    public Node NodeCollided { get => nodeCollided; }
    
    public bool IsSelected { get => isSelected; set => isSelected = value; }
}
