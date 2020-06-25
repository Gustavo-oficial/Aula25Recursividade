namespace Aula25Recursividade
{
    public class Recursividade
    {
        public void MostrarFibonacci(int numb1, int numb2,int sequencia){
        if(sequencia > 0){
        System.Console.WriteLine(numb1);
        MostrarFibonacci(numb2, numb1 + numb2, sequencia - 1);
        System.Console.WriteLine(numb1);
        }

        }

            public int GerarFatorial(int numb){
             if(numb == 1){
                 return 1;
             }else{
                 return numb * GerarFatorial(numb -1);
             }
            }
    }
}