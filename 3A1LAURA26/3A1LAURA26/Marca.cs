using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace _3A1LAURA26
{
    class Marca
    {
        public int id;
        public string descricao, marca;

        Conexao obj = new Conexao();

        public void Cadastrar()
        {

            string inserir = $@"insert into marca values ('{id}', '{descricao}', '{marca}');";
            obj.ExecutarComando(inserir);

        }

        public DataTable Listar()     //Requer: using System.Data;
        {
            string listar = $"SELECT * FROM marca; ";
            return obj.ExecutarConsulta(listar);
        }
        public void Excluir()
        {
            string deletar = $"DELETE FROM marca WHERE `marca`.`id` = '{id}'; ";
            obj.ExecutarComando(deletar);
        }

        public void Alterar()
        {
            string alterar = $"UPDATE marca SET descricao = '{descricao}', marca = '{marca}' WHERE `marca`.`id` = '{id}'";
            obj.ExecutarComando(alterar);
        }
    }
}
