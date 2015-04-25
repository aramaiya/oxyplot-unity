using UnityEngine;
using System.Collections;
using OxyPlot;

public class TextureRenderContext : MonoBehaviour, IRenderContext
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CleanUp()
    {
        throw new System.NotImplementedException();
    }

    public void DrawEllipse(OxyRect extents, OxyColor fill, OxyColor stroke, double thickness = 1)
    {
        throw new System.NotImplementedException();
    }

    public void DrawEllipses(System.Collections.Generic.IList<OxyRect> extents, OxyColor fill, OxyColor stroke, double thickness = 1)
    {
        throw new System.NotImplementedException();
    }

    public void DrawImage(OxyImage source, double srcX, double srcY, double srcWidth, double srcHeight, double destX, double destY, double destWidth, double destHeight, double opacity, bool interpolate)
    {
        throw new System.NotImplementedException();
    }

    public void DrawLine(System.Collections.Generic.IList<ScreenPoint> points, OxyColor stroke, double thickness = 1, double[] dashArray = null, LineJoin lineJoin = LineJoin.Miter, bool aliased = false)
    {
        throw new System.NotImplementedException();
    }

    public void DrawLineSegments(System.Collections.Generic.IList<ScreenPoint> points, OxyColor stroke, double thickness = 1, double[] dashArray = null, LineJoin lineJoin = LineJoin.Miter, bool aliased = false)
    {
        throw new System.NotImplementedException();
    }

    public void DrawPolygon(System.Collections.Generic.IList<ScreenPoint> points, OxyColor fill, OxyColor stroke, double thickness = 1, double[] dashArray = null, LineJoin lineJoin = LineJoin.Miter, bool aliased = false)
    {
        throw new System.NotImplementedException();
    }

    public void DrawPolygons(System.Collections.Generic.IList<System.Collections.Generic.IList<ScreenPoint>> polygons, OxyColor fill, OxyColor stroke, double thickness = 1, double[] dashArray = null, LineJoin lineJoin = LineJoin.Miter, bool aliased = false)
    {
        throw new System.NotImplementedException();
    }

    public void DrawRectangle(OxyRect rectangle, OxyColor fill, OxyColor stroke, double thickness = 1)
    {
        throw new System.NotImplementedException();
    }

    public void DrawRectangles(System.Collections.Generic.IList<OxyRect> rectangles, OxyColor fill, OxyColor stroke, double thickness = 1)
    {
        throw new System.NotImplementedException();
    }

    public void DrawText(ScreenPoint p, string text, OxyColor fill, string fontFamily = null, double fontSize = 10, double fontWeight = 400, double rotation = 0, HorizontalAlignment horizontalAlignment = HorizontalAlignment.Left, VerticalAlignment verticalAlignment = VerticalAlignment.Top, OxySize? maxSize = null)
    {
        throw new System.NotImplementedException();
    }

    public OxySize MeasureText(string text, string fontFamily = null, double fontSize = 10, double fontWeight = 500)
    {
        throw new System.NotImplementedException();
    }

    public bool RendersToScreen
    {
        get { throw new System.NotImplementedException(); }
    }

    public void ResetClip()
    {
        throw new System.NotImplementedException();
    }

    public bool SetClip(OxyRect clippingRectangle)
    {
        throw new System.NotImplementedException();
    }

    public void SetToolTip(string text)
    {
        throw new System.NotImplementedException();
    }
}
