using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests;

public class Tests()
{
    [Fact]
    public void bigN3()
    {
    int n1 = 2;
    int n2 = 4; 
    int n3 = 6; 

    Assert.Equal(6, result);
    }

     [Fact]
    public void bigN2()
    {
    int n1 = 2;
    int n2 = 6; 
    int n3 = 4; 

    Assert.Equal(6, result);
    }

     [Fact]
    public void bigN1()
    {
    int n1 = 6;
    int n2 = 4; 
    int n3 = 2; 

    Assert.Equal(6, result);
    }

    public int findMoreNum(int n1, int n2, int n3)
    {
        int n1 = number % 10; 
        int n2 = (number / 10) % 10; 
        int n3 = number / 100;

                    if (n1 < n2 && n3 < n2)
            {
                if (n1 < n3)
                {
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine(n1);
                }   
            }
            else 
            {
               Console.WriteLine(n2); 
            }
    }


}

