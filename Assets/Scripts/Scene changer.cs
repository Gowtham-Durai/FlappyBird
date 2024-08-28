using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechanger : MonoBehaviour
{
    // Start is called before the first frame update
   AudioManager audioManager;
   GameObject Audio;

   void Start(){
    Audio=GameObject.FindGameObjectWithTag("Audio");
    audioManager=Audio.GetComponent<AudioManager>();
   }
   public void  playScene(){
    
    DontDestroyOnLoad(audioManager);
    SceneManager.LoadScene("GameScene");
    audioManager.addSFX(audioManager.Swoosh);
   }
}
