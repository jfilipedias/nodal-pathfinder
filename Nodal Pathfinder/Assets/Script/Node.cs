using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    //Attributes
    [SerializeField]
    private bool isWalkable = true;

    private List<Node> neighbour = new List<Node>();

    private Node parent;

    private float gCost, hCost, fCost;

    //Propeties
    public bool IsWalkable { get => isWalkable; set => isWalkable = value; }

    public List<Node> Neighbour { get => neighbour; set => neighbour = value; }

    public Node Parent { get => parent; set => parent = value; }

    public float GCost { get => gCost; set => gCost = value; }
    public float HCost { get => hCost; set => hCost = value; }
    public float FCost { get => gCost + hCost; }
}
