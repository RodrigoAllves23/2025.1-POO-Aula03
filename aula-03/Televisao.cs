using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace aula_03;
class Televisao {

    //O método construtor possui o mesmo nome da classe
    //Ele possui não passui retorno (nem mesmo o void)
    //Esse metodo e executado sempre que uma instancia da classe e criada
    //Por padrão, o C# cria um método construtor publico vazio,
    //mas podemos criar métodos construtores com outras
    //visibilidades e recebendo parametros, se necessário.

    public Televisao(float tamanho)// metodo construtor não tem retorno, recomendado no maximo 3 parâmetros
    {
        if(tamanho < TAMANHO_MINIMO || tamanho >TAMANHO_MAXIMO)
        {
            //Uma exceção interrompe o fluxo normal do sistema
            throw new ArgumentOutOfRangeException($"O tamanho ({tamanho}) não e suportado"); //exceções o que e?
        }
        Tamanho = tamanho;
        Volume = VOLUME_PADRAO;
    }
    //Optamos por uma constante para tornar o código mais legivel
    private const float TAMANHO_MINIMO = 22; //constante para não permitir o tamnho menor que 22
    private const float TAMANHO_MAXIMO = 80;

    private const int VOLUME_MAXIMO = 100;
    private const int VOLUME_MINIMO = 0;

    private const int VOLUME_PADRAO = 10;


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
    //private const float  TAMANHO_MAXIMO = 22;

    private int _ultimoVolume = VOLUME_PADRAO;
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
    //1 botão de mudo - toggle (on/off)
    public void AlterarModoMudo()
    {
        if(Volume > VOLUME_MINIMO)
        {
            _ultimoVolume = Volume;
            Volume = VOLUME_MINIMO;
            Console.WriteLine("A TV está no modo MUTE.");
        }
        else
        {
            Volume = _ultimoVolume;
            Console.WriteLine($"O volume da TV é: {Volume}");
        }
    }
}
