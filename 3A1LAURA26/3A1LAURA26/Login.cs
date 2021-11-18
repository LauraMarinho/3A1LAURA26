using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace _3A1LAURA26
{
    class Login
    {
        public int id;
        public string nome, senha;

        Conexao obj = new Conexao();

        public bool Logar()
        {
            string sql = $"select * from login where nome='{nome}' and senha ='{senha}'";
            DataTable dt = obj.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;

            else return false;

        }
    }
}
