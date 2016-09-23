using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

    private float speed = -0.2f;

    private float deadLine = -10;
    private float collisionTest;
    public AudioClip impact;
    AudioSource audio;
    // Use this for initialization
    void Start () {

        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(this.speed, 0, 0);

        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Cube" || other.gameObject.tag == "groud")
        {
            audio.PlayOneShot(impact, 0.7F);
        } 
    }
}
