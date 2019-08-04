using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        RandomColor();
    }

    private void RandomColor()
    {
        int randomColor = Random.Range(0, 5);

        switch (randomColor)
        {
            case 0:
                spriteRenderer.color = new Color(0, 255, 224, 0.15f);
                break;
            case 1:
                spriteRenderer.color = new Color(255, 29, 0, 0.15f);
                break;
            case 2:
                spriteRenderer.color = new Color(255, 238, 0, 0.15f);
                break;
            case 3:
                spriteRenderer.color = new Color(28, 255, 0, 0.15f);
                break;
            case 4:
                spriteRenderer.color = new Color(231, 0, 255, 0.15f);
                break;
        }

        Invoke("RandomColor", 3f);
    }
}
