using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource music;

    public bool startPlaying;

    public BeatScroller beatScroller;

    public static GameManager instance;

    public Animator tapAnimator;

    public GameObject hitText;

    public GameObject missText;

    public Transform textSpawnPos;

    float cash = 0f;

    public Text cashText;

    public GameObject startText;
    public GameObject endText;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        if (!startPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                startText.SetActive(false);
                startPlaying = true;
                beatScroller.hasStarted = true;

                music.Play();
            }
        }
        ShowCash();
    }

    void ShowCash() {
        if(cash < 0) {
            cashText.text = "CASH: - €" + (-1f * cash);
        }else{
            cashText.text = "CASH: €" + cash;
        }
    }

    public void NoteHit()
    {
        ShowHitText();
        Debug.Log("Hit On Time");

        tapAnimator.SetTrigger("OpenTap");
    }

    public void NoteMissed()
    {
        ShowMissText();
        Debug.Log("Missed Note");
    }

    public void ShowHitText() {
        cash += 1f;
        Instantiate(hitText, Vector3.zero, Quaternion.identity);
    }

    public void ShowMissText() {
        cash -= 2f;
        Instantiate(missText, Vector3.zero, Quaternion.identity);
    }
}
