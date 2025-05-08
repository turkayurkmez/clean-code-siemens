using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{

    public interface IArea
    {
        int GetArea();
    }
    public class Geometry
    {
        public IArea GetRectangle(int unit1, int unit2=1)
        {
            //bir biçimde kare döndürdünüz....
            if (unit2 == 1)
            {
                return new Square() { Edge = unit1};
            }
            return new Rectangle() { Width = unit1, Height = unit2 };
         
        }
    }


    public class Rectangle : IArea
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : IArea//: Rectangle
    {
        //public override int Width { get => base.Width; set { base.Width = value; base.Height = value; } }
        //public override int Height { get => base.Height; set { base.Width = value; base.Height = value; } }
        public int Edge { get; set; }
        public int GetArea()
        {
            return Edge * Edge;
        }
    }
}
