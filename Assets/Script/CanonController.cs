using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    [SerializeField] private float distance = 5f;
    [SerializeField] private GameObject shootOrigin;
    [SerializeField] private float shootcooldown = 2.5f;
    private bool shoot = true;
    [SerializeField] private float timeShoot;
    [SerializeField] private GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shoot == true)
        {
            RaycastCannon();
        }
        else
        {
            timeShoot += Time.deltaTime;
        }

        if (timeShoot > shootcooldown)
        {
            shoot = true;
        }
    }

    private void RaycastCannon()
    {
        RaycastHit hit;
        if (Physics.Raycast(shootOrigin.transform.position, shootOrigin.transform.TransformDirection(Vector3.forward), out hit, distance))
        { 
            shoot = false;
            timeShoot = 0;
            Instantiate(Bullet, shootOrigin.transform.position, Quaternion.identity);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(shootOrigin.transform.position, shootOrigin.transform.TransformDirection(Vector3.forward) * distance);
    }
}
