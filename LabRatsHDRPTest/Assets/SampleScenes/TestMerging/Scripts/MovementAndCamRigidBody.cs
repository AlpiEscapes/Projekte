using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAndCamRigidBody : MonoBehaviour
{

    private Rigidbody controller; //The character controller of the player character

    public float speed = 6f; //The speed at which the player character moves
    public float runningSpeed = 12f;
    public float smoothTime = 0.1f; //The speed at which the character turns
    private float turnSmoothVelocity; //Holds the turn velocity
    private Transform cam; //The transform of the camera that follows the player character

    //Used to track double taps for movement dashes
    public float tapSpeed = 0.3f; //in seconds how long the user has time to press again
    private float lastTapTime = 0; //Time since last pressed


    public float jumpHeight = 10;

    private Vector3 _directionY;

    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<Rigidbody>(); //Gets the Rigidbody component of the player character
        cam = GameObject.FindGameObjectWithTag("Camera").transform; //Gets the transform of the camera that follows the player
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!anim.GetBool("isPunching"))
        {
            float horizontal = Input.GetAxisRaw("Horizontal"); //Gets the horizontal input of the keyboard (AD) or of the controller
            float vertical = Input.GetAxisRaw("Vertical"); //Gets the vertical input of the keyboard (WS) or of the controller
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized; //Creates the direction in which the character moves by inputs. If two keys are pressed at the same time the charcter dosent move faster because of normalization




            if (Input.GetButtonDown("Jump") && checkDistanceToGround() < 0.007f) //checks if jump button is pressed
            {
                anim.SetTrigger("jump");
                _directionY.y = jumpHeight; //sets y value to jumpheight
                controller.AddForce(_directionY, ForceMode.Impulse);
            }

            if (direction.magnitude >= 0.1) //Checks if a key was pressed by checking the vector3
            {
                anim.SetBool("isWalking", true);
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y; //Calculates the angle the player character moves in and adds the camera direction to move in the camera direction
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, smoothTime); //Smooths the turn of the player character so it dosnt look/feel clunky
                transform.rotation = Quaternion.Euler(0f, angle, 0f); //Sets the rotation which was calculated


                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward; //Calculates the move direction with turn angle


                controller.AddForce(moveDir * speed * Time.deltaTime, ForceMode.VelocityChange);

                if (Input.GetKeyDown(GameManager.GM.forward))
                {
                    if ((Time.time - lastTapTime) < tapSpeed)
                    {
                        Debug.Log("double tap");
                        controller.AddForce(moveDir * speed * Time.deltaTime * 10, ForceMode.VelocityChange);

                    }
                    lastTapTime = Time.time;
                }

                if (!Input.GetKey(KeyCode.LeftShift))
                {
                    anim.SetBool("isRunning", false);
                    controller.AddForce(moveDir * speed * Time.deltaTime, ForceMode.VelocityChange); //moves the Player in the calculated direction multiplied by speed and the time between the last frame and this frame
                }
                else
                {
                    anim.SetBool("isRunning", true);
                    controller.AddForce(moveDir * runningSpeed * Time.deltaTime, ForceMode.VelocityChange); //moves the Player in the calculated direction multiplied by speed and the time between the last frame and this frame
                }

            }
            else
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", false);
            }
        }


        
    }


    private float checkDistanceToGround() //Sends raycast to floor and saves the object it hits insite hit. then checks the distance with hit.distance
    {
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(transform.position, -Vector3.up, out hit)) //checks if raycast hits something
        {
            return hit.distance; //returns distance to "hit" object (most likely floor)
        }

        return float.MaxValue; //returns max value to prevent ability to jump
    }

}
