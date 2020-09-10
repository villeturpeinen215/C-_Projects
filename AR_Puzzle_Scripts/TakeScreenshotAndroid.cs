using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TakeScreenshotAndroid : MonoBehaviour
{


    public void TakeAShot()
    {
        StartCoroutine("CaptureIt");
    }

    IEnumerator CaptureIt()
    {
        string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        string fileName = "Screenshot" + timeStamp + ".png";
        string pathToSave = fileName;

        //Hide buttons from screenshot
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;
        yield return new WaitForEndOfFrame();

        //Take screenshot
        ScreenCapture.CaptureScreenshot(pathToSave);

        //Bring buttons back after screenshot
        yield return new WaitForEndOfFrame();
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;

    }

}
