using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Bird : MonoBehaviour
{
    // Start is called before the first frame update\
    private Rigidbody2D rd;
    [SerializeField] 
    private float speed=4f;
    private Manager manager;
    public bool isAlive=true;
    private AudioManager audioManager;
    void Start()
    {   
        if(PlayerPrefs.HasKey("HighScore")){
            print(PlayerPrefs.GetFloat("HighScore"));
        }
        audioManager=GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();        rd=GetComponent<Rigidbody2D>();
        manager=GameObject.FindGameObjectWithTag("manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isAlive &&( Input.GetKeyDown(KeyCode.Space)
         || (Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Began)   ) ){
            audioManager.addSFX(audioManager.wing);
            rd.velocity=Vector2.up*speed; //(10,0)
        }
    }


    private void OnCollisionEnter2D(Collision2D other) {
        audioManager.addSFX(audioManager.die);
      
        manager.GameOver(); 
        isAlive=false;

    }
}
