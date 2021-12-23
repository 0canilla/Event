using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float Speed = 5f;
    [SerializeField] public float HP = 100;
    [SerializeField] private GameObject bullet;
    private float DB;
    float cameraX;
    float cameraY;
    public static event Action onDeath;
    public static event Action<float> OnHealthLeft;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GameObject.Find("Bullet");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Move(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Move(Vector3.left);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Move(Vector3.back);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.right);
        }
        Rotate();
    }

    private void Move(Vector3 direction)
    {
        transform.Translate(Speed * Time.deltaTime * direction);
    }

    private void Rotate()
    {
        cameraX += Input.GetAxis("Mouse X");
        cameraY += Input.GetAxis("Mouse Y");
        Quaternion Angulo = Quaternion.Euler(-cameraY, cameraX, 0);
        transform.localRotation = Angulo;
    }

    private void OnCollisionEnter(Collision collision)
    {
        DB = bullet.GetComponent<BulletController>().Damage;
        if (collision.gameObject.tag == "Enemy")
        {
            HP -= DB;
            Debug.Log(HP);
            OnHealthLeft?.Invoke(HP);
        }
        if (HP <= 0)
        {
            onDeath();
        }
    }
}
