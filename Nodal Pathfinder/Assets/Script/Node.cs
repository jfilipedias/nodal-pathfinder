using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField] private bool isWalkable;
    private Node[] neighbour = new Node[4];
    private int gCost;
    private int hCost;
    public bool IsWalkable { get => isWalkable; set => isWalkable = value; }
    public Node[] Neighbour { get => neighbour; set => neighbour = value; }
    public int Hcost { get => hCost;  }
    public int FCost { get => gCost + hCost; }
}
