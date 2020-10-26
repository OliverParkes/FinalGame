using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SemiAutomatic : MonoBehaviour
{
    
    public PlayerWeapons weapon;
    [SerializeField]
    private Camera cam;

    [SerializeField]
    public LayerMask mask;
    void Start()
    {
        if(cam == null)
        {
            Debug.LogError("No Camera: semiAutomatic");
            this.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("fired");
            Shoot();
        }
    }
    
    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, weapon.range, mask))
        {
            if (hit.collider.tag == "RemotePlayer")
            {
                CmdPlayerShot(hit.collider.name);
            }
        }
    }

    
    void CmdPlayerShot(string ID)
    {
        Debug.Log(ID + "has been shot");
    }
}
