﻿Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("*");

int xa = 40, ya = 1,
    xb = 1, yb = 25,
    xc = 80, yc = 25;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int xnew = xa, ynew = ya;
int count = 0;

while(count < 10000)
{
    int n = new Random().Next(0,3); // 0  1 или 2
    if (n == 0)
    {
        xnew = (xnew+xa)/2;
        ynew = (ynew+ya)/2;
    }
    
    if (n == 1)
    {
        xnew = (xnew+xb)/2;
        ynew = (ynew+yb)/2;
    }
    if (n == 2)
    {
        xnew = (xnew+xc)/2;
        ynew = (ynew+yc)/2;
    }
    Console.SetCursorPosition(xnew, ynew);
    Console.WriteLine("*");
    count ++;
}