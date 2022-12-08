using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject standardBullet, specialBullet;
    public float shootingSpeed = 5f;
    bool SingleGun = true;
    bool DoubbleGun = false;


    // Update is called once per frame
    void Update()
    {
        SwitchGuns();

        if (Input.GetMouseButtonDown(0))
        {
            if (SingleGun == true)
            {
                GameObject bullet = Instantiate(standardBullet, spawnPoint[0].position, spawnPoint[0].rotation);
                bullet.transform.Rotate(Vector3.forward * -90);
                bullet.GetComponent<Rigidbody2D>().velocity = spawnPoint[0].up * shootingSpeed;
            }
            else if (DoubbleGun == true)
            {
                GameObject bullet1 = Instantiate(specialBullet, spawnPoint[1].position, spawnPoint[1].rotation);
                GameObject bullet2 = Instantiate(specialBullet, spawnPoint[2].position, spawnPoint[2].rotation);
                bullet1.transform.Rotate(Vector3.forward * -90);
                bullet2.transform.Rotate(Vector3.forward * -90);
                bullet1.GetComponent<Rigidbody2D>().velocity = spawnPoint[1].up * shootingSpeed;
                bullet2.GetComponent<Rigidbody2D>().velocity = spawnPoint[2].up * shootingSpeed;
            }
        }
    }

    void SwitchGuns()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SingleGun = true;
            DoubbleGun = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SingleGun = false;
            DoubbleGun = true;
        }
    }
}
