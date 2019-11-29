using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CameraController1 : MonoBehaviour {

    public Transform player;
    public Transform empty;
    float speed;
    public Text text;
    public Button button;
    bool start = true;
   
	// Use this for initialization
	void Awake () {

        speed = 0;
    }
	
	// Update is called once per frame
	void Update () {

       if(start)
            transform.position = Vector3.Lerp(transform.position, empty.position, speed*Time.deltaTime);
       
       if(Vector3.Distance(player.transform.position, empty.position) < 150)
        {
            Increment(out speed);
        }

       
        if ((player.transform.position.y<transform.position.y-40))
        {
            text.gameObject.SetActive(true);
            button.gameObject.SetActive(true);
            player.GetComponent<PlayerController>().yesOrNo = false;
            start = false;
            
            
        }
    }

    public float Increment(out float speed)
    {
        speed = +0.06f;
        return speed;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
        button.gameObject.SetActive(false);
    }
}
