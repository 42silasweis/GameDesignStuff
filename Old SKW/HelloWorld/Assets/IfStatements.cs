using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public float coffeeTemp = 170.0f;
    float hotTemp = 180.0f;
    float coldTemp = 110.0f;

    // Update is called once per frame
    void Update()
    {
        coffeeTemp -= Time.deltaTime * 5;
        //coffeeTemp = coffeTemp - Time.deltaTime * 5;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
    }
    void TemperatureTest()
    {
        //too hot
        if(coffeeTemp > hotTemp)
        {
            Debug.Log("Ouch! I burned my tongue!");
        }
        //too cold
        else if(coffeeTemp < coldTemp)
        {
            Debug.Log("Ugh. I hate cold coffee!");
        }
        //just right
        else
        {
            Debug.Log("MMmmm I like me some coffee");
        }
    }
}
