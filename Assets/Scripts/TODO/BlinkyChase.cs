using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkyChase : GhostChase
{
    private Vector2 getNextDirection(Node node)
    {
        List<Vector2> availableDirections = getAvailableDirections(node);
        Vector3 pacmanPosition = getPacmanPosition();
        Vector2 pacmanDirection = getPacmanDirection();

        float minDistance = float.MaxValue;
        Vector2 nextDirection = Vector2.zero;

        foreach (Vector2 availableDirection in getAvailableDirections(node))
        {
            if (availableDirection == -currentDirection())
            {
                continue;
            }

            Vector3 nextPosition = currentPosition() + new Vector3(pacmanDirection.x, pacmanDirection.y, 0);
            float nextDistance = Math.Abs(pacmanPosition.x - nextPosition.x) + Math.Abs(pacmanPosition.y - nextPosition.y);

            if (nextDistance < minDistance)
            {
                minDistance = nextDistance;
                nextDirection = availableDirection;
            }
        }

        return nextDirection;
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        Node node = other.GetComponent<Node>();

        if (node != null && isChasing() && !isFrightened())
        {

            setDirection(getNextDirection(node));
            //Go through the available directions and choose the first that
            //is not opposite to the current direction
            // foreach (Vector2 availableDirection in getAvailableDirections(node))
            // {
            //     if (availableDirection != -currentDirection())
            //     {
            //         setDirection(availableDirection);
            //         break;
            //     }
            // }
        }

    }
}
