using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle : MonoBehaviour
{
    // Start is called before the first frame update

    Manager manager;
    AudioManager audioManager;
    void Start()
    {
        audioManager=GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        manager=GameObject.FindWithTag("manager").GetComponent<Manager>();    }

    // Update is called once per frame
    

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            audioManager.addSFX(audioManager.Point);
             manager.addScore();
        }
    }



    
}
