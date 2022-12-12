using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    float moveSpeed = 3f;
    float gravity = 9.8f;
    float roatationSpeed = 0.15f;
    float roateDegreesPerSec = 180f;



    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            Vector3 moveDir = transform.forward;
            moveDir.y -= gravity * Time.deltaTime;
            characterController.Move(moveDir * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            Vector3 moveDir = -transform.forward;
            moveDir.y -= gravity * Time.deltaTime;
            characterController.Move(moveDir * moveSpeed * Time.deltaTime);

        }
    }

    void Rotate()
    {
        Vector3 rotationDir = Vector3.zero;
        if (Input.GetAxis("Horizontal") < 0)
        {
            rotationDir = transform.TransformDirection(Vector3.left);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            rotationDir = transform.TransformDirection(Vector3.right);

        }
        if(rotationDir!=Vector3.zero)
        {
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation, Quaternion.LookRotation(rotationDir), roateDegreesPerSec * Time.deltaTime);
        }
    }
}
