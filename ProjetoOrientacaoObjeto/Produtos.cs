using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProjetoOrientacaoObjeto
{
    public class Produtos
    {
        private string codigo;
        private string nome;
        private string dataEntrada;
        private string dataSaida;

        private double valor;
        private double quantidade;
        public double Total(double produtoQtd, double valorProduto)
        {
            return produtoQtd * valorProduto;
        }

        // Código do produto
        public void setCod(string codigo)
        {
            this.codigo = codigo;
        }
        public string getCod()
        {
            return this.codigo;
        }

        // Nome do produto
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        // Valor do produto
        public void setValor(double valor)
        {
            this.valor = valor;
        }
        public double getValor()
        {
            return this.valor;
        }

        // Quantidade do produto
        public void setQtd(double quantidade)
        {
            this.quantidade = quantidade;
        }
        public double getQtd()
        {
            return this.quantidade;
        }

        // Data de entrada
        public void setDtEntrada(string dtEntrada)
        {
            this.dataEntrada = dtEntrada;
        }
        public string getDtEntrada()
        {
            return this.dataEntrada;
        }

        // Data de saida
        public void setDtSaida(string dtSaida)
        {
            this.dataSaida = dtSaida;
        }
        public string getDataSaida() 
        {
            return this.dataSaida;
        }
    }
}
