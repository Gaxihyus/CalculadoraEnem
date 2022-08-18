using System;

namespace CalculadoraEnem
{
    class Program
    {
            // Pesos
            double pesoLing;
            double pesoHum;
            double pesoNat;
            double pesoMat;
            double pesoRed;

            // Notas
            double notaLing;
            double notaHum;
            double notaNat;
            double notaMat;
            double notaRed;

            // Médias
            double mediaArit;
            double mediaPond;

        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------------------------------");
            
            Program p = new Program();

            p.PedirPesos();

            Console.WriteLine("============\n\n============");

            p.PedirNotas();


            p.mediaArit = Math.Round((p.notaLing + p.notaHum + p.notaNat + p.notaMat + p.notaRed)/5, 2, MidpointRounding.AwayFromZero);
            p.mediaPond = Math.Round(((p.notaLing * p.pesoLing) + (p.notaHum * p.pesoHum) + (p.notaNat * p.pesoNat) + (p.notaMat * p.pesoMat) + (p.notaRed * p.pesoRed)) / (p.pesoLing + p.pesoHum + p.pesoNat + p.pesoMat + p.pesoRed), 2, MidpointRounding.AwayFromZero);

            Console.WriteLine("======================================");
            Console.WriteLine($" DISCIPLINA | NOTA | PESO | NOTA*PESO");
            Console.WriteLine($" LINGUAGENS | {p.notaLing:F2} | {p.pesoLing:F2} | {p.notaLing * p.pesoLing:F2} ");
            Console.WriteLine($" HUMANAS    | {p.notaHum:F2} | {p.pesoHum:F2} | {p.notaHum * p.pesoHum:F2}");
            Console.WriteLine($" NATUREZA   | {p.notaNat:F2} | {p.pesoNat:F2} | {p.notaNat * p.pesoNat:F2}");
            Console.WriteLine($" MATEMÁTICA | {p.notaMat:F2} | {p.pesoMat:F2} | {p.notaMat * p.pesoMat:F2}");
            Console.WriteLine($" REDAÇÃO    | {p.notaRed:F2} | {p.pesoRed:F2} | {p.notaRed * p.pesoRed:F2}");
            Console.WriteLine("======================================");
            Console.WriteLine($"MEDIA ARITMÉTICA: {p.mediaArit:F2}");
            Console.WriteLine($"MEDIA PONDERADA: {p.mediaPond:F2}");
            Console.WriteLine("======================================");
        }

        void PedirPesos()
        {
            Console.WriteLine("Digite o seu peso em Linguagens: ");
            pesoLing = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite o seu peso em Humanas: ");
            pesoHum = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite o seu peso em Natureza: ");
            pesoNat = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite o seu peso em Matematica: ");
            pesoMat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o seu peso em Redação");
            pesoRed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Pesos listados:\nLinguagens: {pesoLing}\nHumanas: {pesoHum}\nNatureza: {pesoNat}\nMatemática: {pesoMat}\nRedação: {pesoRed}");

        }

        void PedirNotas()
        {

            Console.WriteLine("Digite a sua nota em Linguagens: ");
            notaLing = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite a sua nota em Humanas: ");
            notaHum = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite a sua nota em Natureza: ");
            notaNat = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite a sua nota em Matematica: ");
            notaMat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a sua nota em Redação");
            notaRed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Notas listadas:\nLinguagens: {notaLing}\nHumanas: {notaHum}\nNatureza: {notaNat}\nMatemática: {notaMat}\nRedação: {notaRed}");

        }
    }
}
