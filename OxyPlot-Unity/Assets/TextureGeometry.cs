using UnityEngine;
using System.Collections;

public static class TextureGeometry
{
    public static void DrawLine(Texture2D texture, int x0, int y0, int x1, int y1, Color color)
    {
        int dx = Mathf.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
        int dy = Mathf.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
        int err = (dx > dy ? dx : -dy) / 2, e2;

        while (true)
        {
            texture.SetPixel(x0, y0, color);
            if (x0 == x1 && y0 == y1) break;
            e2 = err;
            if (e2 > -dx) { err -= dy; x0 += sx; }
            if (e2 < dy) { err += dx; y0 += sy; }
        }
    }

    public static void DrawCircle(Texture2D texture, int x0, int y0, int radius, Color color)
    {
        int x = radius;
        int y = 0;
        int radiusError = 1 - x;

        while (x >= y)
        {
            DrawLine(texture, x + x0, y + y0, -x + x0, y + y0, color);

            DrawLine(texture, y + x0, x + y0, -y + x0, x + y0, color);
            DrawLine(texture, -x + x0, -y + y0, x + x0, -y + y0, color);
            DrawLine(texture, -y + x0, -x + y0, y + x0, -x + y0, color);
            y++;
            if (radiusError < 0)
            {
                radiusError += 2 * y + 1;
            }
            else
            {
                x--;
                radiusError += 2 * (y - x) + 1;
            }
        }
    }
}
