using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System;
using UnityEngine.EventSystems;

public class gameCtrl : MonoBehaviour
{
    public InputField inName;
    public InputField inAge;
    public InputField inTime;
    public Dropdown inGender;
    public Button butBegin;
    public GameObject splashScreen;
    public GameObject initInterface;
    public GameObject page3;
    public GameObject page4;
    public GameObject page5;
    public Toggle foodYes;
    public Toggle outdoorYes;
    public Toggle indoorYes;
    public Toggle socialYes;
    public Toggle foodNo;
    public Toggle outdoorNo;
    public Toggle indoorNo;
    public Toggle socialNo;

    public int timeLimit;
    public char gender;
    //public int age;

    public string path;
    private string pathDevice;

    // Start is called before the first frame update
    void Start()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        inTime.text = 15.ToString();

        #if UNITY_ANDROID
            pathDevice = Application.persistentDataPath;
        #endif
        #if UNITY_IOS
            pathDevice = Application.persistentDataPath;
        #endif
        #if UNITY_EDITOR	
            pathDevice = Application.streamingAssetsPath;
        #endif
        #if UNITY_STANDALONE		
            pathDevice = Application.streamingAssetsPath;
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        var go = EventSystem.current.currentSelectedGameObject;
        if (go.name == "ButtonSplash")
        {
            splashScreen.SetActive(false);
            initInterface.SetActive(true);
        }
        if (go.name == "ButtonBegin")
        {
            if (inName.text != "" && inAge.text != "" && inTime.text != "")
            {
                /*inName.enabled = false;
                inAge.enabled = false;
                inTime.enabled = false;
                inGender.enabled = false;*/
                
                //butInstructions.SetActive(true);
                page3.SetActive(true);
                initInterface.SetActive(false);

                //age = Convert.ToInt32(inAge.text);
                timeLimit = Convert.ToInt32(inTime.text);
                if (inGender.value == 0)
                    gender = 'F';
                else
                    gender = 'M';

                path = pathDevice + "/data_" + inName.text + ".csv";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, "ID,Age,Sex,Time Limit" + "\n");
                    File.AppendAllText(path, inName.text + "," + inAge.text + "," + gender + "," + inTime.text + "\n" + "\n" + "\n");
                }
            }
        }
        if (go.name == "ToggleFoodYes")
        {
            foodYes.isOn = true;
            foodNo.isOn = false;
        }
        if (go.name == "ToggleFoodNo")
        {
            foodYes.isOn = false;
            foodNo.isOn = true;
        }
        if (go.name == "ToggleOutdoorYes")
        {
            outdoorYes.isOn = true;
            outdoorNo.isOn = false;
        }
        if (go.name == "ToggleOutdoorNo")
        {
            outdoorYes.isOn = false;
            outdoorNo.isOn = true;
        }
        if (go.name == "ToggleIndoorYes")
        {
            indoorYes.isOn = true;
            indoorNo.isOn = false;
        }
        if (go.name == "ToggleIndoorNo")
        {
            indoorYes.isOn = false;
            indoorNo.isOn = true;
        }
        if (go.name == "ToggleSocialYes")
        {
            socialYes.isOn = true;
            socialNo.isOn = false;
        }
        if (go.name == "ToggleSocialNo")
        {
            socialYes.isOn = false;
            socialNo.isOn = true;
        }
        if (go.name == "ButtonContinue3")
        {
            File.AppendAllText(path, "Food,Outdoor,Indoor,Social" + "\n");
            if (foodYes.isOn)
            {
                File.AppendAllText(path, "Yes,");
            }
            else
            {
                File.AppendAllText(path, "No,");
            }
            if (outdoorYes.isOn)
            {
                File.AppendAllText(path, "Yes,");
            }
            else
            {
                File.AppendAllText(path, "No,");
            }
            if (indoorYes.isOn)
            {
                File.AppendAllText(path, "Yes,");
            }
            else
            {
                File.AppendAllText(path, "No,");
            }
            if (socialYes.isOn)
            {
                File.AppendAllText(path, "Yes" + "\n" + "\n" + "\n");
            }
            else
            {
                File.AppendAllText(path, "No" + "\n" + "\n" + "\n");
            }
//            File.AppendAllText(path, foodYes.isOn.ToString() + "," + outdoorYes.isOn.ToString() + "," + indoorYes.isOn.ToString() + "," + socialYes.isOn.ToString() + "\n" + "\n" + "\n");
            File.AppendAllText(path, "Category,Trial,Choice,Time,Selection Made" + "\n");
            page3.SetActive(false);
            page4.SetActive(true);
        }
        if (go.name == "ButtonContinue4")
        {
            page4.SetActive(false);
            page5.SetActive(true);
        }
    }
}
