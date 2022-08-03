using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImagesController : Element
{

    //public Transform transformOfSprite;
    public Transform canvasTrasnform;
    public Vector3 beforeSavePos;


    public void SaveTransformPos()
    {
        Vector3 BeforeSavePositon = canvasTrasnform.position;
    }

    public void ChangePosition(float sliderValue, char token)
    {

        canvasTrasnform.position = token switch
        {
            'x' => new Vector3(sliderValue, canvasTrasnform.position.y, canvasTrasnform.position.z),
            'y' => new Vector3(canvasTrasnform.position.x, sliderValue, canvasTrasnform.position.z),
            _ => new Vector3(canvasTrasnform.position.x, canvasTrasnform.position.y, sliderValue),
        };
    }

    public void ChangeScale(float sliderValue, char token)
    {
        canvasTrasnform.localScale = token switch
        {
            'x' => new Vector3(sliderValue, canvasTrasnform.localScale.y, canvasTrasnform.localScale.z),
            _ => new Vector3(canvasTrasnform.localScale.x, sliderValue, canvasTrasnform.localScale.z),
        };
    }

    public void LoadTransformOfImage()
    {
        App.configView.sliderPositionX.value = App.configModel.imagesCanvasTransform.position.x;
        App.configView.sliderPositionY.value = App.configModel.imagesCanvasTransform.position.y;
        App.configView.sliderPositionZ.value = App.configModel.imagesCanvasTransform.position.z;

        App.configView.sliderScaleX.value = App.configModel.imagesCanvasTransform.localScale.x;
        App.configView.sliderScaleY.value = App.configModel.imagesCanvasTransform.localScale.y;

    }


}
