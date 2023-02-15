using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectromagnZone : MonoBehaviour
{
    public FirstPersonMovement firstPersonMovement;
    public Crouch crouch;
    public Jump jump;
    public Animator cameraAnim;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cameraAnim.SetBool("RunCamera", false);
            firstPersonMovement.speed -= 6;
            firstPersonMovement.runSpeed -= 6;
            crouch.movementSpeed -= 4;
            jump.jumpStrength -= 3;
            cameraAnim.SetBool("ElectromagnZoneCameraEffect", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            firstPersonMovement.speed += 6;
            firstPersonMovement.runSpeed += 6;
            crouch.movementSpeed += 4;
            jump.jumpStrength += 3;
            cameraAnim.SetBool("ElectromagnZoneCameraEffect", false);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
