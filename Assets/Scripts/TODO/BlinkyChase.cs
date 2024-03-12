using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkyChase : GhostChase
{
    /**
     * Blinky's chase mode is to target the position of Pacman
     *
     * @param node The current node that Blinky is on
     *
     * @return The direction that Blinky should move in
     */
    private Vector2 getNextDirection(Node node)
    {
        List<Vector2> availableDirections = getAvailableDirections(node);
        Vector3 pacmanPosition = getPacmanPosition();

        double minDistance = float.MaxValue;
        Vector2 nextDirection = Vector2.zero;

        foreach (Vector2 availableDirection in getAvailableDirections(node))
        {
            if (availableDirection == -currentDirection())
            {
                continue;
            }

            Vector2 nextPosition = new Vector2(node.transform.position.x, node.transform.position.y) + availableDirection;
            float distance = Vector2.Distance(nextPosition, pacmanPosition);
            float manhattanDistance = Math.Abs(nextPosition.x - pacmanPosition.x) + Math.Abs(nextPosition.y - pacmanPosition.y);

            if (manhattanDistance < minDistance)
            {
                minDistance = manhattanDistance;
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
        }

    }
}
