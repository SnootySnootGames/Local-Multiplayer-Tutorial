using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using .inputSystem namespace to be able to utilize all input system library
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //store our collected input value, used in movement logic
    private Vector2 moveInputValue;

    void Update()
    {
        MoveLogic(); 
    }

    //using the player input wrapper to send messages which OnMove is based off our action called Move
    private void OnMove(InputValue value)
    {
        //store the value from our input action. Since we set our action type to value and a vector 2,
        //we essentially created an x value and a y value
        moveInputValue = value.Get<Vector2>();
    }

    private void MoveLogic()
    {
        //Just using transform tranlsate for easy player movement for tutorial purposes.
        //we store our players input which is a vect 2, multiply by deltaTime and an arbitrary number to increase speed
        transform.Translate(moveInputValue * Time.deltaTime * 5);
    }


}
