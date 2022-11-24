using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(FPSCounter))]
public class FPSDisplay : MonoBehaviour
{
    [SerializeField] private Text averageLabel;
    [SerializeField] private Text highestLabel;
    [SerializeField] private Text lowestLabel;
    [SerializeField] private FPSColor[] fpsColor;

    private FPSCounter _fpsCounter;
    private StringBuilder _stringBuilder;


    private void Awake()
    {
        _fpsCounter = GetComponent<FPSCounter>();
        _stringBuilder = new StringBuilder(4);
    }

    private void Update()
    {
        Display(averageLabel, _fpsCounter.AverageFps);
        Display(highestLabel, _fpsCounter.HighestFps);
        Display(lowestLabel, _fpsCounter.LowestFps);
    }

    private void Display(Text label, int fps)
    {
        _stringBuilder.Clear();
        _stringBuilder.Insert(0, fps);
        label.text = _stringBuilder.ToString();
    }
    
    [Serializable] private struct FPSColor
    {
        public Color color;
        public int minFPS;
    } 
}
