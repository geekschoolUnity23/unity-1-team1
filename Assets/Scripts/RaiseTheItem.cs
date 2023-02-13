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
    public BulletController blAk;
    public BulletController blMakarov;



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
            if(hit.transform.tag == "PatronsMakarov")
            {
                if (blMakarov.StoreMachineCurrent < blMakarov.StoreMachineMax)
                {
                    var m = hit.transform.gameObject;
                    DestroyObject(m);
                    blMakarov.StoreMachineCurrent++;
                }
            }
            if (hit.transform.tag == "PatronsAk")
            {
                if (blAk.StoreMachineCurrent < blAk.StoreMachineMax)
                {
                    var m = hit.transform.gameObject;
                    DestroyObject(m);
                    blAk.StoreMachineCurrent++;
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
