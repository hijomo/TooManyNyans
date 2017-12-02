using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

  public GameObject nyan;
  float nextNyan;

	// Use this for initialization
	void Start () {
    nextNyan = Time.time + 2.5f;
    
	}
	
	// Update is called once per frame
	void Update () {
    if (nextNyan < Time.time)
    {
      Instantiate(nyan, Vector3.zero, Quaternion.identity);
      nextNyan = Time.time + 2.5f;
    }
	}
}
