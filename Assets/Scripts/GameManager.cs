using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    [SerializeField] private Text text; 
    public float Score = 0;
    public float GlobalSpeed;

    private void Start()
    {
        
    }

    public IEnumerator AddToScore(int value)
    {
        for (int i = 0; i < value; i++)
        {
            yield return new WaitForSeconds(0.001f);
            Score++;
            text.text = "$ " + Score;
        }
    }
}
