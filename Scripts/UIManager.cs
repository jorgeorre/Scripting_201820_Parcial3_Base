using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text timerText;
    private GameController timeSet;
    private float showTime;
    // Use this for initialization
    private void Start()
    {
        showTime = Time.time;

        if (timerText == null)
        {
            enabled = false;
        }
    }

    // Update is called once per frame
    private void Update()
    {

        float time = Time.time - showTime;

        string minutos = ((int)time / 60).ToString();
        string segundos = (time % 60).ToString("f1");

        timerText.text = minutos + ":" + segundos;
    }
}