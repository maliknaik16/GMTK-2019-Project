using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    private bool mayStart;
    private float speed;

    private void Start()
    {
        Invoke("RandomStartTime", Random.Range(0.3f, 3.5f));
        speed = GameManager.Instance.GlobalSpeed;
    }

    private void Update()
    {
        if (mayStart)
        {
            transform.position += -transform.up * speed * Time.deltaTime;
        }
    }

    private void RandomStartTime()
    {
        mayStart = true;
    }
}
