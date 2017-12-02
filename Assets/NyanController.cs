using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NyanController : MonoBehaviour {

  public AudioClip nyanAudio1;
  public AudioClip nyanAudio2;
  public AudioClip nyanAudio3;

  public float nyanSpeed = 200f;
  AudioSource auS;
  Rigidbody rib;
  // Use this for initialization
  void Start () {
    rib = gameObject.GetComponent<Rigidbody>();
    auS = gameObject.GetComponent<AudioSource>();
    int i = Random.Range(1, 4);

    switch (i)
    {
      case 1: 
        auS.clip = nyanAudio1;
       
        break;
      case 2:
        auS.clip = nyanAudio2;
       
        break;
      case 3:
      
        auS.clip = nyanAudio3;
        break;

      default:
       
        auS.clip = nyanAudio1;
        
        break;
    }
    auS.Play();
    Vector3 force = Random.insideUnitSphere * nyanSpeed;
    rib.AddForce(force);
    
	}
	
	// Update is called once per frame
	void Update () {
		if(rib.velocity.magnitude < 5f)
    {
      Vector3 force = Random.insideUnitSphere * nyanSpeed;
      rib.AddForce(force);
    }
	}

  private void OnMouseDown()
  {
    Destroy(gameObject);
  }
}
