using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkyChase : GhostChase
{
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        ;
        private Vector2 getNextDirection(Node node)
        {
            List<Vector2> availableDirections = getAvailableDirections(node);
            Vector3 pacmanPosition = getPacmanPosition();

            float minDistance = float.MaxValue;
            Vector2 nextDirection = Vector2.zero;

            foreach (Vector2 availableDirection in getAvailableDirections(node))
            {
                Vector2 nextPosition = new Vector2(node.transform.position.x, node.transform.position.y) + availableDirection;
                float distance = Vector2.Distance(nextPosition, pacmanPosition);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    nextDirection = availableDirection;
                }
            }

            return nextDirection;
        }
        //calls parent method. Replace this line with your code.
        base.OnTriggerEnter2D(other);
    }
}
