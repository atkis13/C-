using System;

namespace FirstApp {
    
    class FirstApp1{
        
        public int findMax(int a, int b){
            int result;
            if (a > b){
                result = a;
            }
            else{
                result = b;
            }
            
            return result;
        }

      static void Main(string[] args) {
          
          int a = 234;
          int b = 123;
          int ret;
          
          FirstApp1 f = new FirstApp1();
          
          ret = f.findMax(a,b);
          Console.WriteLine("The max value is {0}", ret);
          
      }
    }   
}
