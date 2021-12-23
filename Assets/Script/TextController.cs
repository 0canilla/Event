using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] public Text Points;
    [SerializeField] public Text Health;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerController.OnHealthLeft += OnHealthLeftHandler;
        Health.text = "HP 100";
    }

    // Update is called once per frame
    void Update()
    {
        Point();
    }

    private void Point()
    {
        Points.text = "Points" + " " + Gamemanager.instance.scoreinstanciado;
    }

    private void OnHealthLeftHandler(float lives)
    {
        Health.text = "HP " + lives;
    }
}
