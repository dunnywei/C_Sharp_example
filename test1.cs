using system

namespace RectangleAppliation{
  class Rectangle {
     double length;
     double width;

     public double GetArea(doube _l,double _w)
     {
        this.length=_l;
        this.width=_w;
        return this.length*this.width;
     }



  }
  class ExecuteRectangle{
      static void Main(string[] args)
      {
         Rectangle r=new Rectangle();
         Console.Writeline("Area is",r.GetAgrea(10,20));
      }
  }
  
}
