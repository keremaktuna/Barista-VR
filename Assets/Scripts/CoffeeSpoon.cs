using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeSpoon : MonoBehaviour
{
    public Coffee coffe;
    public GameObject coffeObject;

    CoffeMachine coffeMachine;

    void Start()
    {
        coffeMachine = GameObject.Find("Coffee_Machine").GetComponent<CoffeMachine>();
        coffeObject.SetActive(false);
    }

    void Update()
    {
        if (gameObject.name == "Spoon1")
        {
            if (coffeMachine.leftSpoonFull == false)
            {
                coffeObject.SetActive(false);
            }
        }
        if (gameObject.name == "Spoon2")
        {
            if (coffeMachine.rightSpoonFull == false)
            {
                coffeObject.SetActive(false);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coffee")
        {
            if(gameObject.name == "Spoon1")
            {
                coffeMachine.leftSpoonFull = true;
                coffeObject.SetActive(true);
            }
            if (gameObject.name == "Spoon2")
            {
                coffeMachine.rightSpoonFull = true;
                coffeObject.SetActive(true);
            }
        }
    }
}
