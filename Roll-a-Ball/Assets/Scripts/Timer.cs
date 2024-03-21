using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Include necessary references

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public GameObject losertext;
    [SerializeField] float enlapsedTime;
    private Main_Menu mainMenu;

    void Start()
    {
        mainMenu = GameObject.FindObjectOfType<Main_Menu>(); // Find Main_Menu in any scene
        losertext.SetActive(false);
    }

    void Update()
    {
        if (enlapsedTime >0)
        {
            enlapsedTime -= Time.deltaTime;
        }
        else if(enlapsedTime<0)
        {
            enlapsedTime=0;
            timerText.color=Color.red;
            losertext.SetActive(true);

            mainMenu.Playgame(0);
        }
        
        int minutes = Mathf.FloorToInt(enlapsedTime / 60); // Corrected method name
        int seconds = Mathf.FloorToInt(enlapsedTime % 60); // Corrected method name
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

       
            
    }
}
