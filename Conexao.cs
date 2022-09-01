using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiApp1
{
    public class Conexao
    {
        private string nome;
        private string senha;
        private string registro;

        public String getRegistro()
        {
            return this.registro;
        }
        public void Consulta()
        {
           
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=dumdum; password=Senbonzakur@1");
            objcon.Open();

            MySqlCommand objCmd = new MySqlCommand("select * from crud", objcon);
            
            MySqlDataReader dr;
            dr = objCmd.ExecuteReader();
            dr.Read();
            String registro = "";
            if(registro != "")
            {
                this.registro = registro;
            }
            objcon.Close();
        }
        public void Deletar(String nome)
        {
            this.nome = nome;

            
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=dumdum; password=Senbonzakur@1");
                objcon.Open();

                MySqlCommand objCmd = new MySqlCommand("select nome from crud where nome = ?", objcon);
                objCmd.Parameters.Add("@nome", MySqlDbType.VarChar, 40).Value = this.nome;

                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();
                String b = dr.GetString(0);
                objcon.Close();
                if (b.Equals(this.nome))
                {
                    objcon.Open();

                    MySqlCommand objcmd = new MySqlCommand("delete from crud where nome = ?", objcon);
                    objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 40).Value = this.nome;
                    
                    objcmd.ExecuteNonQuery();

                }

                objcon.Close();
        }
        public void Adicionar(string nome, string senha)
        {
                this.nome = nome;
                this.senha = senha;

           
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=dumdum; password=Senbonzakur@1");
                objcon.Open();

                MySqlCommand objCmd = new MySqlCommand("insert into crud(nome, senha) values(?, ?)", objcon);
                objCmd.Parameters.Add("@nome", MySqlDbType.VarChar, 40).Value = this.nome;
                objCmd.Parameters.Add("@senha", MySqlDbType.VarChar, 40).Value = this.senha;


                objCmd.ExecuteNonQuery();
           
        }
        public void Atualizar(string nome,string senha)
        {
            this.nome = nome;
            this.senha = senha;

            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=dumdum; password=Senbonzakur@1");
            objcon.Open();


            MySqlCommand objCMD = new MySqlCommand("update crud set senha = ? where nome = ?", objcon);
            objCMD.Parameters.Add("@senha", MySqlDbType.VarChar, 40).Value = this.senha;
            objCMD.Parameters.Add("@nome", MySqlDbType.VarChar, 40).Value = this.nome;

            objCMD.ExecuteNonQuery();
        }
    }
}
