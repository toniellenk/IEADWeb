
Imports System
Imports System.Text
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.AccessControl
Imports IEADWebApp.Membros

Namespace IEADWebApp

    Public Class Dados


        Public srtConexao As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString

        Public Const strSelectTop100 As String = "SELECT * FROM t0050"
        Public Const strSelect As String = "SELECT * FROM t0050 WHERE idmembro = @idmembro"
        Public Const strInsert As String = "INSERT INTO t0050 VALUES(@nome, @cidade, @uf, @cep, @tipomembro, @endereco)"
        Public Const strUpdate As String = "UPDATE t0050 SET nome = @nome, cidade = @cidade, uf = @uf, cep = @cep," +
            " tipomembro = @tipomembro, endereco = @endereco WHERE idmembro = @idmembro"
        Public Const strDelete As String = "DELETE t0050 WHERE idmembro = @idmembro"

        Public Function Consultar(idmembro As Integer) As DataTable

            Dim membro As New Membros()

            Dim ds As New DataSet()
            Dim dt As New DataTable()

            Using ObjConexao As New SqlConnection(srtConexao)

                Using ObjComando As New SqlCommand(strSelect, ObjConexao)

                    ObjComando.Parameters.AddWithValue("@idmembro", idmembro)

                    ObjConexao.Open()

                    ' ObjComando.CommandType = CommandType.Text

                    Dim dtadap As New SqlDataAdapter(ObjComando)

                    dtadap.Fill(ds)
                    dt = ds.Tables(0)

                    'Dim leitura As SqlDataReader = ObjComando.ExecuteReader()

                    ' dt.Load(leitura) -

                    ' GridViewMembros.DataSource = dt.Tables("t0050")


                    'membro.IdMembro = leitura("idmembro")
                    'membro.NomeMembro = leitura("nome")
                    'membro.CidadeMembro = leitura("cidade")
                    ' membro.UfMembro = leitura("uf")
                    'membro.CepMembro = leitura("cep")
                    'membro.TipoMembro = leitura("tipomembro")
                    'membro.EndMembro = leitura("endereco")

                    ObjConexao.Close()
                    Return dt

                End Using

            End Using

        End Function


        Public Function Consultar() As DataTable

            Dim membro As New Membros()

            Dim ds As New DataSet()
            Dim dt As New DataTable()

            Using ObjConexao As New SqlConnection(srtConexao)

                Using ObjComando As New SqlCommand(strSelectTop100, ObjConexao)

                    ObjConexao.Open()

                    ' ObjComando.CommandType = CommandType.Text

                    Dim dtadap As New SqlDataAdapter(ObjComando)

                    dtadap.Fill(ds)
                    dt = ds.Tables(0)

                    'Dim leitura As SqlDataReader = ObjComando.ExecuteReader()

                    ' dt.Load(leitura) -

                    ' GridViewMembros.DataSource = dt.Tables("t0050")


                    'membro.IdMembro = leitura("idmembro")
                    'membro.NomeMembro = leitura("nome")
                    'membro.CidadeMembro = leitura("cidade")
                    ' membro.UfMembro = leitura("uf")
                    'membro.CepMembro = leitura("cep")
                    'membro.TipoMembro = leitura("tipomembro")
                    'membro.EndMembro = leitura("endereco")

                    ObjConexao.Close()
                    Return dt

                End Using

            End Using

        End Function
        Public Sub Remover(idmembro As Integer)

            Using ObjConexao As New SqlConnection(srtConexao)

                Using ObjComando As New SqlCommand(strDelete, ObjConexao)

                    ObjComando.Parameters.AddWithValue("@idmembro", idmembro)

                    ObjConexao.Open()

                    ObjComando.ExecuteNonQuery()

                    ObjConexao.Close()

                End Using

            End Using

        End Sub

        Public Sub Inserir(nome As String, cidade As String, uf As String, cep As String, tipomembro As String, endereco As String)

            Using ObjConexao As New SqlConnection(srtConexao)

                Using ObjComando As New SqlCommand(strInsert, ObjConexao)

                    ObjComando.Parameters.AddWithValue("@nome", nome)
                    ObjComando.Parameters.AddWithValue("@cidade", cidade)
                    ObjComando.Parameters.AddWithValue("@uf", uf)
                    ObjComando.Parameters.AddWithValue("@cep", cep)
                    ObjComando.Parameters.AddWithValue("@tipomembro", tipomembro)
                    ObjComando.Parameters.AddWithValue("@endereco", endereco)

                    ObjConexao.Open()

                    ObjComando.ExecuteNonQuery()

                    ObjConexao.Close()

                End Using

            End Using

        End Sub


        Public Sub Atualizar(idmembro As Integer, nome As String, cidade As String, uf As String, cep As String, tipomembro As String, endereco As String)

            Using ObjConexao As New SqlConnection(srtConexao)

                Using ObjComando As New SqlCommand(strUpdate, ObjConexao)

                    ObjComando.Parameters.AddWithValue("@idmembro", idmembro)
                    ObjComando.Parameters.AddWithValue("@nome", nome)
                    ObjComando.Parameters.AddWithValue("@cidade", cidade)
                    ObjComando.Parameters.AddWithValue("@uf", uf)
                    ObjComando.Parameters.AddWithValue("@cep", cep)
                    ObjComando.Parameters.AddWithValue("@tipomembro", tipomembro)
                    ObjComando.Parameters.AddWithValue("@endereco", endereco)

                    ObjConexao.Open()

                    ObjComando.ExecuteNonQuery()

                    ObjConexao.Close()

                End Using

            End Using

        End Sub


    End Class
End Namespace