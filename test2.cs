//test array

namesapce ArrayAppliation{
  
  class Myarray{
     static void Main(string[] args)
     {
       int []n=new int[10];
       
       for(int i=0;i<10;i++)
       {
         n[i]=i+10;
       }
       
       foreach(int j in n)
       {
          Console.WriteLine("Element[{0}]={1}",i,j);
       }
     }
  }


}
