using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OrangeTrial : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public gameTrialExp trialCtrl;
    public gameProper properCtrl;
    private const float timeDelay = 1.95f;

    public void OnPointerDown(PointerEventData data)
    {
        #region Trials
        if (trialCtrl.butPage6.activeInHierarchy || trialCtrl.countTrial == -1)
        {
            trialCtrl.curTime = 0;
            //trialCtrl.butPage6.SetActive(false);
            trialCtrl.countTrial = 0;
            trialCtrl.pressCircle = true;
        }
        if (trialCtrl.countTrial == 1)
        {
            //trialCtrl.butPage8.SetActive(false);
            trialCtrl.countTrial = 2;
            trialCtrl.pressCircle = true;
        }
        if (trialCtrl.countTrial == 3)
        {
            trialCtrl.countTrial = 4;
            trialCtrl.pressCircle = true;
        }
        if (trialCtrl.countTrial == 5)
        {
            trialCtrl.countTrial = 6;
            trialCtrl.pressCircle = true;
        }
        if (trialCtrl.countTrial == 7)
        {
            trialCtrl.countTrial = 8;
            trialCtrl.pressCircle = true;
        }
        if (trialCtrl.countTrial == 9)
        {
            trialCtrl.butCircle.SetActive(false);
            trialCtrl.butPage10.SetActive(true);
            trialCtrl.countTrial = 10;
        }
        if (trialCtrl.butPage12.activeInHierarchy || trialCtrl.countTrial == -2)
        {
            trialCtrl.curTime = 0;
            //trialCtrl.butPage12.SetActive(false);
            trialCtrl.countTrial = 10;
            trialCtrl.pressCircle = true;
        }
        if (trialCtrl.countTrial == 11)
        {
            trialCtrl.countTrial = 12;
            trialCtrl.pressCircle = true;
        }
        if (trialCtrl.countTrial == 13)
        {
            trialCtrl.countTrial = 14;
            trialCtrl.pressCircle = true;
        }
        if (trialCtrl.countTrial == 15)
        {
            trialCtrl.countTrial = 16;
            trialCtrl.pressCircle = true;
        }
        if (trialCtrl.countTrial == 17)
        {
            trialCtrl.countTrial = 18;
            trialCtrl.pressCircle = true;
        }
        if (trialCtrl.trialOngoing == false)
        {
            trialCtrl.curTime = 0f;
            trialCtrl.trialOngoing = true;
        }
        #endregion

        #region Proper
        if (properCtrl.counter == 1)
        {
            properCtrl.pressGreen = true;
            properCtrl.counter = 2;
        }
        if (properCtrl.counter == 3)
        {
            properCtrl.pressGreen = true;
            properCtrl.counter = 4;
        }
        if (properCtrl.counter == 5)
        {
            properCtrl.pressGreen = true;
            properCtrl.counter = 6;
        }
        if (properCtrl.counter == 7)
        {
            properCtrl.pressGreen = true;
            properCtrl.counter = 8;
        }
        if (properCtrl.counter == 9)
        {
            properCtrl.pressGreen = true;
            properCtrl.counter = 10;
        }
        if (properCtrl.counter == 11)
        {
            properCtrl.pressGreen = true;
            properCtrl.counter = 12;
        }
        if (properCtrl.trialOngoing == false)
        {
            properCtrl.curTime = 0f;
            properCtrl.trialOngoing = true;
        }
        #endregion
    }

    public void OnPointerUp(PointerEventData data)
    {
        #region Trials
        if (trialCtrl.curTime < timeDelay)
        {
            trialCtrl.pressCircle = false;
            trialCtrl.trialOngoing = false;
            if (trialCtrl.countTrial == 0)
            {
                trialCtrl.countTrial = -1;
            }
            if (trialCtrl.countTrial == 2)
            {
                trialCtrl.countTrial = 1;
            }
            if (trialCtrl.countTrial == 4)
            {
                trialCtrl.countTrial = 3;
            }
            if (trialCtrl.countTrial == 6)
            {
                trialCtrl.countTrial = 5;
            }
            if (trialCtrl.countTrial == 8)
            {
                trialCtrl.countTrial = 7;
            }
            // Practice
            if (trialCtrl.countTrial == 10)
            {
                trialCtrl.countTrial = -2;
            }
            if (trialCtrl.countTrial == 12)
            {
                trialCtrl.countTrial = 11;
            }
            if (trialCtrl.countTrial == 14)
            {
                trialCtrl.countTrial = 13;
            }
            if (trialCtrl.countTrial == 16)
            {
                trialCtrl.countTrial = 15;
            }
            if (trialCtrl.countTrial == 18)
            {
                trialCtrl.countTrial = 17;
            }
        }
        #endregion

        #region Proper
        if (properCtrl.curTime < timeDelay)
        {
            properCtrl.pressGreen = false;
            properCtrl.trialOngoing = false;
            if (properCtrl.counter == 2)
            {
                properCtrl.counter = 1;
            }
            if (properCtrl.counter == 4)
            {
                properCtrl.counter = 3;
            }
            if (properCtrl.counter == 6)
            {
                properCtrl.counter = 5;
            }
            if (properCtrl.counter == 8)
            {
                properCtrl.counter = 7;
            }
            if (properCtrl.counter == 10)
            {
                properCtrl.counter = 9;
            }
            if (properCtrl.counter == 12)
            {
                properCtrl.counter = 11;
            }
        }
        #endregion
    }
}
