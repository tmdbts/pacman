using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkyChase : GhostChase
{
    private Vector2 getNextDirection(Node node)
    {
        List<Vector2> availableDirections = getAvailableDirections(node);
        Vector3 pacmanPosition = getPacmanPosition();
        Vector2 pacmanDirection = getPacmanDirection();
        Vector2 pacman4UnitsAhead = new Vector2(pacmanPosition.x, pacmanPosition.y) + 4 * pacmanDirection;

        double minDistance = float.MaxValue;
        Vector2 nextDirection = Vector2.zero;

        foreach (Vector2 availableDirection in getAvailableDirections(node))
        {
            if (availableDirection == -currentDirection())
            {
                continue;
            }

            Vector2 nextPosition = new Vector2(node.transform.position.x, node.transform.position.y) + availableDirection;
            float distance = Vector2.Distance(nextPosition, pacman4UnitsAhead);
            float manhattanDistance = Math.Abs(nextPosition.x - pacman4UnitsAhead.x) + Math.Abs(nextPosition.y - pacman4UnitsAhead.y);

            Debug.Log("Pinky manhattanDistance " + manhattanDistance + " for direcition " + availableDirection);

            if (manhattanDistance < minDistance)
            {
                minDistance = manhattanDistance;
                nextDirection = availableDirection;
            }
        }

        Debug.LogWarning("Pinky next direction: " + nextDirection);

        return nextDirection;
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        Node node = other.GetComponent<Node>();

        if (node != null && isChasing() && !isFrightened())
        {

            setDirection(getNextDirection(node));
        }
    }
}
