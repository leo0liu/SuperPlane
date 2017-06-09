using UnityEngine;
using System.Collections;

public class Effects : MonoBehaviour {

    AudioSource aud;
    void Start()
    {
        aud =transform.GetComponent<AudioSource>();
        aud.Play();
    }

    public void destroy() {
        Destroy(gameObject, 3f);
    }

    public void destroy_bullet() {
        Destroy(gameObject, 0.8f);
    }
    public void Play_DieSound() {
        
    }
	
	

	
}
