namespace aula_03;
class Televisao {

    //O método construtor possui o mesmo nome da classe
    //Ele possui não passui retorno (nem mesmo o void)
    //Esse metodo e executado sempre que uma instancia da classe e criada
    //
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }


    //Get: permite que seja executada a leitura do valor da propriedade
    //Set: Permite que seja atribuido um valor para a propriedade

    //Classes, propriedades e métodos possuem modoficadores de acesso
    //public: visiveis a todo o projeto
    //internal: visivel soemente no namespace - padrão
    //private: visiveis somente dentro da classe
    public float Tamanho { get; private set; }
    public int Resolucao { get; set; }
    public int Volume { get; set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }
}