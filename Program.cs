namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            # region Cabeçalho
            Console.WriteLine("- - - - - CLASSE PERSONAGEM - - - - -");
            Console.Write("\nInsira a quantidade de personagens que deseja cadastrar: ");
            #endregion
            int p = int.Parse(Console.ReadLine());
            # region Personagem
            Console.WriteLine("Insira as informações abaixo, separadas por ';'");
            Console.WriteLine("\n| ID | Nome | Casa | Origem | Ator/Atriz | Vivo (S/N) | Ano Nasc. | Cor dos lhos | Sexo(M/F) | Cor do cabelo | Bruxo (S/N) |");
            # endregion
            string[] dados = Console.ReadLine().Split(';');
            do
            {
                Personagem personagem = new Personagem();
                for (int i = 0; i < dados.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            personagem.idPersonagem = dados[i];
                            break;
                        case 1:
                            personagem.nome = dados[i];
                            break;
                        case 2:
                            personagem.nomeDaCasa = dados[i];
                            break;
                        case 3:
                            personagem.origem = dados[i];
                            break;
                        case 4:
                            personagem.atorAtriz = dados[i];
                            break;
                        case 5:
                                personagem.estaVivo = bool.Parse(dados[i]);
                            break;
                        case 6:
                            personagem.anoNascimento = int.Parse(dados[i]);
                            break;
                        case 7:
                            personagem.corOlhos = dados[i];
                            break;
                        case 8:
                            personagem.sexo = dados[i];
                            break;
                        case 9:
                            personagem.corCabelo = dados[i];
                            break;
                        case 10:
                                personagem.bruxo = bool.Parse(dados[i]);
                            break;
                    }
                }
                p--;
            } while (p > 0);

            Console.Write("Digite a quantidade de comandos deseja realizar: ");
            int c = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("- - - - - TABELA DE COMANDOS - - - - -");
                Console.WriteLine("Empi: Empilhar");
                Console.WriteLine("Desempi: Desempilhar");
                Console.WriteLine("TemCPil: Tem na pilha?");
                Console.WriteLine("Enfi: Enfileirar");
                Console.WriteLine("Desenfi: Desenfileirar");
                Console.WriteLine("TemCFil: Tem na fila?");
                Console.WriteLine("InsFim: Inserir no final");
                Console.WriteLine("InsIni: Inserir no ínicio");
                Console.WriteLine("RemComec: Remover no ínicio");
                Console.WriteLine("RemFim: Remover no final\n");
                Console.Write("Insira o comando: ");
                string[] comando = Console.ReadLine().Split(';');

                if (comando[0].Equals("Empi"))
                
                else if(comando[0].Equals("Enfi"))
                        
                else if (comando[0].Equals("InsFim")) 
                            
                else if(comando[0].Equals("InsIni"))
                 

            } while (c > 0);
        }
    }
}
