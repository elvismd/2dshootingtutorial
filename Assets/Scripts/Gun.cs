using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firePoint;
    public ParticleSystem muzzleFlashVfx;
    public GameObject bulletPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlashVfx.Play();
        GameObject bulletInstance = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        //RaycastHit2D hit = Physics2D.Raycast(firePoint.position, firePoint.right);
        //if(hit) // If this is true then it hits something
        //{
        //    Debug.Log("Hit " + hit.collider.gameObject);

        //    Enemy enemy = hit.collider.gameObject.GetComponent<Enemy>();
        //    if(enemy != null)
        //    {
        //        enemy.GetDamage();
        //    }
        //}
    }
}
