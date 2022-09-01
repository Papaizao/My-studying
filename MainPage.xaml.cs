
using MySqlConnector;
using System.Data;
using System.Data.SqlTypes;
namespace MauiApp1;


public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}
    public void Deletar(object sender, EventArgs e)
    {
        try
        {
            string s = Name.Text;
            Conexao c1 = new Conexao();
            c1.Deletar(s);
            msg.Text = "Deletado com sucesso";
        }
        catch(Exception ex)
        {
            
            msg.Text ="Erro" + ex;
        }
    }
    public void Adicionar(object sender, EventArgs e)
    {
        string nome = Name.Text;
        string senha = Senha.Text;
        if (nome != "" && senha != "")
        {
            try
            {
                Conexao c1 = new Conexao();
                c1.Adicionar(nome, senha);
                msg.Text = "Adicionado " + nome + " com sucesso";
            }
            catch (Exception ex)
            {
                msg.Text = "Erro" + ex;
            }
        }
        else
        {
            msg.Text = "Preencha os campos em branco";
        }
    }

   /* public void Consulta(object sender, EventArgs e)
    {
        
        Conexao c1 = new Conexao();
        c1.Consulta();
        c1.getRegistro();        
    }*/
    public void Atualizar(object sender, EventArgs e)
    {
        string nome = Name.Text;
        string senha = Senha.Text;
        try
        {
            Conexao c1 = new Conexao();
            c1.Atualizar(nome, senha);
            msg.Text = "Atualizado o campo senha com sucesso";

        }
        catch(Exception ex)
        {
            msg.Text = "Erro" + ex;
        }
    }
   
    public void Limpar(object sender, EventArgs e)
    {
        Name.Text = default;
        Senha.Text = default;
        msg.Text = default;
    }

}