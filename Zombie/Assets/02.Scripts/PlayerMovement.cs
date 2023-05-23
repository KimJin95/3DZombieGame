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

        //�Ķ���� ȣ�� ���
        //1.float int bool Trigger\
       
    }
    private void Move()
    {
        Vector3 playerPos = playerInput.move * transform.forward * Time.deltaTime * moveSpeed;
        playerRigidBody.MovePosition(playerRigidBody.position + playerPos);

        //1.Addforce -> ���� ���ؼ�
        //2.velocity -> �ӵ��� �༭
        //3.MovePosition -> ��ġ���� ���ؼ�
    }

    private void Rotate()
    {
        float turn = playerInput.rotate * rotateSpeed * Time.deltaTime;
        playerRigidBody.rotation = playerRigidBody.rotation * Quaternion.Euler(0, turn, 0); //x,z �� ������ = 0
    }

    private void FixedUpdate()
    {
        Move();

        Rotate();
    }

}
