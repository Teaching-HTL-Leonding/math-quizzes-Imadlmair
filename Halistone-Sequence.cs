int i = 0;
int newnumb = 0;
System.Console.WriteLine("Please enter the number you want to start with ? " );
int startnumb = int.Parse(Console.ReadLine()!);
do{
    
    if(startnumb % 2 == 0)
    {
        i ++;
        newnumb = startnumb / 2;
    }
    
    else 
    {
        newnumb = startnumb * 3 + 1;
        i++;
    }
    startnumb = newnumb;
}while(startnumb != 1);
i ++;
System.Console.WriteLine($"The lenght of your sequence is {i}");