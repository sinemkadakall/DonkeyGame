using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private new Rigidbody2D rigidbody;
    private Vector2 direction;
    public float speed=1f;
    public float jumpSpeed=1f;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            direction = Vector2.up * jumpSpeed;
        }
        else
        {
            direction += Physics2D.gravity * Time.deltaTime;
        }
        direction.x = Input.GetAxis("Horizontal")*speed;
        direction.y = Mathf.Max(direction.y, -1f);

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
