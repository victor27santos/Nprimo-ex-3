// Numero Primo ex2
using System;
     
class Victor
{
   
 //função para verificar se o numero é primo
 static bool isPrime(int n){
      //desde 0 e 1 não é primo volta a ser falso.
     if(n==1||n==0)return false;
   
      //Run a loop from 2 to n/2.
      for(int i=2; i<=n/2; i++){
        // se o numero é divisivel por ele, então n não é um numero primo.
        if(n%i==0)return false;
      }
  //otherwise, n é numero primo.
  return true;
}
 
// Driver code
public static void Main (String[] args)
{
    int N = 100000;
    //check for every number from 1 to N
      for(int i=1; i<=N; i++){
      //check if current number is prime
      if(isPrime(i)) {
        Console.Write(i + " ");
      }
    }
     
}
}