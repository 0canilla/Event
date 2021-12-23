using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EasyController : MonoBehaviour
{
    [SerializeField] private UnityEvent onEasyMode;
    private int times = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            times++;
            onEasyMode?.Invoke();
        }
        if (times == 1) Debug.Log("Desactivaste un cañon, ahora que?");
        if (times == 2) Debug.Log("ahora puedes escapar");
        
    }
}
