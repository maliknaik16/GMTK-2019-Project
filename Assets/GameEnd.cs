using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public AudioSource audioSource;

    private void Update()
    {
        if (GameManager.instance.startPlaying)
        {
            if (!audioSource.isPlaying)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
