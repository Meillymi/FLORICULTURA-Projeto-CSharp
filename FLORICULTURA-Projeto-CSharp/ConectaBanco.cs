using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace FLORICULTURA_Projeto_CSharp
{
    public class ConectaBanco
    {
        private const string SERVER = "localhost";
        private const int PORT = 3306;
        private const string DATABASE = "banco_floricultura";
        private const string USER = "floricultura";
        private const string PASSWORD = "1234";

        private MySqlConnection conexao;

        public ConectaBanco()
        {
            string cs = $"server={SERVER};port={PORT};database={DATABASE};user={USER};password={PASSWORD}";
            conexao = new MySqlConnection(cs);
        }

        public bool validaLogin(string login, string senha)
        {
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_loginUsuario", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_login", login);
                cmd.Parameters.AddWithValue("p_senha", senha);
                var reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
            catch { return false; }
            finally { conexao.Close(); }
        }

        public DataTable listaCategorias()
        {
            var dt = new DataTable();
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_listaCategorias", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch { }
            finally { conexao.Close(); }
            return dt;
        }

        public int insereCategoria(string nome)
        {
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_insereCategoria", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_nome", nome);
                var dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                if (dt.Rows.Count > 0)
                    return Convert.ToInt32(dt.Rows[0]["idNovo"]);
                return -1;
            }
            catch { return -1; }
            finally { conexao.Close(); }
        }

        public bool removeCategoria(int id)
        {
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_removeCategoria", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_id", id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conexao.Close(); }
        }

        public DataTable listaFlores()
        {
            var dt = new DataTable();
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_listaFlores", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch { }
            finally { conexao.Close(); }
            return dt;
        }

        public int insereFlor(string nome, int idCategoria, double preco, int estoque, string imagem)
        {
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_insereFlor", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_nome", nome);
                cmd.Parameters.AddWithValue("p_idcat", idCategoria);
                cmd.Parameters.AddWithValue("p_preco", preco);
                cmd.Parameters.AddWithValue("p_estoque", estoque);
                cmd.Parameters.AddWithValue("p_imagem", imagem);
                var dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                if (dt.Rows.Count > 0) return Convert.ToInt32(dt.Rows[0]["idNovo"]);
                return -1;
            }
            catch { return -1; }
            finally { conexao.Close(); }
        }

        public bool removeFlor(int id)
        {
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_removeFlor", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_id", id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conexao.Close(); }
        }

        public bool alteraFlor(int id, string nome, int idCategoria, double preco, int estoque, string imagem)
        {
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_alteraFlor", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_id", id);
                cmd.Parameters.AddWithValue("p_nome", nome);
                cmd.Parameters.AddWithValue("p_idcat", idCategoria);
                cmd.Parameters.AddWithValue("p_preco", preco);
                cmd.Parameters.AddWithValue("p_estoque", estoque);
                cmd.Parameters.AddWithValue("p_imagem", imagem);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conexao.Close(); }
        }

        public DataTable listaClientes()
        {
            var dt = new DataTable();
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_listaClientes", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch { }
            finally { conexao.Close(); }
            return dt;
        }

        public int insereCliente(string nome, string tel, string email, string endereco)
        {
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_insereCliente", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_nome", nome);
                cmd.Parameters.AddWithValue("p_tel", tel);
                cmd.Parameters.AddWithValue("p_email", email);
                cmd.Parameters.AddWithValue("p_endereco", endereco);
                var dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                if (dt.Rows.Count > 0) return Convert.ToInt32(dt.Rows[0]["idNovo"]);
                return -1;
            }
            catch { return -1; }
            finally { conexao.Close(); }
        }

        public bool removeCliente(int id)
        {
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_removeCliente", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_id", id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conexao.Close(); }
        }

        public bool alteraCliente(int id, string nome, string tel, string email, string endereco)
        {
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_alteraCliente", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_id", id);
                cmd.Parameters.AddWithValue("p_nome", nome);
                cmd.Parameters.AddWithValue("p_tel", tel);
                cmd.Parameters.AddWithValue("p_email", email);
                cmd.Parameters.AddWithValue("p_endereco", endereco);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conexao.Close(); }
        }

        public int inserePedido(int idCliente, double total)
        {
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_inserePedido", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_idcliente", idCliente);
                cmd.Parameters.AddWithValue("p_total", total);
                var dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                if (dt.Rows.Count > 0) return Convert.ToInt32(dt.Rows[0]["idNovo"]);
                return -1;
            }
            catch { return -1; }
            finally { conexao.Close(); }
        }

        public bool insereItemPedido(int idPedido, int idFlor, double preco, int qtd)
        {
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_insereItemPedido", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_idpedido", idPedido);
                cmd.Parameters.AddWithValue("p_idflor", idFlor);
                cmd.Parameters.AddWithValue("p_preco", preco);
                cmd.Parameters.AddWithValue("p_qtd", qtd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conexao.Close(); }
        }

        public DataTable listaPedidos(DateTime de, DateTime ate)
        {
            var dt = new DataTable();
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_listaPedidos", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_de", de.Date);
                cmd.Parameters.AddWithValue("p_ate", ate.Date);
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch { }
            finally { conexao.Close(); }
            return dt;
        }

        public DataTable listaPedidosPorCategoria(DateTime de, DateTime ate, int idCategoria)
        {
            var dt = new DataTable();
            try
            {
                conexao.Open();
                var cmd = new MySqlCommand("sp_listaPedidosPorCategoria", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_de", de.Date);
                cmd.Parameters.AddWithValue("p_ate", ate.Date);
                cmd.Parameters.AddWithValue("p_idcat", idCategoria);
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch { }
            finally { conexao.Close(); }
            return dt;
        }
    }
}