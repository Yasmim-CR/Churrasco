using System.Runtime.InteropServices;

int adultoQueBebe;
int adultoNaoBebe;
int crianca;

Console.WriteLine("Vamos fazer um Churrasco!");
    Console.WriteLine("Digite a quantidade de Aultos que não bebem:" );
    adultoNaoBebe = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Digite a quantidade de Aultos que bebem:" );
adultoQueBebe = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Digite a quantidade de Crianças:" );
        crianca = Convert.ToInt32(Console.ReadLine()!);

        double cerveja, refrigerante, agua, carne, acompanhamento;

agua = (adultoQueBebe + adultoNaoBebe+ crianca) * 0.4;
cerveja = (adultoQueBebe) * 2;
refrigerante= (adultoQueBebe + adultoNaoBebe+ crianca) * 0.5;
carne = (adultoQueBebe + adultoNaoBebe) * 0.4 + (crianca * 0.2);
acompanhamento = (adultoQueBebe + adultoNaoBebe+ crianca) * 0.2;



Console.WriteLine("--- Churrasco ---");

Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......:{adultoQueBebe}");
Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...:{adultoNaoBebe}");
Console.WriteLine($"$Crianças.......................................:{crianca}");

Console.WriteLine($"Carne...........................................:{carne}Kg");
Console.WriteLine($"Acompanhamentos.................................:{acompanhamento:N2}Kg");
Console.WriteLine($"Cerveja.........................................:{cerveja:N2}L");
Console.WriteLine($"Refrigerante....................................:{refrigerante:N2}L");
Console.WriteLine($"Água............................................:{agua:N2}L");