using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    public Animator animator;

    bool missed = false;
    bool hit = false;
    bool hitIndicator = false;

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                //gameObject.SetActive(false);
                hit = true;
                hitIndicator = true;

                GameManager.instance.NoteHit();
                AudioManager.instance.PlaySound(AudioManager.instance.pourBeer);
                animator.SetTrigger("Fill");
                AudioManager.instance.PlaySound(AudioManager.instance.gainMoney);
            }
        }

        if(missed && hitIndicator == false) 
        {
            missed = false;
            GameManager.instance.ShowMissText();
        }

        if(hit) 
        {
            hit = false;
            GameManager.instance.ShowHitText();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Activator")
        {
            canBePressed = false;
            missed = true;
        }
    }
}
