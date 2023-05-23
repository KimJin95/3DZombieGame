using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public float rotateSpeed = 180;

    private PlayerInput playerInput;

    private Rigidbody playerRigidBody;
    private Animator playerAnimator;


    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        playerAnimator = GetComponent<Animator>();

        //파라미터 호출 방식
        //1.float int bool Trigger\
       
    }
    private void Move()
    {
        Vector3 playerPos = playerInput.move * transform.forward * Time.deltaTime * moveSpeed;
        playerRigidBody.MovePosition(playerRigidBody.position + playerPos);

        //1.Addforce -> 힘을 가해서
        //2.velocity -> 속도를 줘서
        //3.MovePosition -> 위치값을 더해서
    }

    private void Rotate()
    {
        float turn = playerInput.rotate * rotateSpeed * Time.deltaTime;
        playerRigidBody.rotation = playerRigidBody.rotation * Quaternion.Euler(0, turn, 0); //x,z 축 고정중 = 0
    }

    private void FixedUpdate()
    {
        Move();

        Rotate();
    }

}
