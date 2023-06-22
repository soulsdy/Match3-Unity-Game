﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelGame : MonoBehaviour,IMenu
{
    public Text LevelConditionView;

    [SerializeField] private Button btnPause;
    [SerializeField]  Button btnRestart;
    private UIMainManager m_mngr;


    private void Awake()
    {
        btnPause.onClick.AddListener(OnClickPause);
        btnRestart.onClick.AddListener(OnRestartClick);
    }

    private void OnClickPause()
    {
        m_mngr.ShowPauseMenu();
    }
    void OnRestartClick(){
        m_mngr.RestartGame();
    }
    public void Setup(UIMainManager mngr)
    {
        m_mngr = mngr;
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
