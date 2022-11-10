using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Break : MonoBehaviour
{
    public GameObject Block;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            BreahTheThing();
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Bullet(Clone)"))
        {
            BreahTheThing();
            Debug.Log("Hit");
        }
        if (other.tag.Equals("Blow"))
        {
            BreahTheThing();
            Debug.Log("BANG");
        }
    }
    public void BreahTheThing()
    {
        Instantiate(Block, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
