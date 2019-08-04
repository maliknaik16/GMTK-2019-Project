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
                GameManager.instance.endText.SetActive(true);
            }

            if (!audioSource.isPlaying && Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
