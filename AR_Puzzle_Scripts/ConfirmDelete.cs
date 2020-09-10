using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmDelete : MonoBehaviour
{
    public CanvasGroup uiCanvasGroup;
    public CanvasGroup confirmDeleteCanvasGroup;
    private ScreenshotPreview ssP;


    private void Awake()
    {
        //disable the delete confirmation panel
        DoConfirmDeleteNo();

        //create a handle for ScreenshotPreview script,
        //so that the methods from it can be used here
        ssP = GameObject.FindObjectOfType(typeof(ScreenshotPreview)) as ScreenshotPreview;
    }


    /// <summary>
    /// Called if clicked on Delete
    /// </summary>
    public void DoDelete()
    {
        Debug.Log("Check form delete confirmation");

        //enable interraction with confirmation gui and make visible
        confirmDeleteCanvasGroup.alpha = 1;
        confirmDeleteCanvasGroup.interactable = true;
        confirmDeleteCanvasGroup.blocksRaycasts = true;
    }

    /// <summary>
    /// Called if clicked on No (confirmation)
    /// </summary>
    public void DoConfirmDeleteNo()
    {
        Debug.Log("Back to the gallery");

        //enable the normal ui
        uiCanvasGroup.alpha = 1;
        uiCanvasGroup.interactable = true;
        uiCanvasGroup.blocksRaycasts = true;

        //disable the confirmation delete ui
        confirmDeleteCanvasGroup.alpha = 0;
        confirmDeleteCanvasGroup.interactable = false;
        confirmDeleteCanvasGroup.blocksRaycasts = false;
    }

    /// <summary>
    /// Called if clicked on Yes (confirmation)
    /// </summary>
    public void DoConfirmDeleteYes()
    {
        Debug.Log("Deleting image...");
        //Call the DeleteImage method from ScreenshotPreview and delete current image
        ssP.DeleteImage();

        //disable the confirmation delete ui
        confirmDeleteCanvasGroup.alpha = 0;
        confirmDeleteCanvasGroup.interactable = false;
        confirmDeleteCanvasGroup.blocksRaycasts = false;
    }

}