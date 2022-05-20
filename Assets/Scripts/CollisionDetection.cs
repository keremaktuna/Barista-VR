using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    CoffeMachine Machine;

    void Start()
    {
        Machine = GameObject.Find("Coffee_Machine").GetComponent<CoffeMachine>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mug")
        {
            if(gameObject.name == "Left Coffe Spot")
            {
                Machine.leftSpot = true;
                Machine.leftCoffeeMug = other.gameObject;
            }
            if(gameObject.name == "Right Coffe Spot")
            {
                Machine.rightSpot = true;
                Machine.rightCoffeeMug = other.gameObject;
            }
        }
        if(other.gameObject.tag == "Spoon")
        {
            if(gameObject.name == "Left Spoon Spot")
            {
                Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
                rb.constraints = RigidbodyConstraints.FreezeAll;
                Machine.leftSpoon = true; 
            }
            if (gameObject.name == "Right Spoon Spot")
            {
                Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
                rb.constraints = RigidbodyConstraints.FreezeAll;
                Machine.rightSpoon = true;
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mug")
        {
            if (gameObject.name == "Left Coffe Spot")
            {
                Machine.leftSpot = true;
                Machine.leftCoffeeMug = other.gameObject;
                Machine.coffeeMug = other.gameObject;
            }
            if (gameObject.name == "Right Coffe Spot")
            {
                Machine.rightSpot = true;
                Machine.rightCoffeeMug = other.gameObject;
                Machine.coffeeMug = other.gameObject;
            }
        }
    
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Mug")
        {
            if (gameObject.name == "Left Coffe Spot")
                Machine.leftSpot = false;
            if (gameObject.name == "Right Coffe Spot")
                Machine.rightSpot = false;
        }
        if (other.gameObject.tag == "FullMug")
        {
            if (gameObject.name == "Left Coffe Spot")
                Machine.leftSpot = false;
            if (gameObject.name == "Right Coffe Spot")
                Machine.rightSpot = false;
        }
        if (other.gameObject.tag == "Spoon")
        {
            if (gameObject.name == "Left Spoon Spot")
            {
                Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
                rb.constraints = RigidbodyConstraints.None;
            }
            if (gameObject.name == "Right Spoon Spot")
            {
                Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
                rb.constraints = RigidbodyConstraints.None;
            }
        }
    }
}
