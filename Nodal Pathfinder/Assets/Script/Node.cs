using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private int id;
    private Node boundaryA, boundaryB, boundaryC, bounderyD;
    public Node BoundaryA { get; set; }
    public Node BoundaryB { get; set; }
    public Node BoundaryC { get; set; }
    public Node BoundaryD { get; set; }
}
