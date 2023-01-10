using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System;
using UnityEngine.EventSystems;

public class gameTrialExp : MonoBehaviour
{
    public GameObject butPage5;
    public GameObject butPage6;
    public GameObject butPage8;
    public GameObject butPage10;
    public GameObject butPage11;
    public GameObject butPage12;
    public GameObject butPage14;
    public GameObject butPage17;
    public GameObject butPageColor;
    public GameObject butPagePause;
    public GameObject butCircle;
    public GameObject butBaseline1;
    public GameObject butBaseline2;
    public GameObject butBaseline3;
    public GameObject butBaseline4;
    public GameObject butBaseline5;
    public GameObject butTrial11;
    public GameObject butTrial12;
    public GameObject butTrial21;
    public GameObject butTrial22;
    public GameObject butTrial31;
    public GameObject butTrial32;
    public GameObject butTrial41;
    public GameObject butTrial42;
    public GameObject butTrial51;
    public GameObject butTrial52;
    public GameObject butPartC;

    public GameObject butPause;
    public GameObject butContinue;

    public int countTrial;
    public float curTime;
    private float pauseTime;
    public string writePath;

    public float timeLimit = 15;

    public gameCtrl fileInfo;

    private bool gamePaused = false;
    public bool trialOngoing = false;
    public bool pressCircle;
    private const float timeDelay = 2f;

    // Start is called before the first frame update
    void Start()
    {
        countTrial = 0;
        pressCircle = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gamePaused)
        {
            curTime = 0;
        }

        if((countTrial%2==1))
        {
            trialOngoing = false;
        }

        curTime += Time.deltaTime;

        #region delay
        if(pressCircle)
        {
            if(curTime> timeDelay && countTrial==0)
            {
                butPage6.SetActive(false);
                butBaseline1.SetActive(true);
                pressCircle = false;
            }
            if (curTime > timeDelay && countTrial == 2)
            {
                butPage8.SetActive(false);
                butBaseline2.SetActive(true);
                pressCircle = false;
            }
            if (curTime > timeDelay && countTrial == 4)
            {
                butBaseline3.SetActive(true);
                pressCircle = false;
            }
            if (curTime > timeDelay && countTrial == 6)
            {
                butBaseline4.SetActive(true);
                pressCircle = false;
            }
            if (curTime > timeDelay && countTrial == 8)
            {
                butBaseline5.SetActive(true);
                pressCircle = false;
            }
            if (curTime > timeDelay && countTrial == 10)
            {
                butPage12.SetActive(false);
                butTrial11.SetActive(true);
                butTrial12.SetActive(true);
                pressCircle = false;
            }
            if (curTime > timeDelay && countTrial == 12)
            {
                butTrial21.SetActive(true);
                butTrial22.SetActive(true);
                pressCircle = false;
            }
            if (curTime > timeDelay && countTrial == 14)
            {
                butTrial31.SetActive(true);
                butTrial32.SetActive(true);
                pressCircle = false;
            }
            if (curTime > timeDelay && countTrial == 16)
            {
                butTrial41.SetActive(true);
                butTrial42.SetActive(true);
                pressCircle = false;
            }
            if (curTime > timeDelay && countTrial == 18)
            {
                butTrial51.SetActive(true);
                butTrial52.SetActive(true);
                pressCircle = false;
            }
        }
        #endregion

