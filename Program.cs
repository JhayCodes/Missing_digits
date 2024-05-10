// See https://aka.ms/new-console-template for more information

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] digits = new int[5];
        
        for(int i = 0; i <= 9; i++){
            int sum = (i*i) + i + (10-i) + (i+1) + (14-(10-i));
            if(sum == 30){
                digits[0] = (i*i);
                digits[1] = i;
                digits[2] = (10-i);
                digits[3] = (i+1);
                digits[4] = 14 - (10-i);
                break;
            }
        }
        Console.Write("The digit code is... ");
        foreach(int number in digits){
            Console.Write(number);
        }
    }
}