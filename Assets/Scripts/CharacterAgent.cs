using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAgent : MonoBehaviour
{
    public GameObject Mugs, InteractableFoods;

    GameObject characterDestination;
    NavMeshAgent theAgent;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        theAgent = GetComponent<NavMeshAgent>();
        characterDestination = GameObject.Find("Destination");
        theAgent.SetDestination(characterDestination.transform.position);
    }
    void Update()
    {
        if (!theAgent.pathPending)
        {
            if (theAgent.remainingDistance <= theAgent.stoppingDistance)
            {
                if (!theAgent.hasPath || theAgent.velocity.sqrMagnitude == 0f)
                {
                    anim.SetBool("reachDestination", true);
                }
            }
        }
    }

    public void GoBack()
    {
        anim.SetBool("reachDestination", false);
        characterDestination = GameObject.Find("ExitDestination");
        theAgent.SetDestination(characterDestination.transform.position);
        StartCoroutine(KillCustomer());
    }
    IEnumerator KillCustomer()
    {
        yield return new WaitForSeconds(5f);
        GameObject.Find("CustomerManager").GetComponent<Customer>().isCustomer = false;
        GameObject.Find("CustomerManager").GetComponent<Customer>().completeOrder = false;
        Destroy(GameObject.FindGameObjectWithTag("InteractableFoods"));
        DestroyFoods("Cupcake1");
        DestroyFoods("Cupcake2");
        DestroyFoods("Muffin");
        DestroyFoods("Cake");
        DestroyFoods("Croissant");
        Instantiate(InteractableFoods).transform.position = new Vector3(3.480251f, 0.7114521f, 0.906438f);
        Destroy(GameObject.FindGameObjectWithTag("Mugs"));
        GameObject[] mug = GameObject.FindGameObjectsWithTag("Mug");
        if(mug != null)
        {
            foreach (GameObject x in mug)
            {
                Destroy(x);
            }
        }
        Instantiate(Mugs).transform.position = new Vector3(3.3284f, 0.8639f, -0.2999f);
        Destroy(gameObject);
    }

    void DestroyFoods(string x)
    {
        GameObject a = GameObject.FindGameObjectWithTag(x);
        if(a != null)
        {
            Destroy(a);
        }
    }
}
