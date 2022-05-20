using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDetection : MonoBehaviour
{
    Customer customer;

    bool firstHalf, secondHalf;

    GameObject coffee, food;

    void Start()
    {
        customer = GameObject.Find("CustomerManager").GetComponent<Customer>();
    }

    void Update()
    {
        if (firstHalf && secondHalf)
        {
            customer.completeOrder = true;
            Destroy(coffee, 1f);
            Destroy(food, 1f);
            firstHalf = false;
            secondHalf = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(customer.food == Customer.Food.Cupcake1)
        {
            if(other.gameObject.tag == "Cupcake1")
            {
                firstHalf = true;
                food = other.gameObject;
            }
        }
        else if (customer.food == Customer.Food.Cupcake2)
        {
            if(other.gameObject.tag == "Cupcake2")
            {
                firstHalf = true;
                food = other.gameObject;
            }
        }
        else if(customer.food == Customer.Food.Cake)
        {
            if(other.gameObject.tag == "Cake")
            {
                firstHalf = true;
                food = other.gameObject;
            }
        }
        else if(customer.food == Customer.Food.Muffin)
        {
            if(other.gameObject.tag == "Muffin")
            {
                firstHalf = true;
                food = other.gameObject;
            }
        }
        else if(customer.food == Customer.Food.Croissant)
        {
            if(other.gameObject.tag == "Croissant")
            {
                firstHalf = true;
                food = other.gameObject;
            }
        }
        if(other.gameObject.tag == "FullMug")
        {
            secondHalf = true;
            coffee = other.gameObject;
        }
    }
}
