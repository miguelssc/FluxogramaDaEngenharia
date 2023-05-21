string resposta2;
string resposta3;
Console.WriteLine("esta se movendo?");
string resposta1 = Console.ReadLine()!;
if(resposta1 == "N"){
    Console.WriteLine("Deveria?");
     resposta2 = Console.ReadLine()!;
if (resposta2 == "S"){
    Console.WriteLine("Use WD-40.");
}
else{
    Console.WriteLine("otimo");

}
}
else 
  {
    Console.WriteLine("Deveria?");
    resposta3 = Console.ReadLine()!;
    if (resposta3 == "S"){
    Console.WriteLine("otimo");

    }
    else{
        Console.WriteLine("Use Silver Tape.");
    }
}

   
