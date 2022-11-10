using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Playz()
    {
        Debug.Log("play");
        SceneManager.LoadScene("Loading");


    }

    // Update is called once per frame
    void Update()
    {

    }
}
