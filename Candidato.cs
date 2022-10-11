using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrnaEletronica
{
    public class CandidatoLula
    {
        public int NumeroCandidatoLula { get; set; }
        public string? NomeCandidatoLula { get; set; }
        public int NumeroDeVotosCandidatoLula { get; set; }
        public CandidatoLula()
        {
            NumeroCandidatoLula = 13;
            NomeCandidatoLula = "Lula";
            NumeroDeVotosCandidatoLula = 0;
        }  

        public void SetNumeroDeVotosCandidatoLula(int value)
        {
            NumeroDeVotosCandidatoLula = NumeroDeVotosCandidatoLula + value;
        }

        public int GetNumeroDeVotosCandidatoLula()
        {
            return NumeroDeVotosCandidatoLula;
        }
    }

    public class CandidatoBolsonaro 
    {
        public int NumeroCandidatoBolsonaro { get; set; }
        public string? NomeCandidatoBolsonaro { get; set; }

        public int NumeroDeVotosCandidatoBolsonaro { get; set; }

        public CandidatoBolsonaro() 
        {
            NumeroCandidatoBolsonaro = 22;
            NomeCandidatoBolsonaro = "Bolsonaro"; 
            NumeroDeVotosCandidatoBolsonaro = 0;
        }

        public void SetNumeroDeVotosCandidatoBolsonaro(int value)
        {
            NumeroDeVotosCandidatoBolsonaro = NumeroDeVotosCandidatoBolsonaro + value;
        }

        public int GetNumeroDeVotosCandidatoBolsonaro()
        {
            return NumeroDeVotosCandidatoBolsonaro;
        }
    }

    public class VotoNulo
    {
        public int NumeroVotoNulo { get; set; }
        public string? NomeVotoNulo { get; set; }
        public int NumeroDeVotosNulo { get; set; }

        public VotoNulo()
        {
            NumeroVotoNulo = 0;
            NomeVotoNulo = "Nulo";
            NumeroDeVotosNulo = 0;
        }

        public void SetVotoNulo(int value)
        {
            NumeroDeVotosNulo = NumeroDeVotosNulo + value;
        }

        public int GetNumeroDeVotosNulo()
        {
            return NumeroDeVotosNulo;
        }
    }
}