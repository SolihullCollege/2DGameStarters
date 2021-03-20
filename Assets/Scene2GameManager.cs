using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2GameManager : MonoBehaviour
{
    public GameObject thingThatMoves;
    public Transform[] placesItMovesTo;
    public float timeBetweenMoves;


    void Start()
    {
        StartCoroutine("moveThing");
    }
    void Update()
    {
        
    }
    IEnumerator moveThing()
    {
        //hide the thing
        thingThatMoves.SetActive(false);
        //wait a set time
        yield return new WaitForSeconds(timeBetweenMoves);
        //set a local variable to be a random number between 0 and the number of places
        int randomNum = Random.Range(0, placesItMovesTo.Length);
        //move the thing to it's position
        thingThatMoves.transform.position = placesItMovesTo[randomNum].position;
        //make it visible again
        thingThatMoves.SetActive(true);
        yield return new WaitForSeconds(1); //wait again
        StartCoroutine("moveThing"); // restart the process
    }


}
