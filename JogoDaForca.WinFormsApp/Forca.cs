using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.WinFormsApp
{
    public class Forca
    {
        public string[] PalavraAleatoria = { "Abacate", "Abacaxi", "Acerola", "Acai", "Araca", "Figo", "Bacaba", "Bacuri", "Banana", "Caja", "Caju", "Carambola", "Cupuacu", "Graviola", "Goiaba", "Jabuticaba", "Jenipapo", "Maca", "Mangaba", "Manga", "Maracuja", "Murici", "Pequi", "Pitanga", "Pitaya", "Sapoti", "Tangerina", "Umbu", "Uva", "Uvaia" };
        public string PalavraEscolhida;

        public string SortearPalavra()
        {
            Random random = new Random();
            int escolherPalavra = random.Next(0, 30);
            PalavraEscolhida = PalavraAleatoria[escolherPalavra].ToUpper();

            return PalavraEscolhida;
        }
    }
}
