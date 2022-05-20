using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coffee : MonoBehaviour
{
    float coffeeHeight = 0;

    public GameObject coffeObject;
    public PourDetector pourDetector, pourDetector2;

    bool isPour = false;
    bool haveCoffe = false;
  
    void Start()
    {
        coffeObject.SetActive(false);
    }

    void Update()
    {
       CheckLevel();
    }

    public void StartPour()
    {
        if(haveCoffe)
        {
            if (coffeeHeight == 0)
            {
                coffeeHeight = coffeeHeight + 1;
                StartCoroutine(IncreaseLevel());
                pourDetector.StartPour();
                pourDetector2.StartPour();
            }
        }
    }

    void CheckLevel()
    {
        if (coffeeHeight == 20)
        {
            coffeObject.SetActive(true);
            coffeObject.transform.localScale = new Vector3(0.0255751f, 0.0005655931f, 0.02333038f);
            coffeObject.transform.localPosition = new Vector3(0, -0.00606f, 0.0036f);
            coffeeHeight = coffeeHeight + 1;
            isPour = false;
            StartCoroutine(IncreaseLevel());

        }
        else if (coffeeHeight == 40)
        {
            coffeObject.transform.localScale = new Vector3(0.0255751f, 0.0005655931f, 0.02333038f);
            coffeObject.transform.localPosition = new Vector3(0, -0.00235f, 0.0036f);
            coffeeHeight = coffeeHeight + 1;
            isPour = false;
            StartCoroutine(IncreaseLevel());

        }
        else if (coffeeHeight == 60)
        {
            coffeObject.transform.localScale = new Vector3(0.02864156f, 0.0005655931f, 0.02627701f);
            coffeObject.transform.localPosition = new Vector3(0, 0.00137f, 0.0036f);
            coffeeHeight = coffeeHeight + 1;
            isPour = false;
            StartCoroutine(IncreaseLevel());

        }
        else if (coffeeHeight == 80)
        {
            coffeObject.transform.localScale = new Vector3(0.02864156f, 0.0005655931f, 0.02627701f);
            coffeObject.transform.localPosition = new Vector3(0, 0.00509f, 0.0036f);
            coffeeHeight = coffeeHeight + 1;
            isPour = false;
            StartCoroutine(IncreaseLevel());

        }
        else if (coffeeHeight == 100)
        {
            coffeObject.transform.localScale = new Vector3(0.03488828f, 0.0005655931f, 0.03214992f);
            coffeObject.transform.localPosition = new Vector3(0, 0.00881f, 0.0036f);
            coffeeHeight = coffeeHeight + 1;
            isPour = false;
            StartCoroutine(IncreaseLevel());
            pourDetector.EndPour();
            pourDetector2.EndPour();
        }
    }

    IEnumerator IncreaseLevel()
    {
        yield return new WaitForSeconds(2f);
        while (isPour == false)
        {
            isPour = true;
            coffeeHeight = coffeeHeight + 19;
        }
    }

    public void TakeCofffe()
    {
        haveCoffe = true;
    }
}
