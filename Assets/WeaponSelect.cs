using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public GameObject M82;
    public GameObject P90;
    public GameObject Pchan;
    public GameObject AK47;
    public GameObject ShotGun;
    public GameObject M82UI;
    public GameObject P90UI;
    public GameObject AK47UI;
    public GameObject ShotgunUI;



    void Start()
    {
        int wepEquip = WeaponMenu.WeaponNumber;

        if (wepEquip == 1)
        {
            M82.SetActive(true);
            M82UI.SetActive(true);
        }
        if (wepEquip == 2)
        {
            AK47.SetActive(true);
            AK47UI.SetActive(true);
        }
        if (wepEquip == 3)
        {
            int rand = Random.Range(1, 50);
            if (rand == 50)
            {
                Pchan.SetActive(true);
            }
            else
            {
                P90.SetActive(true);
                P90UI.SetActive(true);
            }
        }


        if (wepEquip == 4)
        {
            ShotGun.SetActive(true);
            ShotgunUI.SetActive(true);
        }
    }
}
    

    

