using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System;
using UnityEngine.EventSystems;

public class gameProper : MonoBehaviour
{
    #region Gameobject Declartion
    public GameObject butPartC;
    public GameObject butPartF;
    public GameObject butPartO;
    public GameObject butPartI;
    public GameObject butPartL;

    public GameObject pageColor;
    public GameObject pageShape;
    public GameObject pageFood;
    public GameObject pageIndoor;
    public GameObject pageOutdoor;
    public GameObject pageSocial;
    public GameObject pageLast;
    public GameObject butPagePause;

    public GameObject butPause;
    public GameObject butContinue;
    public GameObject butExit;
    public GameObject txtExit;

    public GameObject butCircle;

    public GameObject butC11;
    public GameObject butC12;
    public GameObject butC21;
    public GameObject butC22;
    public GameObject butC31;
    public GameObject butC32;
    public GameObject butC33;
    public GameObject butC41;
    public GameObject butC42;
    public GameObject butC43;
    public GameObject butC51;
    public GameObject butC52;
    public GameObject butC53;
    public GameObject butC54;
    public GameObject butC61;
    public GameObject butC62;
    public GameObject butC63;
    public GameObject butC64;

    public GameObject butS11;
    public GameObject butS12;
    public GameObject butS21;
    public GameObject butS22;
    public GameObject butS31;
    public GameObject butS32;
    public GameObject butS33;
    public GameObject butS41;
    public GameObject butS42;
    public GameObject butS43;
    public GameObject butS51;
    public GameObject butS52;
    public GameObject butS53;
    public GameObject butS54;
    public GameObject butS61;
    public GameObject butS62;
    public GameObject butS63;
    public GameObject butS64;

    public GameObject butF11;
    public GameObject butF12;
    public GameObject butF21;
    public GameObject butF22;
    public GameObject butF31;
    public GameObject butF32;
    public GameObject butF33;
    public GameObject butF41;
    public GameObject butF42;
    public GameObject butF43;
    public GameObject butF51;
    public GameObject butF52;
    public GameObject butF53;
    public GameObject butF54;
    public GameObject butF61;
    public GameObject butF62;
    public GameObject butF63;
    public GameObject butF64;

    public GameObject butO11;
    public GameObject butO12;
    public GameObject butO21;
    public GameObject butO22;
    public GameObject butO31;
    public GameObject butO32;
    public GameObject butO33;
    public GameObject butO41;
    public GameObject butO42;
    public GameObject butO43;
    public GameObject butO51;
    public GameObject butO52;
    public GameObject butO53;
    public GameObject butO54;
    public GameObject butO61;
    public GameObject butO62;
    public GameObject butO63;
    public GameObject butO64;

    public GameObject butI11;
    public GameObject butI12;
    public GameObject butI21;
    public GameObject butI22;
    public GameObject butI31;
    public GameObject butI32;
    public GameObject butI33;
    public GameObject butI41;
    public GameObject butI42;
    public GameObject butI43;
    public GameObject butI51;
    public GameObject butI52;
    public GameObject butI53;
    public GameObject butI54;
    public GameObject butI61;
    public GameObject butI62;
    public GameObject butI63;
    public GameObject butI64;

    public GameObject butL11;
    public GameObject butL12;
    public GameObject butL21;
    public GameObject butL22;
    public GameObject butL31;
    public GameObject butL32;
    public GameObject butL33;
    public GameObject butL41;
    public GameObject butL42;
    public GameObject butL43;
    public GameObject butL51;
    public GameObject butL52;
    public GameObject butL53;
    public GameObject butL54;
    public GameObject butL61;
    public GameObject butL62;
    public GameObject butL63;
    public GameObject butL64;
    #endregion

    public int counter;
    private int section;

    public bool trialOngoing = false;
    public float curTime = 0;
    public float timeLimit = 15;
    private float pauseTime;
    private bool gamePaused = false;

    public string writePath;
    public gameCtrl fileInfo;

