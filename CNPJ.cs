namespace Heran_a
{
    public class CNPJ : Pessoa
    {
        public string cnpj;

        public bool ValidarCNPJ(){
           if(cnpj !=null){
               return true;
           } 
           return false; 
        }
    }
}