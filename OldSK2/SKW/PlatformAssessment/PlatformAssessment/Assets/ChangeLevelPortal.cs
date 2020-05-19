using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevelPortal : MonoBehaviour
{
    public int level = 1;
    public GameObject canvas;

    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(level == 1)
        {
            canvas.GetComponent<LevelChanger>().FadeToLevel(2);
        }
        if(level == 2)
        {
            canvas.GetComponent<LevelChanger>().FadeToLevel(0);
        }
        else
        {

        }
    }
}
