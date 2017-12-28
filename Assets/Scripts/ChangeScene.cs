using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public string Destination { get; set; }

	// Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
    void Update ()
    {
	}

    public void SwapScene()
    {
        SceneManager.LoadScene(Destination);
    }
}
