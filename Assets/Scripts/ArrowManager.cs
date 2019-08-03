using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour
{
    public int CollisionCount = 0;

    public enum ArrowDirection
    {
        Left,
        Up,
        Down,
        Right
    }

    public ArrowDirection MyArrowDirection;

    private void Update()
    {
        ButtonDirection();
    }

    private void ButtonDirection()
    {
        switch (MyArrowDirection)
        {
            case ArrowDirection.Left:
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    HandlePoints();
                }
                break;
            case ArrowDirection.Up:
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    HandlePoints();
                }
                break;
            case ArrowDirection.Down:
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    HandlePoints();
                }
                break;
            case ArrowDirection.Right:
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    HandlePoints();
                }
                break;
        }
    }

    private void HandlePoints()
    {
        switch (CollisionCount)
        {
            case 0:
                Debug.Log("X");
                break;
            case 1:
                Debug.Log("Ok!");
                StartCoroutine(GameManager.Instance.AddToScore(25));
                break;
            case 2:
                Debug.Log("Wow!");
                StartCoroutine(GameManager.Instance.AddToScore(75));
                break;
            case 3:
                Debug.Log("AMAZING!");
                StartCoroutine(GameManager.Instance.AddToScore(150));
                break;
        }
    }
}
