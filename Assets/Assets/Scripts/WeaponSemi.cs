using UnityEngine;
using System.Collections;

public class WeaponSemi : MonoBehaviour
{
    public float damage;
    public float range;
    public float firerate;
    public float recoil;

    public int m_maxAmmo;
    public int m_currentAmmo;
    public float m_reloadTIme;

    private bool isReloading = false;

    public Camera FPScam;

    public ParticleSystem MuzzleFlash;
    private Rigidbody RB;

    

    // Update is called once per frame

    private void Awake()
    {
        m_currentAmmo = m_maxAmmo;
    }
    private void Start()
    {
        RB = GetComponentInParent<Rigidbody>();
    }
    void Update()
    {
        if (isReloading == true)
            return;
        if (m_currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetButtonDown("Fire1") )
        {
            MuzzleFlash.Play();
            Shoot();

        }
    }

    void Shoot()
    {
        m_currentAmmo--;
        RaycastHit hit;
        if (Physics.Raycast(FPScam.transform.position, FPScam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Health HP = hit.transform.GetComponent<Health>();
            if (HP != null)
            {
                HP.TakeDamage(damage);
            }
        }
    }

    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("reloading");

        yield return new WaitForSeconds(m_reloadTIme);
        m_currentAmmo = m_maxAmmo;
        isReloading = false;
    }
}

    
