using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;

    public bool hasStarted;

    private void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    private void Update()
    {
        if (hasStarted)
        {
            transform.position += new Vector3(beatTempo * Time.deltaTime, 0f);
        }
    }
}
