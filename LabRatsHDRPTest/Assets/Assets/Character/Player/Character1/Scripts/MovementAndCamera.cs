using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

//This script enables walking and walking in the direction in which the camera faces.
public class MovementAndCamera : MonoBehaviour
{

    private CharacterController controller; //The character controller of the player character

    public float speed = 6f; //The speed at which the player character moves
    public float smoothTime = 0.1f; //The speed at which the character turns
    private float turnSmoothVelocity; //Holds the turn velocity
    private Transform cam; //The transform of the camera that follows the player character

    public float jumpHeight = 3;
    public float gravity = 9.87f;
    public float velocity = 7;

    public float runningSpeed = 12f;

    private Vector3 _directionY;

    public Animator anim;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>(); //Gets the Character controller component of the player character
        cam = GameObject.FindGameObjectWithTag("Camera").transform; //Gets the transform of the camera that follows the player
    }
    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal"); //Gets the horizontal input of the keyboard (AD) or of the controller
        float vertical = Input.GetAxisRaw("Vertical"); //Gets the vertical input of the keyboard (WS) or of the controller
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized; //Creates the direction in which the character moves by inputs. If two keys are pressed at the same time the charcter dosent move faster because of normalization

        //###############################################
        //replace 1.05 later depending on height / pivot point
        //###############################################
        //Debug.Log(checkDistanceToGround());
        if(checkDistanceToGround() <= 0.01)//returns distance to ground if working correctly
        {
            if (Input.GetButtonDown("Jump")) //checks if jump button is pressed
            {
                anim.SetTrigger("jump");
                _directionY.y = jumpHeight; //sets y value to jumpheight
            }
        }

        if(_directionY.y >= 0)
        {
            _directionY.y -= gravity * Time.deltaTime; //subtracts the gravity from the jumpheight every update to get a falling gravity
        }
        Vector3 directionY = _directionY; //updates the vector thats used for .Move to the current velocity
        controller.Move(directionY.normalized * velocity * Time.deltaTime); //movement of character for y axis (height)


        if (direction.magnitude >= 0.1) //Checks if a key was pressed by checking the vector3
        {
            anim.SetBool("isWalking", true);
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y; //Calculates the angle the player character moves in and adds the camera direction to move in the camera direction
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, smoothTime); //Smooths the turn of the player character so it dosnt look/feel clunky
            transform.rotation = Quaternion.Euler(0f, angle, 0f); //Sets the rotation which was calculated


            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward; //Calculates the move direction with turn angle
            if (!Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("isRunning", false);
                controller.Move(moveDir.normalized * speed * Time.deltaTime); //moves the Player in the calculated direction multiplied by speed and the time between the last frame and this frame
            }
            else
            {
                anim.SetBool("isRunning", true);
                controller.Move(moveDir.normalized * runningSpeed * Time.deltaTime); //moves the Player in the calculated direction multiplied by speed and the time between the last frame and this frame
            }

        }
        else
        {
            anim.SetBool("isWalking", false);
        }




    }

    private float checkDistanceToGround() //Sends raycast to floor and saves the object it hits insite hit. then checks the distance with hit.distance
    {
        RaycastHit hit = new RaycastHit();
        if(Physics.Raycast(transform.position, -Vector3.up, out hit)) //checks if raycast hits something
        {
            return hit.distance; //returns distance to "hit" object (most likely floor)
        }

        return float.MaxValue; //returns max value to prevent ability to jump
    }
}
