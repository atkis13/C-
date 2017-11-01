using System;

namespace FirstApp {
    
    class FirstApp1{

      static void Main(string[] args) {
          const double pi = 3.14;
          int r;
          ;
          //Console.WriteLine("Enter radius: ");
          //r = Convert.ToDouble(Console.ReadLine());
          r = 1;
          double asum = 0;
          
          do {
             if(r == 6){
                r = r+1;
                continue;
            } 
            double areaCircle = pi*r*r;
            Console.WriteLine("Area: {0}, Radius: {1}", areaCircle, r);
            r++;
            int i = 1500;
            asum += areaCircle; 
            Console.WriteLine("The sum of Area is: {0}", asum);
            
            
            if (asum > i) {
                Console.WriteLine("limit exceeded, sum area is {0}, the limit is {1}" , asum, i);
                break;
                
            }
          }
          while(r <= 13);
          
          
      }  
          
          
          
          
       
    }   
}
