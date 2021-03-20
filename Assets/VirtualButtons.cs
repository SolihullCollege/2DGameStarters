using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualButtons : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool isRightButton;
    bool isMoving;
    int direction=1;
    public Transform thingToMove;

    public float leftBound;
    public float righBound;

    // Start is called before the first frame update
    void Start()
    {
        if(!isRightButton)
        {
            direction = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            //move in direction of travel
            thingToMove.Translate(Vector2.right*2*direction*Time.deltaTime);
            thingToMove.localPosition = new Vector2(Mathf.Clamp(thingToMove.localPosition.x,-1.5f,1.5f), thingToMove.localPosition.y);
        }
    }


    //when thing is pressed down
    public void OnPointerDown(PointerEventData eventData)
    {
        isMoving = true;
    }

    //when thing is released
    public void OnPointerUp(PointerEventData eventData)
    {
        isMoving = false;
    }
}
