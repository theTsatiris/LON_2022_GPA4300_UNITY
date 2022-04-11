using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public void MoveForward()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void MoveBackwards()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
    }

    public void MoveLeft()
    {
        transform.position -= transform.right * speed * Time.deltaTime;
    }

    public void MoveRight()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