        #region limit cross
        if (curTime > timeLimit)
        {
            if (butBaseline1.activeInHierarchy)
            {
                butBaseline1.SetActive(false);
                butPage8.SetActive(true);
                countTrial = 1;
                File.AppendAllText(writePath, "Baseline,1,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butBaseline2.activeInHierarchy)
            {
                butBaseline2.SetActive(false);
                countTrial = 3;
                File.AppendAllText(writePath, "Baseline,2,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butBaseline3.activeInHierarchy)
            {
                butBaseline3.SetActive(false);
                countTrial = 5;
                File.AppendAllText(writePath, "Baseline,3,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butBaseline4.activeInHierarchy)
            {
                butBaseline4.SetActive(false);
                countTrial = 7;
                File.AppendAllText(writePath, "Baseline,4,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butBaseline5.activeInHierarchy)
            {
                butBaseline5.SetActive(false);
                countTrial = 9;
                //butPause.SetActive(false);
                File.AppendAllText(writePath, "Baseline,5,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }

            if (butTrial11.activeInHierarchy)
            {
                butTrial11.SetActive(false);
                butTrial12.SetActive(false);
                countTrial = 11;
                File.AppendAllText(writePath, "Practice,1,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
                butCircle.SetActive(false);
                butPage14.SetActive(true);
                //butPause.SetActive(false);
            }
            if (butTrial21.activeInHierarchy)
            {
                butTrial21.SetActive(false);
                butTrial22.SetActive(false);
                countTrial = 13;
                File.AppendAllText(writePath, "Practice,2,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butTrial31.activeInHierarchy)
            {
                butTrial31.SetActive(false);
                butTrial32.SetActive(false);
                countTrial = 15;
                File.AppendAllText(writePath, "Practice,3,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butTrial41.activeInHierarchy)
            {
                butTrial41.SetActive(false);
                butTrial42.SetActive(false);
                countTrial = 17;
                File.AppendAllText(writePath, "Practice,4,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
            }
            if (butTrial51.activeInHierarchy)
            {
                butTrial51.SetActive(false);
                butTrial52.SetActive(false);
                countTrial = 19;
                butCircle.SetActive(false);
                butPage17.SetActive(true);
                File.AppendAllText(writePath, "Practice,5,0," + Math.Round(timeLimit - timeDelay, 2).ToString() + ",False" + "\n");
                //butPause.SetActive(false);
            }
        }
        #endregion
    }

    public void OnMouseDown()
    {
        var go = EventSystem.current.currentSelectedGameObject;
        if (go.name == "ButtonContinue5")
        {
            butPage5.SetActive(false);
            butPage6.SetActive(true);
            butCircle.SetActive(true);
            //butPause.SetActive(true);
            writePath = fileInfo.GetComponent<gameCtrl>().path;
            timeLimit = fileInfo.GetComponent<gameCtrl>().timeLimit+timeDelay;
        }
        if (go.name == "IntCircle" && butPage6.activeInHierarchy)
        {
            curTime = 0;
            butPage6.SetActive(false);
            countTrial = 0;
            pressCircle = true;
        }

        if (go.name == "ImgB11" && countTrial == 0)
        {
            butBaseline1.SetActive(false);
            butPage8.SetActive(true);
            countTrial = 1;
            File.AppendAllText(writePath, "Baseline,1,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }

        if (go.name == "IntCircle" && countTrial==1)
        {
            butPage8.SetActive(false);
            countTrial = 2;
            pressCircle = true;
        }

        if (go.name == "ImgB21" && countTrial == 2)
        {
            butBaseline2.SetActive(false);
            countTrial = 3;
            File.AppendAllText(writePath, "Baseline,2,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }

        if (go.name == "IntCircle" && countTrial == 3)
        {
            countTrial = 4;
            pressCircle = true;
        }

        if (go.name == "ImgB31" && countTrial == 4)
        {
            butBaseline3.SetActive(false);
            countTrial = 5;
            File.AppendAllText(writePath, "Baseline,3,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }

        if (go.name == "IntCircle" && countTrial == 5)
        {
            countTrial = 6;
            pressCircle = true;
        }

        if (go.name == "ImgB41" && countTrial == 6)
        {
            butBaseline4.SetActive(false);
            countTrial = 7;
            File.AppendAllText(writePath, "Baseline,4,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }

        if (go.name == "IntCircle" && countTrial == 7)
        {
            countTrial = 8;
            pressCircle = true;
        }

        if (go.name == "ImgB51" && countTrial == 8)
        {
            butBaseline5.SetActive(false);
            countTrial = 9;
            File.AppendAllText(writePath, "Baseline,5,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }

        if (go.name == "IntCircle" && countTrial == 9)
        {
            butCircle.SetActive(false);
            butPage10.SetActive(true);
            countTrial = 10;
            //butPause.SetActive(false);
        }

        if (go.name == "ButtonContinue10")
        {
            butPage10.SetActive(false);
            butPage11.SetActive(true);
        }

        if (go.name == "ButtonContinue11")
        {
            butPage11.SetActive(false);
            butPage12.SetActive(true);
            butCircle.SetActive(true);
            //butPause.SetActive(true);
        }

        if (go.name == "IntCircle" && butPage12.activeInHierarchy)
        {
            curTime = 0;
            butPage12.SetActive(false);
            countTrial = 10;
            pressCircle = true;
        }

        if (go.name == "ImgT11" && countTrial == 10)
        {
            butTrial11.SetActive(false);
            butTrial12.SetActive(false);
            countTrial = 11;
            File.AppendAllText(writePath, "Practice,1,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
            butCircle.SetActive(false);
            butPage14.SetActive(true);
            //butPause.SetActive(false);
        }

        if (go.name == "ImgT12" && countTrial == 10)
        {
            butTrial11.SetActive(false);
            butTrial12.SetActive(false);
            countTrial = 11;
            File.AppendAllText(writePath, "Practice,1,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
            butCircle.SetActive(false);
            butPage14.SetActive(true);
            //butPause.SetActive(false);
        }
        /*
        if (go.name == "IntCircle" && countTrial == 11)
        {
            butCircle.SetActive(false);
            countTrial = 12;
            butPage14.SetActive(true);
        }
        */
        if (go.name == "ButtonContinue14")
        {
            butPage14.SetActive(false);
            butCircle.SetActive(true);
            //butPause.SetActive(true);
        }

        if (go.name == "IntCircle" && countTrial == 11)
        {
            countTrial = 12;
            pressCircle = true;
        }

        if (go.name == "ImgT21" && countTrial == 12)
        {
            butTrial21.SetActive(false);
            butTrial22.SetActive(false);
            countTrial = 13;
            File.AppendAllText(writePath, "Practice,2,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }

        if (go.name == "ImgT22" && countTrial == 12)
        {
            butTrial21.SetActive(false);
            butTrial22.SetActive(false);
            countTrial = 13;
            File.AppendAllText(writePath, "Practice,2,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }

        if (go.name == "IntCircle" && countTrial == 13)
        {
            countTrial = 14;
            pressCircle = true;
        }

        if (go.name == "ImgT31" && countTrial == 14)
        {
            butTrial31.SetActive(false);
            butTrial32.SetActive(false);
            countTrial = 15;
            File.AppendAllText(writePath, "Practice,3,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }

        if (go.name == "ImgT32" && countTrial == 14)
        {
            butTrial31.SetActive(false);
            butTrial32.SetActive(false);
            countTrial = 15;
            File.AppendAllText(writePath, "Practice,3,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }

        if (go.name == "IntCircle" && countTrial == 15)
        {
            countTrial = 16;
            pressCircle = true;
        }

        if (go.name == "ImgT41" && countTrial == 16)
        {
            butTrial41.SetActive(false);
            butTrial42.SetActive(false);
            countTrial = 17;
            File.AppendAllText(writePath, "Practice,4,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }

        if (go.name == "ImgT42" && countTrial == 16)
        {
            butTrial41.SetActive(false);
            butTrial42.SetActive(false);
            countTrial = 17;
            File.AppendAllText(writePath, "Practice,4,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
        }

        if (go.name == "IntCircle" && countTrial == 17)
        {
            countTrial = 18;
            pressCircle = true;
        }

        if (go.name == "ImgT51" && countTrial == 18)
        {
            butTrial51.SetActive(false);
            butTrial52.SetActive(false);
            countTrial = 19;
            File.AppendAllText(writePath, "Practice,5,1," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
            butCircle.SetActive(false);
            butPage17.SetActive(true);
        }

        if (go.name == "ImgT52" && countTrial == 18)
        {
            butTrial51.SetActive(false);
            butTrial52.SetActive(false);
            countTrial = 19;
            File.AppendAllText(writePath, "Practice,5,2," + Math.Round(curTime - timeDelay, 2).ToString() + ",True" + "\n");
            butCircle.SetActive(false);
            butPage17.SetActive(true);
            //butPause.SetActive(false);
        }

        if (go.name == "ButtonContinue17")
        {
            butPage17.SetActive(false);
            butPageColor.SetActive(true);
        }

        if (go.name == "ButtonQuit")
        {
            Application.Quit();
        }

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

        if (go.name == "IntCircle" && trialOngoing==false)
        {
            curTime = 0f;
            trialOngoing = true;
        }
    }

}