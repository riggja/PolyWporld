using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MyHands : MonoBehaviour
{
    public GameObject myHandPrefab;
    public InputDeviceCharacteristics myControllerCharacteristics;

    private InputDevice myDevice;
    private Animator myHandAnimator;


    // Start is called before the first frame update
    void Start()
    {
        InitializeMyHand();
    }


    void InitializeMyHand()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(myControllerCharacteristics, devices);

        if(devices.Count > 0)
        {
            myDevice = devices[0];

            GameObject newHand = Instantiate(myHandPrefab, transform);
            myHandAnimator = newHand.GetComponent<Animator>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(myDevice.isValid)
        {
            UpdateMyHand();
        }
        else
        {
            InitializeMyHand();
        }

    }

    void UpdateMyHand()
    {
        if(myDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            myHandAnimator.SetFloat("Trigger", triggerValue);
        }
        else
        {
           myHandAnimator.SetFloat("Trigger", 0);
        }

        if(myDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            myHandAnimator.SetFloat("Grip", gripValue);
        }
        else
        {
             myHandAnimator.SetFloat("Grip", 0);
        }
    }

}
