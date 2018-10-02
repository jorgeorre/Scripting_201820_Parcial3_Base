using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text timerText;
    private GameController time;

    // Use this for initialization
    private void Start()
    {
        if (timerText == null)
        {
            enabled = false;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}