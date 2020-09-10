using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class ColliderDetection : MonoBehaviour
{
    public CanvasGroup uiCanvasGroup;
    public CanvasGroup infoPanel;
    public Text headerName;
    public Text infoText;
    RawImage objectPicture = null;
    /*
    [SerializeField]
    Sprite defaultImage;
    string[] files = null;
    */


    private void Awake()
    {
        //disable the info panel
        InfoPanelClose();

        objectPicture = gameObject.GetComponent<RawImage>();


       /* files = Directory.GetFiles(Application.persistentDataPath + "/", headerName.text);
        if (files.Length > 0)
        {
            GetPictureAndShowIt();
        }
        */
    }

    void Update()
    {
        //check for user input
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Tap detected, casting ray");
            CastRay();
        }

    }

    //get the correct picture and show it
    /*
    public void GetPictureAndShowIt()
    {
        string pathToFile = files + headerName.text;
        Texture2D texture = GetScreenshotImage(pathToFile);
        Sprite sp = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height),
            new Vector2(0.5f, 0.5f));
        objectPicture.GetComponent<Image>().sprite = sp;
    }

    Texture2D GetScreenshotImage(string filePath)
    {
        Texture2D texture = null;
        byte[] fileBytes;
        if (File.Exists(filePath))
        {
            fileBytes = File.ReadAllBytes(filePath);
            texture = new Texture2D(2, 2, TextureFormat.RGB24, false);
            texture.LoadImage(fileBytes);
        }
        return texture;
    }
    */



    //cast a ray and check if it hits any object collider
    void CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);
            Debug.Log("Object hit: " + hit.collider.gameObject.name);
            Debug.Log("Distance: " + hit.distance);

            //set the info panel header as the hit objects name
            headerName.text = hit.collider.gameObject.name;


            // open the info panel
            infoPanel.alpha = 1;
            infoPanel.interactable = true;
            infoPanel.blocksRaycasts = true;


            //call a method to check which object was hit
            CheckClickedObject();
        }
    }


    //check which object was hit, and set the info panel accordingly
    private void CheckClickedObject()
    {
        if (headerName.text == "shelf")
        {
            infoText.text = "123123";
        }

        else if (headerName.text == "computercabinet")
        {
            infoText.text = "computer cabinet 123213";
        }
    }




    public void InfoPanelClose()
    {
        //disable the info panel ui
        infoPanel.alpha = 0;
        infoPanel.interactable = false;
        infoPanel.blocksRaycasts = false;

    }

}