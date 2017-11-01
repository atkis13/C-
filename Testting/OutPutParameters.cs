using System;

namespace OutPutParameters {

   class Numbers {
       
       public void transform(out int x ){
           int temp = 4;
           x = temp;
       }

      static void Main(string[] args) {
        int a = 200;
        Console.WriteLine("before method: {0}", a);
        Numbers nu = new Numbers();
        nu.transform(out a);
        Console.WriteLine("after method call: {0}", a);
        
      }
   }
}
