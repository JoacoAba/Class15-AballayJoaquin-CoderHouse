using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMov : MonoBehaviour
{
    public Transform player;
    [Range(5, 10)] protected float DesDelay = 8f;
    [SerializeField][Range(1, 3)] float speed = 2f;
    void Start()
    {
        Invoke("DestroyBullet", DesDelay);
    }

    void Update() 
    {
        Move(); 
    }

    public virtual void DestroyBullet()
    {
        Destroy(gameObject);
    }

    public virtual void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
