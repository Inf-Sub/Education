// version 1

int a1 = 43;
int a2 = 23;
int a3 = 33;
int b1 = 85;
int b2 = 58;
int b3 = 15;
int c1 = 48;
int c2 = 78;
int c3 = 34;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);