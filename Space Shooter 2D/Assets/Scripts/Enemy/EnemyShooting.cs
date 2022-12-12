using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject enemyShipObject;
    public Transform spawnPoint;
    public GameObject standardBullet;
    public float shootingSpeed = 5f;
    bool canShoot = true;
    void Start()
    {

        InvokeRepeating("Shooting", 1f, 2f);


    }
    void Shooting()
    {
        GameObject bullet = Instantiate(standardBullet, spawnPoint.position, spawnPoint.rotation);
        bullet.transform.Rotate(Vector3.forward * -90);

        bullet.GetComponent<Rigidbody2D>().velocity = spawnPoint.up * -1.0f * shootingSpeed;
        Destroy(bullet, 5f);
    }

    
}
