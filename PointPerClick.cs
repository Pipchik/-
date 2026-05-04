using UnityEngine;
using UnityEngine.UI;

public class PointPerClick : MonoBehaviour
{

    public Text CountText; //получаем текст счёта
    public Text StrangeText; //получаем текст силы
    public Button Button_C; //получаем кнопку
    public int CountClick = 1; //сила шага
    public int currentTens = 0;//сколько всего очков по 10
    public int rewardedTens = 0;//сколько всего очков по 10
    public int Clicks = 0;

    public void AddPoint()
    {
        Button_C.GetComponent<Image>().color = new Color(255, 255, 255);
        int CT = int.Parse(CountText.text); //значение текста помещаем в переменную
        CT += CountClick; // текст + шаг
        Clicks++;
        currentTens = Clicks / 10;
        if (rewardedTens < currentTens)// сначала +1, потом +2 каждые 10 очков
        {
            rewardedTens++;
            CountClick+=2;
            Button_C.GetComponent<Image>().color = new Color(255, 0, 0);// изменяем цвет на красный
        }
        CountText.text = CT.ToString();//возврощаем значение в текст
        StrangeText.text = CountClick.ToString();
    }
}
