using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    // Start is called before the first frame update
    public int coinCount = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Plus")
        {
            coinCount++;
            Destroy(collision.gameObject);
        }
    }
}
