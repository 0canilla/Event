using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float enemySpeed = 10f;
    [SerializeField] private Vector3 direction;
    [SerializeField] public float Damage = 20;
    [SerializeField] private GameObject Shooting;
    // Start is called before the first frame update
    void Start()
    {
        Shooting = GameObject.Find("Shooting");
    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.forward;
        MoveTo(direction);
    }

    private void MoveTo(Vector3 Direction)
    {
        transform.position += enemySpeed * direction * Time.deltaTime;
    }

}
