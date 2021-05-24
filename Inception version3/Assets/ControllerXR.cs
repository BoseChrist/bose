using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ControllerXR : MonoBehaviour
{

    public XRNode inputSource;
    private XRRig rig;
    private Quaternion rotation;

    void Start()
    {
        rig = GetComponent<XRRig>();
    }

    void Update()
    {
        device.TryGetFeatureValue(CommonUsages.deviceRotation, out rotation);
    }

    private void FixedUpdate()
    {
        Vector3 roll = rotation.eulerAngles;
        print("roll " + roll.x);
    }




}