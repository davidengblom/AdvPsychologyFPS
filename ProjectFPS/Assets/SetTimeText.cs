using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimeText : MonoBehaviour
{
    public GetTimer gameTimer;
    public Text text;

    private void Update() => text.text = gameTimer.timer.ToString();
}
