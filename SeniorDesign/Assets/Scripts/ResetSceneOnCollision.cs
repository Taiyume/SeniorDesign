using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class ResetSceneOnCollision : MonoBehaviour {

	
	// Update is called once per frame
	void OnCollisionEnter (Collision collision) {
            SceneManager.LoadScene("TestEnvironment_Jaylyn");
        }
	}

