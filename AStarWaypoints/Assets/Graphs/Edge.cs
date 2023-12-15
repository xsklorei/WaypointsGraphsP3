using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge
{
    // Start is called before the first frame update

    public Node startNode;
    public Node endNode;

    public Edge(Node from, Node to)
    {
        startNode = from;
        endNode = to;

    }
}
