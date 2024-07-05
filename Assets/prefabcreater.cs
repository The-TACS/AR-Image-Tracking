using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class prefabcreater : MonoBehaviour
{
    [SerializeField] private GameObject dragonPrefag;
    [SerializeField] private Vector3 prefabOffset;

    private GameObject dragon;
    private ARTrackedImageManager aRTrackedImageManager;
    
    private void onEnable()
    {
        aRTrackedImageManager= gameObject.GetComponent<ARTrackedImageManager>();
        aRTrackedImageManager.trackedImagesChanged+= OnImageChanged;
    
    }
     private void OnImageChanged(ARTrackedImagesChangedEventArgs obj)
   {
        foreach (ARTrackedImage image in obj.added)
        {
            dragon = Instantiate(dragonPrefag, image.transform);
            dragon.transform.position+=prefabOffset;
        }
    }
  
}
