using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private Vector3 offset;
    [SerializeField] Vector3 newPos;

    [SerializeField] [Range(0,3)] private float lerpValue;
    void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    void LateUpdate()
    {
        SetCameraFollow();
    }

    private void SetCameraFollow(){
        newPos = Vector3.Lerp(transform.position,playerTransform.position + offset, lerpValue* Time.deltaTime);
        transform.position = newPos;
    }
}
