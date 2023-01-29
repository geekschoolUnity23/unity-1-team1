using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGravityZone : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject player;
    public float force;
    public FirstPersonMovement playerMoveScript;
    public AudioSource _audioSourceStart;
    public AudioSource _audioSourceEnd;
    public AudioSource _audioSourceNahod;
    public Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        var rb = other.GetComponent<Rigidbody>();
        rb.AddForce(player.transform.up * force);
        rb.useGravity = false;
        _audioSourceStart.Play();
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("AntiGravityEffect", true);
            playerMoveScript.speed = 5;
            playerMoveScript.runSpeed = 5;
            _audioSourceNahod.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var rb = other.GetComponent<Rigidbody>();
        rb.useGravity = true;
        _audioSourceEnd.Play();
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("AntiGravityEffect", false);
            playerMoveScript.speed = 15;
            playerMoveScript.runSpeed = 20;
            _audioSourceNahod.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
