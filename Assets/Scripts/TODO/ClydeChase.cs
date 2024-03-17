using System;
using System.Collections.Generic;
using UnityEngine;

public class ClydeChase : GhostChase
{
    /**
     * Clyde choses the direction that is farthest from the closest ghost
     *
     * @param node The current node that Clyde is on
     *
     * @return The direction that Clyde should move to
     */
    private Vector2 getNextDirection(Node node)
    {
        List<Vector2> availableDirections = getAvailableDirections(node);
        Vector2 closestGhostDirection = getClosestGhostDirection();
        Vector2 closestGhostPosition = getClosestGhostPosition();

        double maxDistance = float.MinValue;
        Vector2 nextDirection = Vector2.zero;

        foreach (Vector2 direction in getAvailableDirections(node))
        {
            if (direction == -currentDirection())
            {
                continue;
            }

            Vector2 nextPosition = new Vector2(node.transform.position.x, node.transform.position.y) + direction;
            float manhattanDistance = Math.Abs(nextPosition.x - closestGhostPosition.x) + Math.Abs(nextPosition.y - closestGhostDirection.y);

            if (manhattanDistance > maxDistance)
            {
                maxDistance = manhattanDistance;
                nextDirection = direction;
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
        }
    }
}
