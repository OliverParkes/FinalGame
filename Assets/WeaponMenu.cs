using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WeaponMenu : MonoBehaviour
{
    public static int WeaponNumber;
    

    // Update is called once per frame
    public void M82()
    {
        WeaponNumber = 1;
        SceneManager.LoadScene(1);
    }
    public void AK47()
    {
        WeaponNumber = 2;
        SceneManager.LoadScene(1);
    }
    public void P90()
    {
        WeaponNumber = 3;
        SceneManager.LoadScene(1);
    }
    public void Shotgun()
    {
        WeaponNumber = 4;
        SceneManager.LoadScene(1);
    }
}
