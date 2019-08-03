using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCollisionCheck : MonoBehaviour
{
    [SerializeField] private ArrowManager arrowManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        arrowManager.CollisionCount++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        arrowManager.CollisionCount--;
    }
}
