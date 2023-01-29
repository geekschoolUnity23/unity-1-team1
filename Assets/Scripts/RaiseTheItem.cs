using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseTheItem : MonoBehaviour
{
    public GameObject camera;
    public float distance = 15f;
    public bool canPickUp;
    public HealScript healScript;
    public int quantityHeal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void PickUp()
    {
        RaycastHit hit;

        if(Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, distance))
        {
            if(hit.transform.tag == "Iteam")
            {
                if(quantityHeal < 5)
                {
                    var m = hit.transform.gameObject;
                    DestroyObject(m);
                    quantityHeal++;
                }
                else
                {
                    return;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
        }
        
    }
}
