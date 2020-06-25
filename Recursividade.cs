using System;

namespace Aula_25
{
    public class Recursividade
    {
        // 0, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377
        public void GerarSequenciaDeFibonacci(int num1, int num2, int vezes){

            // Precisamos de uma condição de parada
            if(vezes > 0){

                Console.WriteLine(num1);
                GerarSequenciaDeFibonacci(num2, num1 + num2, vezes - 1);
            }
        }
        public int GerarFatorial(int num){
            
            if(num == 1){
                return 1;
            }else{

                
                return num * GerarFatorial( num - 1);
                 

            }


        }
    }
}