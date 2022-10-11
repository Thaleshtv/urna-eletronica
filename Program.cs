using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrnaEletronica
{
    public class Program
    {
        static void Main(string[] args) 
        {
            CandidatoLula candidatoUm = new CandidatoLula();
            CandidatoBolsonaro candidatoDois = new CandidatoBolsonaro();
            VotoNulo votoNulo = new VotoNulo();

            Console.WriteLine("Bolsonaro - 22 \r\nLula - 13\r\nNulo - 0\r\n");

            for(int i = 0; i < 5; i++) {
                Console.WriteLine("Digite o numero do seu candidato\r\n");

                string? numeroCandidato = Console.ReadLine();

                if(numeroCandidato == "13") {
                    candidatoUm.SetNumeroDeVotosCandidatoLula(1);
                    Console.WriteLine("Você votou em Lula\r\n");
                }

                if(numeroCandidato == "22") {
                    candidatoDois.SetNumeroDeVotosCandidatoBolsonaro(1);
                    Console.WriteLine("Você votou em Bolsonaro\r\n");
                }

                if(numeroCandidato == "0") {
                    votoNulo.SetVotoNulo(1);
                    Console.WriteLine("Você votou nulo!\r\n");
                }

                if(numeroCandidato != "13" && numeroCandidato != "22" && numeroCandidato != "0") {
                    Console.WriteLine("Numero de candidato inexistente, voto não computado!\r\n");
                }
            }
            
            string presidenteEleito = "";
            int numeroDeVotosBolsonaro = candidatoDois.GetNumeroDeVotosCandidatoBolsonaro();
            int numeroDeVotosLula = candidatoUm.GetNumeroDeVotosCandidatoLula();
            int numeroDeVotosNulo = votoNulo.GetNumeroDeVotosNulo();

            if(numeroDeVotosBolsonaro > numeroDeVotosLula) {
                presidenteEleito = "Bolsonaro";
            } 

            if(numeroDeVotosLula > numeroDeVotosBolsonaro) {
                presidenteEleito = "Lula";
            }

            if(numeroDeVotosBolsonaro == numeroDeVotosLula) {
                presidenteEleito = "Empate!";
            }
            

            Console.WriteLine($"Apuração total dos votos! \r\nBolsonaro - {candidatoDois.GetNumeroDeVotosCandidatoBolsonaro()} \r\nLula - {candidatoUm.GetNumeroDeVotosCandidatoLula()} \r\nNulo - {votoNulo.GetNumeroDeVotosNulo()} \r\n\nPresidente eleito - {presidenteEleito}");
        }
    }
}