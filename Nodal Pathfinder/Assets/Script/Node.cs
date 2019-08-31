using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private int id;
    private Node[] nodeConection = new Node[4];
    public Node[] NodeConection { get => nodeConection; set => nodeConection = value; }
}
