using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(BoxCollider))]
public class CharController : MonoBehaviour
{
  public FixedJoystick fJoystick;
  [SerializeField] private Rigidbody _rigidbody;
  public float speed;
  public float turnSpeed;
  public List<GameObject> HandcuffList = new List<GameObject>();
  public List<GameObject> ThiefList = new List<GameObject>();

  private void FixedUpdate()
  {

    _rigidbody.velocity = new Vector3(fJoystick.Horizontal * speed, _rigidbody.velocity.y, fJoystick.Vertical * speed);

    if (fJoystick.Horizontal != 0 || fJoystick.Vertical != 0)
    {
      transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
    }
  }

  
}
