using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField] private bool isWalkable;
    private Node[] neighbour = new Node[4];
    private int gCost;
    private int hCost;
    private Vector2 position;
    public bool IsWalkable { get => isWalkable; set => isWalkable = value; }
    public Node[] Neighbour { get => neighbour; set => neighbour = value; }
    public int GCost { get => gCost; }
    public int HCost { get => hCost; }
    public int FCost { get => gCost + hCost; }
    public Vector2 Position { get => position; set => position = value; }

    private void Awake()
    {
        position.x = this.transform.position.x;
        position.y = this.transform.position.y;
    }
}
