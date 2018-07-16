using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    class Bressenham
    {
        public Bressenham (int Ix,int Iy,int Fx, int Fy)
        {
         //   x0 = Ix;
         //   y0 = Iy;
         //   x1 = Fx;
         //   y1 = Fy;
            LineaBresenham(Ix, Iy, Fx, Fy);
        }

        int x0;
        int y0;
        int x1;
        int y1;

        List<Point> Camino = new List<Point>();

        void LineaBresenham(int x0, int y0, int x1, int y1)
        {

            int x, y, dx, dy, p, incE, incNE, stepx, stepy;
            dx = (x1 - x0);
            dy = (y1 - y0);

            if (dy < 0)
            {
                dy = -dy;
                stepy = -1;
            }
            else
            {
                stepy = 1;
            }
            if (dx < 0)
            {
                dx = -dx;
                stepx = -1;
            }
            else
            {
                stepx = 1;
            }
            x = x0;
            y = y0;
            agregarCoordenada(x,y);
            if (dx > dy)
            {
                p = 2 * dy - dx;
                incE = 2 * dy;
                incNE = 2 * (dy - dx);
                while (x != x1)
                {
                    x = x + stepx;
                    if (p < 0)
                    {
                        p = p + incE;
                    }
                    else
                    {
                        y = y + stepy;
                        p = p + incNE;
                    }
                    agregarCoordenada(x, y);
                }
            }
            else
            {
                p = 2 * dx - dy;
                incE = 2 * dx;
                incNE = 2 * (dx - dy);
                while (y != y1)
                {
                    y = y + stepy;
                    if (p < 0)
                    {
                        p = p + incE;
                    }
                    else
                    {
                        x = x + stepx;
                        p = p + incNE;
                    }
                    agregarCoordenada(x, y);
                }
            }
        }


        void agregarCoordenada(int x, int y)
        {
            Point P = new Point();
            P.X = x;
            P.Y = y;
            Camino.Add(P);

        }

        public List<Point> getCamino()
        {
            return this.Camino;
        }
    }
}
