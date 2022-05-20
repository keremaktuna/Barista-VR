using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class Customer : MonoBehaviour
{
    public enum Food { Cupcake1, Cupcake2, Cake, Muffin, Croissant };

    public Sprite[] foods;

    public Sprite coffee;

    public Image image, image2;

    public Food food;

    public bool isCustomer = false;

    public GameObject customer;

    public Vector3 customerSpawnPosition;

    public bool completeOrder = false;

    public GameObject[] customerPrefabs;

    public GameObject canvas;

    void Update()
    {
        if (!isCustomer)
        {
            isCustomer = true;
            Instantiate(customerPrefabs[Random.Range(0, 8)]).transform.position = customerSpawnPosition;
            //Instantiate(customer).transform.position = customerSpawnPosition;
            StartCoroutine(StartToChoseFood());
        }
        if(completeOrder)
        {
            GameObject.FindGameObjectWithTag("Customer").GetComponent<CharacterAgent>().GoBack();
            image.sprite = null;
            image2.sprite = null;
        }

        if (SteamVR_Actions._default.OpenAndCloseUI.GetState(SteamVR_Input_Sources.Any))
        {
            canvas.SetActive(true);
        }
        else if (!SteamVR_Actions._default.OpenAndCloseUI.GetState(SteamVR_Input_Sources.Any))
        {
            canvas.SetActive(false);
        }
    }

    IEnumerator StartToChoseFood()
    {
        yield return new WaitForSeconds(5f);
        ChooseFood();
        UpdateUI();
    }

    void ChooseFood()
    {
        food = (Food)Random.Range(0, 4);
    }

    void UpdateUI()
    {
        if(food == Food.Cupcake1)
        {
            image.sprite = foods[0];
            image2.sprite = coffee;
        }
        else if(food == Food.Cupcake2)
        {
            image.sprite = foods[1];
            image2.sprite = coffee;
        }
        else if (food == Food.Cake)
        {
            image.sprite = foods[2];
            image2.sprite = coffee;
        }
        else if (food == Food.Muffin)
        {
            image.sprite = foods[3];
            image2.sprite = coffee;
        }
        else if (food == Food.Croissant)
        {
            image.sprite = foods[4];
            image2.sprite = coffee;
        }
    }
}
