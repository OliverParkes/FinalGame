using UnityEngine;
using System.Collections;

public class WeaponEnemy : MonoBehaviour
{
    public float damage;
    public float range;
    public float firerate;
    public float recoil;
    public LayerMask mask;
    public float spread;

    public ParticleSystem Impact;

    public int m_maxAmmo;
    public int m_currentAmmo;
    public float m_reloadTIme;

    private bool isReloading = false;

    public ParticleSystem MuzzleFlash;
    public AudioSource GunShot;
    private Rigidbody RB;
    public GameObject Muzzle;

    private float nextTimetoFire = 0f;

    // Update is called once per frame

    private void Awake()
    {
        m_currentAmmo = m_maxAmmo;
    }

    

    private void Update()
    {
    
        if (TriggerDetection.Firing == true)
        {
            if (isReloading == true)
                return;
            if (m_currentAmmo <= 0)
            {
                StartCoroutine(Reload());
                return;
            }
            if (Time.time >= nextTimetoFire)
            {
                nextTimetoFire = Time.time + 1f / firerate;
                MuzzleFlash.Play();
                GunShot.Play();
                Shoot();

                transform.Rotate(200 * Time.deltaTime*10, 0f, 0f);
                
            }
        }
        
    }

    void Shoot()
    {
        GunShot.Play();
        m_currentAmmo--;
        RaycastHit hit;
        if (Physics.Raycast(Muzzle.transform.position, (Muzzle.transform.forward + Random.insideUnitSphere*spread).normalized, out hit, range, mask))
        {
            Debug.Log(hit.transform.name);

            Health HP = hit.transform.GetComponent<Health>();
            if (HP != null)
            {
                HP.TakeDamage(damage);
            }
            Instantiate(Impact, hit.point, Quaternion.LookRotation(hit.normal));
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
