using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float lifeTime = 2f;
    private void Awake()
    {
        Destroy(gameObject, lifeTime);
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag=="Bullet" || target.tag == "Enemy")
        {
            gameObject.SetActive(false);
        }   
    }
}   
