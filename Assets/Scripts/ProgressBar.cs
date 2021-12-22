using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Player Player;
    public Transform FinishPlatform;
    public Slider Slider;
    public float AcceptableFinishPlayerDistance = 0.2f;
    private float _startY;
    private float _minimumReachedY;

    private void Start()
    {
        _startY = Player.transform.position.y;
    }

    private void Update()
    {
        _minimumReachedY = Mathf.Min(_minimumReachedY, Player.transform.position.y);
        float _currentY = Player.transform.position.y;
        float _finishY = FinishPlatform.position.y;
        float _t = Mathf.InverseLerp(_startY, _finishY + AcceptableFinishPlayerDistance, _minimumReachedY);
        Slider.value = _t;
    }
}
