using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStart : MonoBehaviour
{
    public Transform startPosition;

    void Start()
    {
        if (startPosition != null)
        {
            transform.position = startPosition.position;
            Debug.Log("PlayerStart Start - startPosition: " + startPosition.position);
        }
    }
}
