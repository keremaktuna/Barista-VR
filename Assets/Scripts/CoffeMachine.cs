using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeMachine : MonoBehaviour
{
    public bool leftSpot, rightSpot, leftButton, rightButton, leftSpoon, rightSpoon, leftSpoonFull, rightSpoonFull;

    public GameObject coffeeMug, coffeeMug2, coffeeObject, leftCoffeeMug, rightCoffeeMug;

    public PourDetector[] leftStream, rightStream;

    bool isPourLeft, isPourRight;

    float leftCoffeeHeight = 0, rightCoffeeHeight = 0;

    GameObject leftCoffeeObject, rightCoffeeObject;

    AudioSource coffeeMachineSound;

    public AudioClip coffeeSound;

    void Start()
    {
        coffeeMachineSound = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        /*if (leftSpot)
            Debug.Log("Enter Left");
        if (!leftSpot)
            Debug.Log("Left Left");
        if (rightSpot)
            Debug.Log("Enter Right");
        if (!rightSpot)
            Debug.Log("Left Right");*/

        PourCoffee();
        //Debug.Log(leftCoffeeHeight);
    }

    void PourCoffee()
    {
        if (leftButton && leftSpoon && leftSpoonFull && leftSpot)
        {
            if(coffeeMachineSound.isPlaying == false)
            {
                coffeeMachineSound.PlayOneShot(coffeeSound);
            }
            StartPourLeft();
            CheckLevelLeft();
        }
        if (rightButton && rightSpoon && rightSpoonFull && rightSpot)
        {
            if (coffeeMachineSound.isPlaying == false)
            {
                coffeeMachineSound.PlayOneShot(coffeeSound);
            }
            StartPourRight();
            CheckLevelRight();
        }
    }

    void StartPourLeft()
    {
        if (leftCoffeeHeight == 0)
        {
            leftCoffeeObject = Instantiate(coffeeObject);
            leftCoffeeObject.transform.parent = leftCoffeeMug.transform;
            leftCoffeeObject.transform.localPosition = new Vector3(0, 0, 0);
            leftCoffeeHeight++;
            StartCoroutine(IncreaseLevelLeft());
            foreach(PourDetector left in leftStream)
            {
                left.StartPour();
            }
            //pourDetector.StartPour();
            //pourDetector2.StartPour();
        }
    }

    void StartPourRight()
    {
        if (rightCoffeeHeight == 0)
        {
            rightCoffeeObject = Instantiate(coffeeObject);
            rightCoffeeObject.transform.parent = rightCoffeeMug.transform;
            rightCoffeeObject.transform.localPosition = new Vector3(0, 0, 0);
            rightCoffeeHeight++;
            StartCoroutine(IncreaseLevelRight());
            foreach (PourDetector right in rightStream)
            {
                right.StartPour();
            }
            //pourDetector.StartPour();
            //pourDetector2.StartPour();
        }
    }

    IEnumerator IncreaseLevelLeft()
    {
        yield return new WaitForSeconds(1f);
        while (isPourLeft == false)
        {
            isPourLeft = true;
            leftCoffeeHeight = leftCoffeeHeight + 9;
        }
    }

    IEnumerator IncreaseLevelRight()
    {
        yield return new WaitForSeconds(1f);
        while (isPourRight == false)
        {
            isPourRight = true;
            rightCoffeeHeight = rightCoffeeHeight + 9;
        }
    }

    void CheckLevelLeft()
    {
        if (leftCoffeeHeight == 10)
        {
            leftCoffeeObject.transform.localScale = new Vector3(0.0255751f, 0.0005655931f, 0.02333038f);
            leftCoffeeObject.transform.localPosition = new Vector3(0, -0.00792f, 0.0036f);
            leftCoffeeHeight = leftCoffeeHeight + 1;
            isPourLeft = false;
            StartCoroutine(IncreaseLevelLeft());
        }
        else if (leftCoffeeHeight == 20)
        {
            leftCoffeeObject.transform.localScale = new Vector3(0.0255751f, 0.0005655931f, 0.02333038f);
            leftCoffeeObject.transform.localPosition = new Vector3(0, -0.00606f, 0.0036f);
            leftCoffeeHeight = leftCoffeeHeight + 1;
            isPourLeft = false;
            StartCoroutine(IncreaseLevelLeft());
        }
        else if (leftCoffeeHeight == 30)
        {
            leftCoffeeObject.transform.localScale = new Vector3(0.0255751f, 0.0005655931f, 0.02333038f);
            leftCoffeeObject.transform.localPosition = new Vector3(0, -0.00420f, 0.0036f);
            leftCoffeeHeight = leftCoffeeHeight + 1;
            isPourLeft = false;
            StartCoroutine(IncreaseLevelLeft());
        }
        else if (leftCoffeeHeight == 40)
        {
            leftCoffeeObject.transform.localScale = new Vector3(0.0255751f, 0.0005655931f, 0.02333038f);
            leftCoffeeObject.transform.localPosition = new Vector3(0, -0.00235f, 0.0036f);
            leftCoffeeHeight = leftCoffeeHeight + 1;
            isPourLeft = false;
            StartCoroutine(IncreaseLevelLeft());
        }
        else if (leftCoffeeHeight == 50)
        {
            leftCoffeeObject.transform.localScale = new Vector3(0.0265751f, 0.0005655931f, 0.02433038f);
            leftCoffeeObject.transform.localPosition = new Vector3(0, -0.00049f, 0.0036f);
            leftCoffeeHeight = leftCoffeeHeight + 1;
            isPourLeft = false;
            StartCoroutine(IncreaseLevelLeft());
        }
        else if (leftCoffeeHeight == 60)
        {
            leftCoffeeObject.transform.localScale = new Vector3(0.02864156f, 0.0005655931f, 0.02627701f);
            leftCoffeeObject.transform.localPosition = new Vector3(0, 0.00137f, 0.0036f);
            leftCoffeeHeight = leftCoffeeHeight + 1;
            isPourLeft = false;
            StartCoroutine(IncreaseLevelLeft());
        }
        else if (leftCoffeeHeight == 70)
        {
            leftCoffeeObject.transform.localScale = new Vector3(0.02864156f, 0.0005655931f, 0.02627701f);
            leftCoffeeObject.transform.localPosition = new Vector3(0, 0.00323f, 0.0036f);
            leftCoffeeHeight = leftCoffeeHeight + 1;
            isPourLeft = false;
            StartCoroutine(IncreaseLevelLeft());
        }
        else if (leftCoffeeHeight == 80)
        {
            leftCoffeeObject.transform.localScale = new Vector3(0.02864156f, 0.0005655931f, 0.02627701f);
            leftCoffeeObject.transform.localPosition = new Vector3(0, 0.00509f, 0.0036f);
            leftCoffeeHeight = leftCoffeeHeight + 1;
            isPourLeft = false;
            StartCoroutine(IncreaseLevelLeft());
        }
        else if (leftCoffeeHeight == 90)
        {
            leftCoffeeObject.transform.localScale = new Vector3(0.03064156f, 0.0005655931f, 0.02927701f);
            leftCoffeeObject.transform.localPosition = new Vector3(0, 0.00695f, 0.0036f);
            leftCoffeeHeight = leftCoffeeHeight + 1;
            isPourLeft = false;
            StartCoroutine(IncreaseLevelLeft());
        }
        else if (leftCoffeeHeight == 100)
        {
            leftCoffeeObject.transform.localScale = new Vector3(0.03488828f, 0.0005655931f, 0.03214992f);
            leftCoffeeObject.transform.localPosition = new Vector3(0, 0.00881f, 0.0036f);
            leftCoffeeHeight = leftCoffeeHeight + 1;
            isPourLeft = false;
            foreach (PourDetector left in leftStream)
            {
                left.EndPour();
            }
            leftButton = false;
            leftSpoonFull = false;
            leftCoffeeMug.tag = "FullMug";
            leftCoffeeHeight = 0;
            //pourDetector.EndPour();
            //pourDetector2.EndPour();
        }
    }

    void CheckLevelRight()
    {
        if (rightCoffeeHeight == 10)
        {
            rightCoffeeObject.transform.localScale = new Vector3(0.0255751f, 0.0005655931f, 0.02333038f);
            rightCoffeeObject.transform.localPosition = new Vector3(0, -0.00792f, 0.0036f);
            rightCoffeeHeight = rightCoffeeHeight + 1;
            isPourRight = false;
            StartCoroutine(IncreaseLevelRight());
        }
        else if (rightCoffeeHeight == 20)
        {
            rightCoffeeObject.transform.localScale = new Vector3(0.0255751f, 0.0005655931f, 0.02333038f);
            rightCoffeeObject.transform.localPosition = new Vector3(0, -0.00606f, 0.0036f);
            rightCoffeeHeight = rightCoffeeHeight + 1;
            isPourRight = false;
            StartCoroutine(IncreaseLevelRight());
        }
        else if(rightCoffeeHeight == 30)
        {
            rightCoffeeObject.transform.localScale = new Vector3(0.0255751f, 0.0005655931f, 0.02333038f);
            rightCoffeeObject.transform.localPosition = new Vector3(0, -0.00420f, 0.0036f);
            rightCoffeeHeight = rightCoffeeHeight + 1;
            isPourRight = false;
            StartCoroutine(IncreaseLevelRight());
        }
        else if (rightCoffeeHeight == 40)
        {
            rightCoffeeObject.transform.localScale = new Vector3(0.0255751f, 0.0005655931f, 0.02333038f);
            rightCoffeeObject.transform.localPosition = new Vector3(0, -0.00235f, 0.0036f);
            rightCoffeeHeight = rightCoffeeHeight + 1;
            isPourRight = false;
            StartCoroutine(IncreaseLevelRight());
        }
        else if (rightCoffeeHeight == 50)
        {
            rightCoffeeObject.transform.localScale = new Vector3(0.0265751f, 0.0005655931f, 0.02433038f);
            rightCoffeeObject.transform.localPosition = new Vector3(0, -0.00049f, 0.0036f);
            rightCoffeeHeight = rightCoffeeHeight + 1;
            isPourRight = false;
            StartCoroutine(IncreaseLevelRight());
        }
        else if (rightCoffeeHeight == 60)
        {
            rightCoffeeObject.transform.localScale = new Vector3(0.02864156f, 0.0005655931f, 0.02627701f);
            rightCoffeeObject.transform.localPosition = new Vector3(0, 0.00137f, 0.0036f);
            rightCoffeeHeight = rightCoffeeHeight + 1;
            isPourRight = false;
            StartCoroutine(IncreaseLevelRight());
        }
        else if (rightCoffeeHeight == 70)
        {
            rightCoffeeObject.transform.localScale = new Vector3(0.02864156f, 0.0005655931f, 0.02627701f);
            rightCoffeeObject.transform.localPosition = new Vector3(0, 0.00323f, 0.0036f);
            rightCoffeeHeight = rightCoffeeHeight + 1;
            isPourRight = false;
            StartCoroutine(IncreaseLevelRight());
        }
        else if (rightCoffeeHeight == 80)
        {
            rightCoffeeObject.transform.localScale = new Vector3(0.02864156f, 0.0005655931f, 0.02627701f);
            rightCoffeeObject.transform.localPosition = new Vector3(0, 0.00509f, 0.0036f);
            rightCoffeeHeight = rightCoffeeHeight + 1;
            isPourRight = false;
            StartCoroutine(IncreaseLevelRight());
        }
        else if (rightCoffeeHeight == 90)
        {
            rightCoffeeObject.transform.localScale = new Vector3(0.03064156f, 0.0005655931f, 0.02927701f);
            rightCoffeeObject.transform.localPosition = new Vector3(0, 0.00695f, 0.0036f);
            rightCoffeeHeight = rightCoffeeHeight + 1;
            isPourRight = false;
            StartCoroutine(IncreaseLevelRight());
        }
        else if (rightCoffeeHeight == 100)
        {
            rightCoffeeObject.transform.localScale = new Vector3(0.03488828f, 0.0005655931f, 0.03214992f);
            rightCoffeeObject.transform.localPosition = new Vector3(0, 0.00881f, 0.0036f);
            rightCoffeeHeight = rightCoffeeHeight + 1;
            isPourRight = false;
            foreach (PourDetector right in rightStream)
            {
                right.EndPour();
            }
            rightButton = false;
            rightSpoonFull = false;
            rightCoffeeMug.tag = "FullMug";
            rightCoffeeHeight = 0;
            //pourDetector.EndPour();
            //pourDetector2.EndPour();
        }
    }

    public void LeftButtonPress()
    {
        leftButton = true;
    }

    public void RightButtonPress()
    {
        rightButton = true;
    }

    public void LeftButtonRelease()
    {
        if(!leftSpoon || !leftSpoonFull || !leftSpot)
        {
            leftButton = false;
        }
    }

    public void RightButtonRelease()
    {
        if(!rightSpoon || !rightSpoonFull || !rightSpot)
        {
            rightButton = false;
        }
    }
}
