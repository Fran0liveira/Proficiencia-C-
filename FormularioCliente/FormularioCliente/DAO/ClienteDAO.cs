using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormularioCliente.Banco;
using FormularioCliente.Modelos;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormularioCliente.DAO
{
    public class ClienteDAO
    {
        int seuId;

        public int InserirCliente(Cliente obj)
        {
            using (var connection = new SqlConnection(FactoryConnection.SQLConnectionString))
            {
                try
                {
                    string cmdsql = $"insert into cliente" +
                                       $"(nome,rg,cpf,tel_residencial,tel_celular,sexo)" +
                                       $"values('{obj.Nome}'," +
                                       $"'{obj.Rg}'," +
                                       $"'{obj.Cpf}'," +
                                       $"'{obj.Residencial}'," +
                                       $"'{obj.Celular}'," +
                                       $"'{obj.Sexo}') SELECT SCOPE_IDENTITY()";

                    SqlCommand executesql = new SqlCommand(cmdsql, connection);

                    connection.Open();

                    seuId = Convert.ToInt32(executesql.ExecuteScalar());

                    MessageBox.Show("Cadastro efetuado com sucesso!");

                    connection.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return seuId;
        }

        public void deletarCliente(Cliente obj)
        {
            using (var connection = new SqlConnection(FactoryConnection.SQLConnectionString))
            {
                try
                {
                    //Variavel que armazenar um comando sql
                    string cmdsql = $"delete from cliente " +
                                    $"where codigo ='{obj.Codigo}' ";


                    SqlCommand executesql = new SqlCommand(cmdsql, connection);

                    connection.Open();


                    executesql.ExecuteNonQuery();


                    MessageBox.Show("Exclusão Efetuada com Sucesso");


                    connection.Close();


                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        public void alterarCliente(Cliente obj)
        {
            using(var connection = new SqlConnection(FactoryConnection.SQLConnectionString))
            {
                try
                {
                    string cmdsql = "update cliente set " +
                                    $"nome = '{obj.Nome}'," +
                                    $"rg = '{obj.Rg}'," +
                                    $"cpf = '{obj.Cpf}'," +
                                    $"tel_residencial = '{obj.Residencial}'," +
                                    $"tel_celular = '{obj.Celular}'," +
                                    $"sexo = '{obj.Sexo}'" +
                                    $"where codigo = '{obj.Codigo}'";

                    SqlCommand executesql = new SqlCommand(cmdsql, connection);

                    connection.Open();

                    executesql.ExecuteNonQuery();
                    MessageBox.Show("Alteração efetuada com sucesso");

                    connection.Close();
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}

