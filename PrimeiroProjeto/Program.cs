using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args) {
            //string nome;
            //int n1 = 90;
            //float n2 = 40f; //precisa pelo menos um dos numeros ser float para que a divisão nao seja int
            //float n3 = n1 / n2; //se dividir 2 numeros int, o resultado sempre será int
            //int a, b;

            //Console.WriteLine("Hello World!");

            //Console.WriteLine("Escreva seu nome");
            //nome = Console.ReadLine();
            //Console.WriteLine("Seu nome é: " + nome);

            //Console.WriteLine(n3);

            //Console.WriteLine("Insira o valor de a");
            //a = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Insira o valor de b");
            //b = Convert.ToInt16(Console.ReadLine());

            //if (a > b){
            //    Console.WriteLine("a maior");
            //} else if (b < a) {
            //    Console.WriteLine("b maior");
            //} else {
            //    Console.WriteLine("são iguais");
            //}


            //Somar(30, 50);
            //Console.WriteLine("O preço final é: " + CalcTaxa(1500.80f));

            //string[] names = { "Matheus", "Maria" };
            ////Console.WriteLine(names[1].StartsWith("Ma")); //verificações com string

            ////for
            //for (int i = 0; i < names.Length; i++) {
            //    Console.WriteLine(names[i]);
            //}
            ////foreach 
            ////faz a mesma coisa do for acima
            //foreach (string name in names) {
            //        Console.WriteLine(name);
            // }

            //string s = null;

            //try {
            //    Console.WriteLine(s.Length);
            //} catch (Exception err) {
            //    Console.WriteLine($"Erro de referencia.\n{err.Message}\n {err.StackTrace}");
            //}

            var conta1 = new BankAccount("3343-4", 432423.4m);
            var conta2 = new BankAccount("3343232-4", 423.4m);

            conta1.Deposito(-100);
            conta2.Deposito(99999);

            Console.WriteLine(conta1.Saldo);
            Console.WriteLine(conta2.Saldo);

            Console.ReadLine();

        }

        interface ILogger {
            void Log(string message);
        }

        class ConsoleLooger : ILogger {
            public void Log(string message) {
                Console.WriteLine(message);
            }
        }

        class BankAccount {
            private string nome;
            private decimal saldo;

            //     public string Nome { get { return nome}; set { nome }; }
            public decimal Saldo { get; private set; }
            public BankAccount(string nome, decimal saldo) {
               // verificar se é nulo e menor que 0
                if (string.IsNullOrWhiteSpace(nome)) {
                    throw new Exception("Nome Inválido");
                }
                if (saldo < 0) {
                    throw new Exception("Saldo não por ser negativo");
                }
                this.nome = nome;
                Saldo = saldo;
            }

            public void Deposito(decimal valor) {
                if (valor <= 0) {
                    try {
                        throw new Exception("O valor depositado não pode ser negativo.");
                    } catch (Exception) {
                        Console.WriteLine($"Error!");

                    }
                } else {
                    Saldo += valor;
                }
            }
        }

        static void Somar(int a, int b) {
            Console.WriteLine("A soma é: " + (a + b));
        }

        static float CalcTaxa(float preco) {
            return preco * 1.20f;
        }
    }
}
