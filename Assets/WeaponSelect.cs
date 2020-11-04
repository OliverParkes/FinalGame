using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public GameObject M82;
    public GameObject P90;
    public GameObject AK47;
    public GameObject ShotGun;

    
    void Start()
    {
        int wepEquip = WeaponMenu.WeaponNumber;

        if(wepEquip == 1)
        {
            M82.SetActive(true);
        }
        if(wepEquip == 2)
        {
            AK47.SetActive(true);
        }
        if(wepEquip == 3)
        {
            P90.SetActive(true);
        }
        if(wepEquip == 4)
        {
            ShotGun.SetActive(true);
        }
    }

    
}
