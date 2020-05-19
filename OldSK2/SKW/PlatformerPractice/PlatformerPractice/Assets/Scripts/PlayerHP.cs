using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int Level = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Void" || collision.gameObject.tag == "Spike")// || collision.gameObject.tag == "Exit")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(collision.gameObject.tag == "Exit" && Level == 1)
        {
            SceneManager.LoadScene("Practice");
        }
        if (collision.gameObject.tag == "Exit" && Level == 2)
        {
            SceneManager.LoadScene("Lvl1");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
