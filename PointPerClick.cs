using UnityEngine;
using UnityEngine.UI;

public class PointPerClick : MonoBehaviour
{

    public Text CountText; //we receive the invoice text
    public Text StrangeText; //we get the text of power
    public Button Button_C; //we get a button
    public int CountClick = 1; //step power
    public int currentTens = 0;//how many 10-point scores are currently available
    public int rewardedTens = 0;//how many reward points are there in total
    public int Clicks = 0; //click counter

    public void AddPoint()
    {
        Button_C.GetComponent<Image>().color = new Color(255, 255, 255);
        int CT = int.Parse(CountText.text); //we put the text value in a variable
        CT += CountClick; //text + step
        Clicks++;
        currentTens = Clicks / 10;
        if (rewardedTens < currentTens)// +2 every 10 clicks
        {
            rewardedTens++;
            CountClick+=2;
            Button_C.GetComponent<Image>().color = new Color(255, 0, 0);// every 10 clicks, change the color to red
        }
        CountText.text = CT.ToString();//returning the value to the text
        StrangeText.text = CountClick.ToString();
    }
}
