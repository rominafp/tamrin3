int number;
for (var i = 0; i < 4; i++)
{
    System.Console.WriteLine("hoghogh ra vared konid");
    number=Convert.ToInt32(Console.ReadLine());
    
    if (number>2000000 && number<3000000)
{
   System.Console.WriteLine(number*0.05);
}
else if(number>3000000)
{
    System.Console.WriteLine(number*0.07);
}
else
{
    System.Console.WriteLine("maliat=0");
}
}

