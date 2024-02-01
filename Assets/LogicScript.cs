using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public PlayerMovement pm;
    public Text Speed;

    public Rigidbody rb;


    public void Update()
    {
        var vel = rb.velocity;
        Speed.text = vel.magnitude.ToString();
    }
}
