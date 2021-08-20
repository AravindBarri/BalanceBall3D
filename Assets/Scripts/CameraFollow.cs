using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Vector3 offset;

    Transform playerTransform;

    float delayspeed = 10f;
    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        Vector3 camposition = playerTransform.position + offset;

        transform.position = Vector3.Lerp(transform.position, camposition, Time.deltaTime * delayspeed);

        //transform.LookAt(playerTransform);
    }
}
