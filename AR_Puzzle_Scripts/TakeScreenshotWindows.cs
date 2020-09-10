using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TakeScreenshotWindows : MonoBehaviour {


	public void TakeAShot()
	{
		StartCoroutine ("CaptureIt");
	}

	IEnumerator CaptureIt()
	{

        string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string fileName = "Screenshot" + timeStamp + ".png";
		string pathToSave = fileName;

        //Hide buttons from screenshot
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;
        yield return new WaitForEndOfFrame();

        //Take screenshot and show Windows the correct path
        ScreenCapture.CaptureScreenshot(Application.persistentDataPath + Path.DirectorySeparatorChar + "Muova AR Puzzle" + pathToSave);
        Debug.Log("ScreenCap Location: " + Application.persistentDataPath);
        
        //Bring buttons back after screenshot
        yield return new WaitForEndOfFrame();
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;
        
	}

}
