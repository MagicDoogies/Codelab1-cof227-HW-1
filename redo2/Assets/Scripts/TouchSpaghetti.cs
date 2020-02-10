using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSpaghetti : MonoBehaviour
{
    /*public AudioClip Eat;
    public float Volume;*/
    public AudioSource Eat;
    // Start is called before the first frame update
    void Start()
    {
        Eat = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Eat.Play();
    }
}