    public bool pressGreen;
    private const float timeDelay = 2f;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        section = 1;
        curTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gamePaused)
        {
            curTime = 0;
        }

        if ((counter % 2 == 1) || counter == 0)
        {
            trialOngoing = false;
        }

        curTime += Time.deltaTime;
        //Debug.Log(curTime.ToString());

        #region added delay
        if (pressGreen)
        {
            //color
            if (curTime > timeDelay && counter == 2 && section == 1)
            {
                butC11.SetActive(true);
                butC12.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 4 && section == 1)
            {
                butC21.SetActive(true);
                butC22.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 6 && section == 1)
            {
                butC31.SetActive(true);
                butC32.SetActive(true);
                butC33.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 8 && section == 1)
            {
                butC41.SetActive(true);
                butC42.SetActive(true);
                butC43.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 10 && section == 1)
            {
                butC51.SetActive(true);
                butC52.SetActive(true);
                butC53.SetActive(true);
                butC54.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 12 && section == 1)
            {
                butC61.SetActive(true);
                butC62.SetActive(true);
                butC63.SetActive(true);
                butC64.SetActive(true);
                pressGreen = false;
            }
            //shape
            if (curTime > timeDelay && counter == 2 && section == 6)
            {
                butS11.SetActive(true);
                butS12.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 4 && section == 6)
            {
                butS21.SetActive(true);
                butS22.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 6 && section == 6)
            {
                butS31.SetActive(true);
                butS32.SetActive(true);
                butS33.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 8 && section == 6)
            {
                butS41.SetActive(true);
                butS42.SetActive(true);
                butS43.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 10 && section == 6)
            {
                butS51.SetActive(true);
                butS52.SetActive(true);
                butS53.SetActive(true);
                butS54.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 12 && section == 6)
            {
                butS61.SetActive(true);
                butS62.SetActive(true);
                butS63.SetActive(true);
                butS64.SetActive(true);
                pressGreen = false;
            }
            //food
            if (curTime > timeDelay && counter == 2 && section == 2)
            {
                butF11.SetActive(true);
                butF12.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 4 && section == 2)
            {
                butF21.SetActive(true);
                butF22.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 6 && section == 2)
            {
                butF31.SetActive(true);
                butF32.SetActive(true);
                butF33.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 8 && section == 2)
            {
                butF41.SetActive(true);
                butF42.SetActive(true);
                butF43.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 10 && section == 2)
            {
                butF51.SetActive(true);
                butF52.SetActive(true);
                butF53.SetActive(true);
                butF54.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 12 && section == 2)
            {
                butF61.SetActive(true);
                butF62.SetActive(true);
                butF63.SetActive(true);
                butF64.SetActive(true);
                pressGreen = false;
            }
            //outdoor
            if (curTime > timeDelay && counter == 2 && section == 3)
            {
                butO11.SetActive(true);
                butO12.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 4 && section == 3)
            {
                butO21.SetActive(true);
                butO22.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 6 && section == 3)
            {
                butO31.SetActive(true);
                butO32.SetActive(true);
                butO33.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 8 && section == 3)
            {
                butO41.SetActive(true);
                butO42.SetActive(true);
                butO43.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 10 && section == 3)
            {
                butO51.SetActive(true);
                butO52.SetActive(true);
                butO53.SetActive(true);
                butO54.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 12 && section == 3)
            {
                butO61.SetActive(true);
                butO62.SetActive(true);
                butO63.SetActive(true);
                butO64.SetActive(true);
                pressGreen = false;
            }
            //indoor
            if (curTime > timeDelay && counter == 2 && section == 4)
            {
                butI11.SetActive(true);
                butI12.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 4 && section == 4)
            {
                butI21.SetActive(true);
                butI22.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 6 && section == 4)
            {
                butI31.SetActive(true);
                butI32.SetActive(true);
                butI33.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 8 && section == 4)
            {
                butI41.SetActive(true);
                butI42.SetActive(true);
                butI43.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 10 && section == 4)
            {
                butI51.SetActive(true);
                butI52.SetActive(true);
                butI53.SetActive(true);
                butI54.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 12 && section == 4)
            {
                butI61.SetActive(true);
                butI62.SetActive(true);
                butI63.SetActive(true);
                butI64.SetActive(true);
                pressGreen = false;
            }
            //Social
            if (curTime > timeDelay && counter == 2 && section == 5)
            {
                butL11.SetActive(true);
                butL12.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 4 && section == 5)
            {
                butL21.SetActive(true);
                butL22.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 6 && section == 5)
            {
                butL31.SetActive(true);
                butL32.SetActive(true);
                butL33.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 8 && section == 5)
            {
                butL41.SetActive(true);
                butL42.SetActive(true);
                butL43.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 10 && section == 5)
            {
                butL51.SetActive(true);
                butL52.SetActive(true);
                butL53.SetActive(true);
                butL54.SetActive(true);
                pressGreen = false;
            }
            if (curTime > timeDelay && counter == 12 && section == 5)
            {
                butL61.SetActive(true);
                butL62.SetActive(true);
                butL63.SetActive(true);
                butL64.SetActive(true);
                pressGreen = false;
            }
        }
        #endregion

        #region limit cross
        if (curTime>timeLimit)
        {
            if(butC11.activeInHierarchy)
            {
                butC11.SetActive(false);
                butC12.SetActive(false);
                butCircle.SetActive(true);
                counter = 3;
                File.AppendAllText(writePath, "Color,1,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butC21.activeInHierarchy)
            {
                butC21.SetActive(false);
                butC22.SetActive(false);
                butCircle.SetActive(true);
                counter = 5;
                File.AppendAllText(writePath, "Color,2,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butC31.activeInHierarchy)
            {
                butC31.SetActive(false);
                butC32.SetActive(false);
                butC33.SetActive(false);
                butCircle.SetActive(true);
                counter = 7;
                File.AppendAllText(writePath, "Color,3,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butC41.activeInHierarchy)
            {
                butC41.SetActive(false);
                butC42.SetActive(false);
                butC43.SetActive(false);
                butCircle.SetActive(true);
                counter = 9;
                File.AppendAllText(writePath, "Color,4,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butC51.activeInHierarchy)
            {
                butC51.SetActive(false);
                butC52.SetActive(false);
                butC53.SetActive(false);
                butC54.SetActive(false);
                butCircle.SetActive(true);
                counter = 11;
                File.AppendAllText(writePath, "Color,5,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butC61.activeInHierarchy)
            {
                butC61.SetActive(false);
                butC62.SetActive(false);
                butC63.SetActive(false);
                butC64.SetActive(false);
                butCircle.SetActive(false);
                //butPause.SetActive(false);
                pageShape.SetActive(true);
                counter = 0;
                section = 6;
                File.AppendAllText(writePath, "Color,6,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }

            if (butS11.activeInHierarchy)
            {
                butS11.SetActive(false);
                butS12.SetActive(false);
                butCircle.SetActive(true);
                counter = 3;
                File.AppendAllText(writePath, "Shape,1,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butS21.activeInHierarchy)
            {
                butS21.SetActive(false);
                butS22.SetActive(false);
                butCircle.SetActive(true);
                counter = 5;
                File.AppendAllText(writePath, "Shape,2,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butS31.activeInHierarchy)
            {
                butS31.SetActive(false);
                butS32.SetActive(false);
                butS33.SetActive(false);
                butCircle.SetActive(true);
                counter = 7;
                File.AppendAllText(writePath, "Shape,3,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butS41.activeInHierarchy)
            {
                butS41.SetActive(false);
                butS42.SetActive(false);
                butS43.SetActive(false);
                butCircle.SetActive(true);
                counter = 9;
                File.AppendAllText(writePath, "Shape,4,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butS51.activeInHierarchy)
            {
                butS51.SetActive(false);
                butS52.SetActive(false);
                butS53.SetActive(false);
                butS54.SetActive(false);
                butCircle.SetActive(true);
                counter = 11;
                File.AppendAllText(writePath, "Shape,5,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butS61.activeInHierarchy)
            {
                butS61.SetActive(false);
                butS62.SetActive(false);
                butS63.SetActive(false);
                butS64.SetActive(false);
                butCircle.SetActive(false);
                //butPause.SetActive(false);
                pageFood.SetActive(true);
                counter = 0;
                section = 2;
                File.AppendAllText(writePath, "Shape,6,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }

            if (butF11.activeInHierarchy)
            {
                butF11.SetActive(false);
                butF12.SetActive(false);
                butCircle.SetActive(true);
                counter = 3;
                File.AppendAllText(writePath, "Food,1,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butF21.activeInHierarchy)
            {
                butF21.SetActive(false);
                butF22.SetActive(false);
                butCircle.SetActive(true);
                counter = 5;
                File.AppendAllText(writePath, "Food,2,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butF31.activeInHierarchy)
            {
                butF31.SetActive(false);
                butF32.SetActive(false);
                butF33.SetActive(false);
                butCircle.SetActive(true);
                counter = 7;
                File.AppendAllText(writePath, "Food,3,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butF41.activeInHierarchy)
            {
                butF41.SetActive(false);
                butF42.SetActive(false);
                butF43.SetActive(false);
                butCircle.SetActive(true);
                counter = 9;
                File.AppendAllText(writePath, "Food,4,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butF51.activeInHierarchy)
            {
                butF51.SetActive(false);
                butF52.SetActive(false);
                butF53.SetActive(false);
                butF54.SetActive(false);
                butCircle.SetActive(true);
                counter = 11;
                File.AppendAllText(writePath, "Food,5,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butF61.activeInHierarchy)
            {
                butF61.SetActive(false);
                butF62.SetActive(false);
                butF63.SetActive(false);
                butF64.SetActive(false);
                butCircle.SetActive(false);
                //butPause.SetActive(false);
                pageIndoor.SetActive(true);
                counter = 0;
                section = 4;
                File.AppendAllText(writePath, "Food,6,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }

            if (butO11.activeInHierarchy)
            {
                butO11.SetActive(false);
                butO12.SetActive(false);
                butCircle.SetActive(true);
                counter = 3;
                File.AppendAllText(writePath, "Outdoor,1,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butO21.activeInHierarchy)
            {
                butO21.SetActive(false);
                butO22.SetActive(false);
                butCircle.SetActive(true);
                counter = 5;
                File.AppendAllText(writePath, "Outdoor,2,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butO31.activeInHierarchy)
            {
                butO31.SetActive(false);
                butO32.SetActive(false);
                butO33.SetActive(false);
                butCircle.SetActive(true);
                counter = 7;
                File.AppendAllText(writePath, "Outdoor,3,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butO41.activeInHierarchy)
            {
                butO41.SetActive(false);
                butO42.SetActive(false);
                butO43.SetActive(false);
                butCircle.SetActive(true);
                counter = 9;
                File.AppendAllText(writePath, "Outdoor,4,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butO51.activeInHierarchy)
            {
                butO51.SetActive(false);
                butO52.SetActive(false);
                butO53.SetActive(false);
                butO54.SetActive(false);
                butCircle.SetActive(true);
                counter = 11;
                File.AppendAllText(writePath, "Outdoor,5,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butO61.activeInHierarchy)
            {
                butO61.SetActive(false);
                butO62.SetActive(false);
                butO63.SetActive(false);
                butO64.SetActive(false);
                butCircle.SetActive(false);
                //butPause.SetActive(false);
                pageSocial.SetActive(true);
                counter = 0;
                section = 5;
                File.AppendAllText(writePath, "Outdoor,6,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }

            if (butI11.activeInHierarchy)
            {
                butI11.SetActive(false);
                butI12.SetActive(false);
                butCircle.SetActive(true);
                counter = 3;
                File.AppendAllText(writePath, "Indoor,1,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butI21.activeInHierarchy)
            {
                butI21.SetActive(false);
                butI22.SetActive(false);
                butCircle.SetActive(true);
                counter = 5;
                File.AppendAllText(writePath, "Indoor,2,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butI31.activeInHierarchy)
            {
                butI31.SetActive(false);
                butI32.SetActive(false);
                butI33.SetActive(false);
                butCircle.SetActive(true);
                counter = 7;
                File.AppendAllText(writePath, "Indoor,3,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butI41.activeInHierarchy)
            {
                butI41.SetActive(false);
                butI42.SetActive(false);
                butI43.SetActive(false);
                butCircle.SetActive(true);
                counter = 9;
                File.AppendAllText(writePath, "Indoor,4,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butI51.activeInHierarchy)
            {
                butI51.SetActive(false);
                butI52.SetActive(false);
                butI53.SetActive(false);
                butI54.SetActive(false);
                butCircle.SetActive(true);
                counter = 11;
                File.AppendAllText(writePath, "Indoor,5,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butI61.activeInHierarchy)
            {
                butI61.SetActive(false);
                butI62.SetActive(false);
                butI63.SetActive(false);
                butI64.SetActive(false);
                butCircle.SetActive(false);
                //butPause.SetActive(false);
                pageOutdoor.SetActive(true);
                counter = 0;
                section = 3;
                File.AppendAllText(writePath, "Indoor,6,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }

            if (butL11.activeInHierarchy)
            {
                butL11.SetActive(false);
                butL12.SetActive(false);
                butCircle.SetActive(true);
                counter = 3;
                File.AppendAllText(writePath, "Social,1,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butL21.activeInHierarchy)
            {
                butL21.SetActive(false);
                butL22.SetActive(false);
                butCircle.SetActive(true);
                counter = 5;
                File.AppendAllText(writePath, "Social,2,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butL31.activeInHierarchy)
            {
                butL31.SetActive(false);
                butL32.SetActive(false);
                butL33.SetActive(false);
                butCircle.SetActive(true);
                counter = 7;
                File.AppendAllText(writePath, "Social,3,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butL41.activeInHierarchy)
            {
                butL41.SetActive(false);
                butL42.SetActive(false);
                butL43.SetActive(false);
                butCircle.SetActive(true);
                counter = 9;
                File.AppendAllText(writePath, "Social,4,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butL51.activeInHierarchy)
            {
                butL51.SetActive(false);
                butL52.SetActive(false);
                butL53.SetActive(false);
                butL54.SetActive(false);
                butCircle.SetActive(true);
                counter = 11;
                File.AppendAllText(writePath, "Social,5,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butL61.activeInHierarchy)
            {
                butL61.SetActive(false);
                butL62.SetActive(false);
                butL63.SetActive(false);
                butL64.SetActive(false);
                butCircle.SetActive(false);
                //butPause.SetActive(false);
                pageLast.SetActive(true);
                counter = 0;
                section = 7;
                File.AppendAllText(writePath, "Social,6,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
        }
        #endregion

    }

    public void OnMouseDown()
    {
        var go = EventSystem.current.currentSelectedGameObject;

        #region Color
        if (section == 1 && go.name == "ButtonContinueColor" && counter==0)
        {
            curTime = 0;
            pageColor.SetActive(false);
            butCircle.SetActive(true);
            //butPause.SetActive(true);
            counter = 1;
            writePath = fileInfo.GetComponent<gameCtrl>().path;
            timeLimit = fileInfo.GetComponent<gameCtrl>().timeLimit+timeDelay;
        }
        if (section == 1 && go.name == "IntCircle" && counter == 1)
        {
            pressGreen = true;
            counter = 2;
        }
        if (section == 1 && go.name == "ImgC11" && counter == 2)
        {
            butC11.SetActive(false);
            butC12.SetActive(false);
            counter = 3;
            File.AppendAllText(writePath, "Color,1,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");

        }
        if (section == 1 && go.name == "ImgC12" && counter == 2)
        {
            butC11.SetActive(false);
            butC12.SetActive(false);
            counter = 3;
            File.AppendAllText(writePath, "Color,1,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "IntCircle" && counter == 3)
        {
            pressGreen = true;
            counter = 4;
        }
        if (section == 1 && go.name == "ImgC21" && counter == 4)
        {
            butC21.SetActive(false);
            butC22.SetActive(false);
            counter = 5;
            File.AppendAllText(writePath, "Color,2,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "ImgC22" && counter == 4)
        {
            butC21.SetActive(false);
            butC22.SetActive(false);
            counter = 5;
            File.AppendAllText(writePath, "Color,2,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "IntCircle" && counter == 5)
        {
            pressGreen = true;
            counter = 6;
        }
        if (section == 1 && go.name == "ImgC31" && counter == 6)
        {
            butC31.SetActive(false);
            butC32.SetActive(false);
            butC33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Color,3,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "ImgC32" && counter == 6)
        {
            butC31.SetActive(false);
            butC32.SetActive(false);
            butC33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Color,3,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "ImgC33" && counter == 6)
        {
            butC31.SetActive(false);
            butC32.SetActive(false);
            butC33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Color,3,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "IntCircle" && counter == 7)
        {
            pressGreen = true;
            counter = 8;
        }
        if (section == 1 && go.name == "ImgC41" && counter == 8)
        {
            butC41.SetActive(false);
            butC42.SetActive(false);
            butC43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Color,4,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "ImgC42" && counter == 8)
        {
            butC41.SetActive(false);
            butC42.SetActive(false);
            butC43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Color,4,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "ImgC43" && counter == 8)
        {
            butC41.SetActive(false);
            butC42.SetActive(false);
            butC43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Color,4,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "IntCircle" && counter == 9)
        {
            pressGreen = true;
            counter = 10;
        }
        if (section == 1 && go.name == "ImgC51" && counter == 10)
        {
            butC51.SetActive(false);
            butC52.SetActive(false);
            butC53.SetActive(false);
            butC54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Color,5,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "ImgC52" && counter == 10)
        {
            butC51.SetActive(false);
            butC52.SetActive(false);
            butC53.SetActive(false);
            butC54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Color,5,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "ImgC53" && counter == 10)
        {
            butC51.SetActive(false);
            butC52.SetActive(false);
            butC53.SetActive(false);
            butC54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Color,5,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "ImgC54" && counter == 10)
        {
            butC51.SetActive(false);
            butC52.SetActive(false);
            butC53.SetActive(false);
            butC54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Color,5,4," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "IntCircle" && counter == 11)
        {
            pressGreen = true;
            counter = 12;
        }
        if (section == 1 && go.name == "ImgC61" && counter == 12)
        {
            butC61.SetActive(false);
            butC62.SetActive(false);
            butC63.SetActive(false);
            butC64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageShape.SetActive(true);
            counter = 0;
            section = 6;
            File.AppendAllText(writePath, "Color,6,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "ImgC62" && counter == 12)
        {
            butC61.SetActive(false);
            butC62.SetActive(false);
            butC63.SetActive(false);
            butC64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageShape.SetActive(true);
            counter = 0;
            section = 6;
            File.AppendAllText(writePath, "Color,6,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "ImgC63" && counter == 12)
        {
            butC61.SetActive(false);
            butC62.SetActive(false);
            butC63.SetActive(false);
            butC64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageShape.SetActive(true);
            counter = 0;
            section = 6;
            File.AppendAllText(writePath, "Color,6,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 1 && go.name == "ImgC64" && counter == 12)
        {
            butC61.SetActive(false);
            butC62.SetActive(false);
            butC63.SetActive(false);
            butC64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageShape.SetActive(true);
            counter = 0;
            section = 6;
            File.AppendAllText(writePath, "Color,6,4," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        #endregion

        #region Shape
        if (section == 6 && go.name == "ButtonContinueShape" && counter == 0)
        {
            curTime = 0;
            pageShape.SetActive(false);
            butCircle.SetActive(true);
            //butPause.SetActive(true);
            counter = 1;
        }
        if (section == 6 && go.name == "IntCircle" && counter == 1)
        {
            pressGreen = true;
            counter = 2;
        }
        if (section == 6 && go.name == "ImgS11" && counter == 2)
        {
            butS11.SetActive(false);
            butS12.SetActive(false);
            counter = 3;
            File.AppendAllText(writePath, "Shape,1,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");

        }
        if (section == 6 && go.name == "ImgS12" && counter == 2)
        {
            butS11.SetActive(false);
            butS12.SetActive(false);
            counter = 3;
            File.AppendAllText(writePath, "Shape,1,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "IntCircle" && counter == 3)
        {
            pressGreen = true;
            counter = 4;
        }
        if (section == 6 && go.name == "ImgS21" && counter == 4)
        {
            butS21.SetActive(false);
            butS22.SetActive(false);
            counter = 5;
            File.AppendAllText(writePath, "Shape,2,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "ImgS22" && counter == 4)
        {
            butS21.SetActive(false);
            butS22.SetActive(false);
            counter = 5;
            File.AppendAllText(writePath, "Shape,2,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "IntCircle" && counter == 5)
        {
            pressGreen = true;
            counter = 6;
        }
        if (section == 6 && go.name == "ImgS31" && counter == 6)
        {
            butS31.SetActive(false);
            butS32.SetActive(false);
            butS33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Shape,3,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "ImgS32" && counter == 6)
        {
            butS31.SetActive(false);
            butS32.SetActive(false);
            butS33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Shape,3,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "ImgS33" && counter == 6)
        {
            butS31.SetActive(false);
            butS32.SetActive(false);
            butS33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Shape,3,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "IntCircle" && counter == 7)
        {
            pressGreen = true;
            counter = 8;
        }
        if (section == 6 && go.name == "ImgS41" && counter == 8)
        {
            butS41.SetActive(false);
            butS42.SetActive(false);
            butS43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Shape,4,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "ImgS42" && counter == 8)
        {
            butS41.SetActive(false);
            butS42.SetActive(false);
            butS43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Shape,4,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "ImgS43" && counter == 8)
        {
            butS41.SetActive(false);
            butS42.SetActive(false);
            butS43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Shape,4,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "IntCircle" && counter == 9)
        {
            pressGreen = true;
            counter = 10;
        }
        if (section == 6 && go.name == "ImgS51" && counter == 10)
        {
            butS51.SetActive(false);
            butS52.SetActive(false);
            butS53.SetActive(false);
            butS54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Shape,5,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "ImgS52" && counter == 10)
        {
            butS51.SetActive(false);
            butS52.SetActive(false);
            butS53.SetActive(false);
            butS54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Shape,5,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "ImgS53" && counter == 10)
        {
            butS51.SetActive(false);
            butS52.SetActive(false);
            butS53.SetActive(false);
            butS54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Shape,5,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "ImgS54" && counter == 10)
        {
            butS51.SetActive(false);
            butS52.SetActive(false);
            butS53.SetActive(false);
            butS54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Shape,5,4," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "IntCircle" && counter == 11)
        {
            pressGreen = true;
            counter = 12;
        }
        if (section == 6 && go.name == "ImgS61" && counter == 12)
        {
            butS61.SetActive(false);
            butS62.SetActive(false);
            butS63.SetActive(false);
            butS64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageFood.SetActive(true);
            counter = 0;
            section = 2;
            File.AppendAllText(writePath, "Shape,6,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "ImgS62" && counter == 12)
        {
            butS61.SetActive(false);
            butS62.SetActive(false);
            butS63.SetActive(false);
            butS64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageFood.SetActive(true);
            counter = 0;
            section = 2;
            File.AppendAllText(writePath, "Shape,6,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "ImgS63" && counter == 12)
        {
            butS61.SetActive(false);
            butS62.SetActive(false);
            butS63.SetActive(false);
            butS64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageFood.SetActive(true);
            counter = 0;
            section = 2;
            File.AppendAllText(writePath, "Shape,6,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 6 && go.name == "ImgS64" && counter == 12)
        {
            butS61.SetActive(false);
            butS62.SetActive(false);
            butS63.SetActive(false);
            butS64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageFood.SetActive(true);
            counter = 0;
            section = 2;
            File.AppendAllText(writePath, "Shape,6,4," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        #endregion

        #region Food
        if (section==2 && go.name == "ButtonContinueFood" && counter == 0)
        {
            curTime = 0;
            pageFood.SetActive(false);
            butCircle.SetActive(true);
            //butPause.SetActive(true);
            counter = 1;
        }
        if (section == 2 && go.name == "IntCircle" && counter == 1)
        {
            pressGreen = true;
            counter = 2;
        }
        if (section == 2 && go.name == "ImgF11" && counter == 2)
        {
            butF11.SetActive(false);
            butF12.SetActive(false);
            counter = 3;
            File.AppendAllText(writePath, "Food,1,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "ImgF12" && counter == 2)
        {
            butF11.SetActive(false);
            butF12.SetActive(false);
            counter = 3;
            File.AppendAllText(writePath, "Food,1,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "IntCircle" && counter == 3)
        {
            pressGreen = true;
            counter = 4;
        }
        if (section == 2 && go.name == "ImgF21" && counter == 4)
        {
            butF21.SetActive(false);
            butF22.SetActive(false);
            counter = 5;
            File.AppendAllText(writePath, "Food,2,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "ImgF22" && counter == 4)
        {
            butF21.SetActive(false);
            butF22.SetActive(false);
            counter = 5;
            File.AppendAllText(writePath, "Food,2,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "IntCircle" && counter == 5)
        {
            pressGreen = true;
            counter = 6;
        }
        if (section == 2 && go.name == "ImgF31" && counter == 6)
        {
            butF31.SetActive(false);
            butF32.SetActive(false);
            butF33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Food,3,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "ImgF32" && counter == 6)
        {
            butF31.SetActive(false);
            butF32.SetActive(false);
            butF33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Food,3,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "ImgF33" && counter == 6)
        {
            butF31.SetActive(false);
            butF32.SetActive(false);
            butF33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Food,3,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "IntCircle" && counter == 7)
        {
            pressGreen = true;
            counter = 8;
        }
        if (section == 2 && go.name == "ImgF41" && counter == 8)
        {
            butF41.SetActive(false);
            butF42.SetActive(false);
            butF43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Food,4,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "ImgF42" && counter == 8)
        {
            butF41.SetActive(false);
            butF42.SetActive(false);
            butF43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Food,4,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "ImgF43" && counter == 8)
        {
            butF41.SetActive(false);
            butF42.SetActive(false);
            butF43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Food,4,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "IntCircle" && counter == 9)
        {
            pressGreen = true;
            counter = 10;
        }
        if (section == 2 && go.name == "ImgF51" && counter == 10)
        {
            butF51.SetActive(false);
            butF52.SetActive(false);
            butF53.SetActive(false);
            butF54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Food,5,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "ImgF52" && counter == 10)
        {
            butF51.SetActive(false);
            butF52.SetActive(false);
            butF53.SetActive(false);
            butF54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Food,5,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "ImgF53" && counter == 10)
        {
            butF51.SetActive(false);
            butF52.SetActive(false);
            butF53.SetActive(false);
            butF54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Food,5,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "ImgF54" && counter == 10)
        {
            butF51.SetActive(false);
            butF52.SetActive(false);
            butF53.SetActive(false);
            butF54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Food,5,4," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "IntCircle" && counter == 11)
        {
            pressGreen = true;
            counter = 12;
        }
        if (section == 2 && go.name == "ImgF61" && counter == 12)
        {
            butF61.SetActive(false);
            butF62.SetActive(false);
            butF63.SetActive(false);
            butF64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageIndoor.SetActive(true);
            counter = 0;
            section = 4;
            File.AppendAllText(writePath, "Food,6,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "ImgF62" && counter == 12)
        {
            butF61.SetActive(false);
            butF62.SetActive(false);
            butF63.SetActive(false);
            butF64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageIndoor.SetActive(true);
            counter = 0;
            section = 4;
            File.AppendAllText(writePath, "Food,6,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "ImgF63" && counter == 12)
        {
            butF61.SetActive(false);
            butF62.SetActive(false);
            butF63.SetActive(false);
            butF64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageIndoor.SetActive(true);
            counter = 0;
            section = 4;
            File.AppendAllText(writePath, "Food,6,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 2 && go.name == "ImgF64" && counter == 12)
        {
            butF61.SetActive(false);
            butF62.SetActive(false);
            butF63.SetActive(false);
            butF64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageIndoor.SetActive(true);
            counter = 0;
            section = 4;
            File.AppendAllText(writePath, "Food,6,4," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        #endregion

        #region Outdoor
        if (section == 3 && go.name == "ButtonContinueOutdoor" && counter == 0)
        {
            curTime = 0;
            pageOutdoor.SetActive(false);
            butCircle.SetActive(true);
            //butPause.SetActive(true);
            counter = 1;
        }
        if (section == 3 && go.name == "IntCircle" && counter == 1)
        {
            counter = 2;
            pressGreen = true;
        }
        if (section == 3 && go.name == "ImgO11" && counter == 2)
        {
            butO11.SetActive(false);
            butO12.SetActive(false);
            counter = 3;
            File.AppendAllText(writePath, "Outdoor,1,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "ImgO12" && counter == 2)
        {
            butO11.SetActive(false);
            butO12.SetActive(false);
            counter = 3;
            File.AppendAllText(writePath, "Outdoor,1,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "IntCircle" && counter == 3)
        {
            pressGreen = true;
            counter = 4;
        }
        if (section == 3 && go.name == "ImgO21" && counter == 4)
        {
            butO21.SetActive(false);
            butO22.SetActive(false);
            counter = 5;
            File.AppendAllText(writePath, "Outdoor,2,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "ImgO22" && counter == 4)
        {
            butO21.SetActive(false);
            butO22.SetActive(false);
            counter = 5;
            File.AppendAllText(writePath, "Outdoor,2,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "IntCircle" && counter == 5)
        {
            pressGreen = true;
            counter = 6;
        }
        if (section == 3 && go.name == "ImgO31" && counter == 6)
        {
            butO31.SetActive(false);
            butO32.SetActive(false);
            butO33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Outdoor,3,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "ImgO32" && counter == 6)
        {
            butO31.SetActive(false);
            butO32.SetActive(false);
            butO33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Outdoor,3,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "ImgO33" && counter == 6)
        {
            butO31.SetActive(false);
            butO32.SetActive(false);
            butO33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Outdoor,3,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "IntCircle" && counter == 7)
        {
            pressGreen = true;
            counter = 8;
        }
        if (section == 3 && go.name == "ImgO41" && counter == 8)
        {
            butO41.SetActive(false);
            butO42.SetActive(false);
            butO43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Outdoor,4,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "ImgO42" && counter == 8)
        {
            butO41.SetActive(false);
            butO42.SetActive(false);
            butO43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Outdoor,4,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "ImgO43" && counter == 8)
        {
            butO41.SetActive(false);
            butO42.SetActive(false);
            butO43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Outdoor,4,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "IntCircle" && counter == 9)
        {
            pressGreen = true;
            counter = 10;
        }
        if (section == 3 && go.name == "ImgO51" && counter == 10)
        {
            butO51.SetActive(false);
            butO52.SetActive(false);
            butO53.SetActive(false);
            butO54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Outdoor,5,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "ImgO52" && counter == 10)
        {
            butO51.SetActive(false);
            butO52.SetActive(false);
            butO53.SetActive(false);
            butO54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Outdoor,5,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "ImgO53" && counter == 10)
        {
            butO51.SetActive(false);
            butO52.SetActive(false);
            butO53.SetActive(false);
            butO54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Outdoor,5,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "ImgO54" && counter == 10)
        {
            butO51.SetActive(false);
            butO52.SetActive(false);
            butO53.SetActive(false);
            butO54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Outdoor,5,4," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "IntCircle" && counter == 11)
        {
            pressGreen = true;
            counter = 12;
        }
        if (section == 3 && go.name == "ImgO61" && counter == 12)
        {
            butO61.SetActive(false);
            butO62.SetActive(false);
            butO63.SetActive(false);
            butO64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageSocial.SetActive(true);
            counter = 0;
            section = 5;
            File.AppendAllText(writePath, "Outdoor,6,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "ImgO62" && counter == 12)
        {
            butO61.SetActive(false);
            butO62.SetActive(false);
            butO63.SetActive(false);
            butO64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageSocial.SetActive(true);
            counter = 0;
            section = 5;
            File.AppendAllText(writePath, "Outdoor,6,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "ImgO63" && counter == 12)
        {
            butO61.SetActive(false);
            butO62.SetActive(false);
            butO63.SetActive(false);
            butO64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageSocial.SetActive(true);
            counter = 0;
            section = 5;
            File.AppendAllText(writePath, "Outdoor,6,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 3 && go.name == "ImgO64" && counter == 12)
        {
            butO61.SetActive(false);
            butO62.SetActive(false);
            butO63.SetActive(false);
            butO64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageSocial.SetActive(true);
            counter = 0;
            section = 5;
            File.AppendAllText(writePath, "Outdoor,6,4," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        #endregion

        #region Indoor
        if (section == 4 && go.name == "ButtonContinueIndoor" && counter == 0)
        {
            curTime = 0;
            pageIndoor.SetActive(false);
            butCircle.SetActive(true);
            //butPause.SetActive(true);
            counter = 1;
        }
        if (section == 4 && go.name == "IntCircle" && counter == 1)
        {
            pressGreen = true;
            counter = 2;
        }
        if (section == 4 && go.name == "ImgI11" && counter == 2)
        {
            butI11.SetActive(false);
            butI12.SetActive(false);
            counter = 3;
            File.AppendAllText(writePath, "Indoor,1,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "ImgI12" && counter == 2)
        {
            butI11.SetActive(false);
            butI12.SetActive(false);
            counter = 3;
            File.AppendAllText(writePath, "Indoor,1,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "IntCircle" && counter == 3)
        {
            pressGreen = true;
            counter = 4;
        }
        if (section == 4 && go.name == "ImgI21" && counter == 4)
        {
            butI21.SetActive(false);
            butI22.SetActive(false);
            counter = 5;
            File.AppendAllText(writePath, "Indoor,2,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "ImgI22" && counter == 4)
        {
            butI21.SetActive(false);
            butI22.SetActive(false);
            counter = 5;
            File.AppendAllText(writePath, "Indoor,2,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "IntCircle" && counter == 5)
        {
            pressGreen = true;
            counter = 6;
        }
        if (section == 4 && go.name == "ImgI31" && counter == 6)
        {
            butI31.SetActive(false);
            butI32.SetActive(false);
            butI33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Indoor,3,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "ImgI32" && counter == 6)
        {
            butI31.SetActive(false);
            butI32.SetActive(false);
            butI33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Indoor,3,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "ImgI33" && counter == 6)
        {
            butI31.SetActive(false);
            butI32.SetActive(false);
            butI33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Indoor,3,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "IntCircle" && counter == 7)
        {
            pressGreen = true;
            counter = 8;
        }
        if (section == 4 && go.name == "ImgI41" && counter == 8)
        {
            butI41.SetActive(false);
            butI42.SetActive(false);
            butI43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Indoor,4,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "ImgI42" && counter == 8)
        {
            butI41.SetActive(false);
            butI42.SetActive(false);
            butI43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Indoor,4,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "ImgI43" && counter == 8)
        {
            butI41.SetActive(false);
            butI42.SetActive(false);
            butI43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Indoor,4,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "IntCircle" && counter == 9)
        {
            pressGreen = true;
            counter = 10;
        }
        if (section == 4 && go.name == "ImgI51" && counter == 10)
        {
            butI51.SetActive(false);
            butI52.SetActive(false);
            butI53.SetActive(false);
            butI54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Indoor,5,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "ImgI52" && counter == 10)
        {
            butI51.SetActive(false);
            butI52.SetActive(false);
            butI53.SetActive(false);
            butI54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Indoor,5,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "ImgI53" && counter == 10)
        {
            butI51.SetActive(false);
            butI52.SetActive(false);
            butI53.SetActive(false);
            butI54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Indoor,5,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "ImgI54" && counter == 10)
        {
            butI51.SetActive(false);
            butI52.SetActive(false);
            butI53.SetActive(false);
            butI54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Indoor,5,4," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "IntCircle" && counter == 11)
        {
            pressGreen = true;
            counter = 12;
        }
        if (section == 4 && go.name == "ImgI61" && counter == 12)
        {
            butI61.SetActive(false);
            butI62.SetActive(false);
            butI63.SetActive(false);
            butI64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageOutdoor.SetActive(true);
            counter = 0;
            section = 3;
            File.AppendAllText(writePath, "Indoor,6,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "ImgI62" && counter == 12)
        {
            butI61.SetActive(false);
            butI62.SetActive(false);
            butI63.SetActive(false);
            butI64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageOutdoor.SetActive(true);
            counter = 0;
            section = 3;
            File.AppendAllText(writePath, "Indoor,6,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "ImgI63" && counter == 12)
        {
            butI61.SetActive(false);
            butI62.SetActive(false);
            butI63.SetActive(false);
            butI64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageOutdoor.SetActive(true);
            counter = 0;
            section = 3;
            File.AppendAllText(writePath, "Indoor,6,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 4 && go.name == "ImgI64" && counter == 12)
        {
            butI61.SetActive(false);
            butI62.SetActive(false);
            butI63.SetActive(false);
            butI64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageOutdoor.SetActive(true);
            counter = 0;
            section = 3;
            File.AppendAllText(writePath, "Indoor,6,4," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        #endregion

        #region Social
        if (section == 5 && go.name == "ButtonContinueSocial" && counter == 0)
        {
            curTime = 0;
            pageSocial.SetActive(false);
            butCircle.SetActive(true);
            //butPause.SetActive(true);
            counter = 1;
        }
        if (section == 5 && go.name == "IntCircle" && counter == 1)
        {
            pressGreen = true;
            counter = 2;
        }
        if (section == 5 && go.name == "ImgL11" && counter == 2)
        {
            butL11.SetActive(false);
            butL12.SetActive(false);
            counter = 3;
            File.AppendAllText(writePath, "Social,1,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "ImgL12" && counter == 2)
        {
            butL11.SetActive(false);
            butL12.SetActive(false);
            counter = 3;
            File.AppendAllText(writePath, "Social,1,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "IntCircle" && counter == 3)
        {
            pressGreen = true;
            counter = 4;
        }
        if (section == 5 && go.name == "ImgL21" && counter == 4)
        {
            butL21.SetActive(false);
            butL22.SetActive(false);
            counter = 5;
            File.AppendAllText(writePath, "Social,2,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "ImgL22" && counter == 4)
        {
            butL21.SetActive(false);
            butL22.SetActive(false);
            counter = 5;
            File.AppendAllText(writePath, "Social,2,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "IntCircle" && counter == 5)
        {
            pressGreen = true;
            counter = 6;
        }
        if (section == 5 && go.name == "ImgL31" && counter == 6)
        {
            butL31.SetActive(false);
            butL32.SetActive(false);
            butL33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Social,3,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "ImgL32" && counter == 6)
        {
            butL31.SetActive(false);
            butL32.SetActive(false);
            butL33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Social,3,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "ImgL33" && counter == 6)
        {
            butL31.SetActive(false);
            butL32.SetActive(false);
            butL33.SetActive(false);
            counter = 7;
            File.AppendAllText(writePath, "Social,3,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "IntCircle" && counter == 7)
        {
            pressGreen = true;
            counter = 8;
        }
        if (section == 5 && go.name == "ImgL41" && counter == 8)
        {
            butL41.SetActive(false);
            butL42.SetActive(false);
            butL43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Social,4,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "ImgL42" && counter == 8)
        {
            butL41.SetActive(false);
            butL42.SetActive(false);
            butL43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Social,4,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "ImgL43" && counter == 8)
        {
            butL41.SetActive(false);
            butL42.SetActive(false);
            butL43.SetActive(false);
            counter = 9;
            File.AppendAllText(writePath, "Social,4,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "IntCircle" && counter == 9)
        {
            pressGreen = true;
            counter = 10;
        }
        if (section == 5 && go.name == "ImgL51" && counter == 10)
        {
            butL51.SetActive(false);
            butL52.SetActive(false);
            butL53.SetActive(false);
            butL54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Social,5,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "ImgL52" && counter == 10)
        {
            butL51.SetActive(false);
            butL52.SetActive(false);
            butL53.SetActive(false);
            butL54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Social,5,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "ImgL53" && counter == 10)
        {
            butL51.SetActive(false);
            butL52.SetActive(false);
            butL53.SetActive(false);
            butL54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Social,5,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "ImgL54" && counter == 10)
        {
            butL51.SetActive(false);
            butL52.SetActive(false);
            butL53.SetActive(false);
            butL54.SetActive(false);
            counter = 11;
            File.AppendAllText(writePath, "Social,5,4," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "IntCircle" && counter == 11)
        {
            pressGreen = true;
            counter = 12;
        }
        if (section == 5 && go.name == "ImgL61" && counter == 12)
        {
            butL61.SetActive(false);
            butL62.SetActive(false);
            butL63.SetActive(false);
            butL64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageLast.SetActive(true);
            counter = 0;
            section = 7;
            File.AppendAllText(writePath, "Social,6,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "ImgL62" && counter == 12)
        {
            butL61.SetActive(false);
            butL62.SetActive(false);
            butL63.SetActive(false);
            butL64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageLast.SetActive(true);
            counter = 0;
            section = 7;
            File.AppendAllText(writePath, "Social,6,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "ImgL63" && counter == 12)
        {
            butL61.SetActive(false);
            butL62.SetActive(false);
            butL63.SetActive(false);
            butL64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageLast.SetActive(true);
            counter = 0;
            section = 7;
            File.AppendAllText(writePath, "Social,6,3," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        if (section == 5 && go.name == "ImgL64" && counter == 12)
        {
            butL61.SetActive(false);
            butL62.SetActive(false);
            butL63.SetActive(false);
            butL64.SetActive(false);
            butCircle.SetActive(false);
            //butPause.SetActive(false);
            pageLast.SetActive(true);
            counter = 0;
            section = 7;
            File.AppendAllText(writePath, "Social,6,4," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }
        #endregion

        if (go.name == "ButtonPause")
        {
            butPause.SetActive(false);
            butContinue.SetActive(true);
            butPagePause.SetActive(true);
            pauseTime = curTime;
            gamePaused = true;
        }

        if (go.name == "ButtonContinue")
        {
            butPause.SetActive(true);
            butContinue.SetActive(false);
            butPagePause.SetActive(false);
            curTime = pauseTime;
            gamePaused = false;
        }

        if (go.name == "IntCircle" && trialOngoing == false)
        {
            curTime = 0f;
            trialOngoing = true;
        }

        if (go.name == "ButtonLastExit")
        {
            Application.Quit();
        }

        if (go.name == "ButtonQuit")
        {
            Application.Quit();
        }
    }
}
