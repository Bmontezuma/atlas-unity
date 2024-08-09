using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TimerTrigger Start");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        Debug.Log("Player exited trigger");
        Player.GetComponent<Timer>().enabled = true;
    }
}