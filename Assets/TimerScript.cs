using UnityEngine;
using TMPro; // Supports the timerText

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timerText; //used for TextMeshPro

	private float secondsCount; //variable for seconds
	private int minuteCount; //variable for minutes
	private int hourCount; //variable for hours

    void Update()
    {
        UpdateTimerUI();
    }

//call this on update
    public void UpdateTimerUI(){
		//set timer UI
		secondsCount += Time.deltaTime;
		timerText.text = $"{hourCount:D2}:{minuteCount:D2}:{(int)secondsCount:D2}";
        //D2 is inserted to ensure each set has 2 numbers displayed at all times.
		if(secondsCount >= 60){
			minuteCount++;
			secondsCount = 0;
		}else if(minuteCount >= 60){
			hourCount++;
			minuteCount = 0;
		}	
	}
    //Source Used: https://discussions.unity.com/t/time-counter-up/21195/6 by RonnyKibet
}
