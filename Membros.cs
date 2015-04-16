using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IEADWebApp
{
    public class Membros
    {
        public String Idmembro {get; set;}
        public String NomeMembro { get; set; }
        public String CidadeMembro { get; set; }
        public String UfMembro { get; set; }
        public String CepMembro { get; set; }
        public String EndMembro { get; set; }
        public String TelMembro { get; set; }
        public String SexoMembro { get; set; }
        public String TipoMembro { get; set; }

        public const String strSelectTop100  = "SELECT * FROM t0050";
        public const String strSelect   = "SELECT * FROM t0050 WHERE idmembro = @idmembro";
        public const String strInsert   = "INSERT INTO t0050 VALUES(@nome, @cidade, @uf, @cep, @tipomembro, @endereco)";
        public const String strUpdate   = "UPDATE t0050 SET nome = @nome, cidade = @cidade, uf = @uf, cep = @cep," +
        " tipomembro = @tipomembro, endereco = @endereco WHERE idmembro = @idmembro";
        public const String strDelete = "DELETE t0050 WHERE idmembro = @idmembro";

        public void ListMembros()
        {
        
        
        }
    }


}