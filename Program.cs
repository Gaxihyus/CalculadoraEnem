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


            p.mediaArit = (p.notaLing + p.notaHum + p.notaNat + p.notaMat + p.notaRed)/5;
            p.mediaPond = ((p.notaLing * p.pesoLing) + (p.notaHum * p.pesoHum) + (p.notaNat * p.pesoNat) + (p.notaMat * p.pesoMat) + (p.notaRed * p.pesoRed)) / (p.pesoLing + p.pesoHum + p.pesoNat + p.pesoMat + p.pesoRed);

            Console.WriteLine("======================================");
            Console.WriteLine($" DISCIPLINA | NOTA | PESO | NOTA*PESO");
            Console.WriteLine($" LINGUAGENS | {p.notaLing} | {p.pesoLing} | {p.notaLing * p.pesoLing} ");
            Console.WriteLine($" HUMANAS    | {p.notaHum} | {p.pesoHum} | {p.notaHum * p.pesoHum}");
            Console.WriteLine($" NATUREZA   | {p.notaNat} | {p.pesoNat} | {p.notaNat * p.pesoNat}");
            Console.WriteLine($" MATEMÁTICA | {p.notaMat} | {p.pesoMat} | {p.notaMat * p.pesoMat}");
            Console.WriteLine($" REDAÇÃO    | {p.notaRed} | {p.pesoRed} | {p.notaRed * p.pesoRed}");
            Console.WriteLine("======================================");
            Console.WriteLine($"MEDIA ARITMÉTICA: {p.mediaArit}");
            Console.WriteLine($"MEDIA PONDERADA: {p.mediaPond}");
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
