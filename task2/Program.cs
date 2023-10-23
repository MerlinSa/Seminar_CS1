//напишите прогу, которая на вход принимает целое число N,
//а на выходе показывает все целые число в промежутке от -N до N.
//примеры, 
// 4 => -4,3,2,-1,0,1,2,3,4
// 2=> -2,-1,0,1,2

int numberA = 4;
int start = numberA * -1;
int count = start;
while(count <= numberA){
    Console.Write(count + " ");
    count = count +1;
}



