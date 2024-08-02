using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace ValidacaoEmails
{
    public class ValidacaoEmail
    {
        //Crie um teste unitário para o método ValidarEmail que verifica se um email é validado corretamente.
        //Exemplo: se o email passado contém "@"  e  " . "
        
        public static bool ValidarEmail(string email) {
            string caracteresCorretos = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, caracteresCorretos))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
