using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End3 : MonoBehaviour


{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(5);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}