using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GunScript : MonoBehaviour
{
    public Rigidbody projectile;
    public GameObject bullet;

    public float speed = 20;
    PhotonView view;



    // Use this for initialization
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            
            if (Input.GetButtonDown("Fire1"))
            {
                shoot();
            }
        }
    }
   
    public void shoot()
    {
        GameObject bullet = PhotonNetwork.Instantiate("bullet", transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, speed));
    }
}
