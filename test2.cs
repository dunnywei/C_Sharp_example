//test array

namespace ArrayAppliation{
  
  class Myarray{
     static void Main(string[] args)
     {
       /*
       int []n=new int[10];
       
       for(int i=0;i<10;i++)
       {
         n[i]=i+10;
       }
       
       foreach(int j in n)
       {
          Console.WriteLine("Element[{0}]={1}",i,j);
       }
       */
       
       //2D arrays
       
       int [,] arr1=new int(3,4)
       {
         {0,1,2,3},
         {5,6,7,8},
         {9,10,11,12}
         {13,14,15,16}
       }
       
       for(int i=0;i<3;i++)
       {
           for(int j=0;j<4;j++)
           {
               Console.WriteLine("a[{0},{1}] = {2}",i,j,arr1[i,j]);
           }
       }
     }
  }


}
