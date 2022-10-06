using System;
using System.Threading;



int[] matrix = new int[16]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
int c=0;
for(int i=0;i<4; i++)
{
    for(int j=0;j<4; j++)
    {
        Console.Write($"{matrix[c],4}");
       c++;     
    }
     Console.WriteLine();
}


int a= 15;
int col = a/4;
int row = a%4;
 Console.WriteLine(col);
 Console.WriteLine(row);

Console.WriteLine(matrix[a]);

