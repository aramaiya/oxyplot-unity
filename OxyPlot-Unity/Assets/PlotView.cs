using UnityEngine;
using System.Collections;
using OxyPlot;
public class PlotView : MonoBehaviour, IPlotView 
{

	// Use this for initialization
	void Start (){
	
	}
	
	// Update is called once per frame
	void Update (){
	
	}

    public PlotModel ActualModel
    {
        get { throw new System.NotImplementedException(); }
    }

    public void HideTracker()
    {
        throw new System.NotImplementedException();
    }

    public void InvalidatePlot(bool updateData = true)
    {
        throw new System.NotImplementedException();
    }

    public void ShowTracker(TrackerHitResult trackerHitResult)
    {
        throw new System.NotImplementedException();
    }

    public void SetClipboardText(string text)
    {
        throw new System.NotImplementedException();
    }

    Model IView.ActualModel
    {
        get { throw new System.NotImplementedException(); }
    }

    public IController ActualController
    {
        get { throw new System.NotImplementedException(); }
    }

    public OxyRect ClientArea
    {
        get { throw new System.NotImplementedException(); }
    }

    public void SetCursorType(CursorType cursorType)
    {
        throw new System.NotImplementedException();
    }

    public void HideZoomRectangle()
    {
        throw new System.NotImplementedException();
    }

    public void ShowZoomRectangle(OxyRect rectangle)
    {
        throw new System.NotImplementedException();
    }
}
