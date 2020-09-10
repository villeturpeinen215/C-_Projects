﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmQuit : MonoBehaviour {
    public CanvasGroup uiCanvasGroup;
    public CanvasGroup confirmQuitCanvasGroup;
    // Use this for initialization
    private void Awake()
    {
        //disable the quit confirmation panel
        DoConfirmQuitNo();
    }

    /// <summary>
    /// Called if clicked on No (confirmation)
    /// </summary>
    public void DoConfirmQuitNo()
    {
        Debug.Log("Back to the puzzle");

        //enable the normal ui
        uiCanvasGroup.alpha = 1;
        uiCanvasGroup.interactable = true;
        uiCanvasGroup.blocksRaycasts = true;

        //disable the confirmation quit ui
        confirmQuitCanvasGroup.alpha = 0;
        confirmQuitCanvasGroup.interactable = false;
        confirmQuitCanvasGroup.blocksRaycasts = false;
    }

    /// <summary>
    /// Called if clicked on Yes (confirmation)
    /// </summary>
    public void DoConfirmQuitYes()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }

    /// <summary>
    /// Called if clicked on Quit
    /// </summary>
    public void DoQuit()
    {
        Debug.Log("Check form quit confirmation");

        //enable interraction with confirmation gui and make visible
        confirmQuitCanvasGroup.alpha = 1;
        confirmQuitCanvasGroup.interactable = true;
        confirmQuitCanvasGroup.blocksRaycasts = true;
    }

}
