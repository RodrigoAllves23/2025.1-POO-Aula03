using System.Diagnostics.Contracts;

namespace aula_03;
class Televisao {

    //O método construtor possui o mesmo nome da classe
    //Ele possui não passui retorno (nem mesmo o void)
    //Esse metodo e executado sempre que uma instancia da classe e criada
    //Por padrão, o C# cria um método construtor publico vazio,
    //mas podemos criar métodos construtores com outras
    //visibilidades e recebendo parametros, se necessário.
    public Televisao(float tamanho)// metodo construtor não tem retorno 
    {
        if(tamanho < TAMANHO_MINIMO || tamanho >TAMANHO_MAXIMO)
        {
            //Uma exceção interrompe o fluxo normal do sistema
            throw new ArgumentOutOfRangeException($"O tamanho ({tamanho}) não e suportado");
        }
        Tamanho = tamanho;
        Volume = VOLUME_PADRAO;
    }
    //Optamos por uma constante para tornar o código mais legivel
    private const float TAMANHO_MINIMO = 22; //constante para não permitir o tamnho menor que 22
    private const float TAMANHO_MAXIMO = 80;

    private int VOLUME_MAXIMO = 100;
    private int VOLUME_MINIMO = 0;

    private int VOLUME_PADRAO = 10;


    //Get: permite que seja executada a leitura do valor da propriedade
    //Set: Permite que seja atribuido um valor para a propriedade

    //Classes, propriedades e métodos possuem modoficadores de acesso
    //public: visiveis a todo o projeto
    //internal: visivel soemente no namespace - padrão
    //private: visiveis somente dentro da classe
    public float Tamanho { get;}
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

    public void AumentarVolume()
    {
        if (Volume < VOLUME_MAXIMO){
          Volume++;         
          //Volume += 1;// utilizar quando tiver alguma regra 
        } else{
            Console.WriteLine("A TV ja esta no volume máximo permitido");
        }
        

    }
    public void DiminuirVolume() 
    {
        if(Volume > VOLUME_MINIMO){
            
        Volume--;         
          //Volume += 1;// utilizar quando tiver alguma regra 
        } else{
            Console.WriteLine("A TV ja esta no volume minimo permitido");
        }
    }
}
