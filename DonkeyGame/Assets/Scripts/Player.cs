using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private new Rigidbody2D rigidbody;
    private Vector2 direction;
    public float speed=1f;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal")*speed;
       // direction.y = Input.GetAxis("Vertical")*speed;

        if(direction.x > 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
        else if(direction.x < 0)
        {
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position+direction*Time.fixedDeltaTime);
    }




}
