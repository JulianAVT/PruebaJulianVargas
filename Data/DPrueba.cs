using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Npgsql;

namespace Data
{
    public class DPrueba
    {

        private NpgsqlConnection conexion;
        private NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter();
        private NpgsqlCommand comando = new NpgsqlCommand();
        private DataTable tabla = new DataTable();
        private DataTable tabla2 = new DataTable();
        private DataTable tabla3 = new DataTable();

        private void inicia()
        {
            try
            {
                string connString = "Host=localhost;Username=postgres;Password=Julvar.123;Database=pruebatecnica";
                conexion = new NpgsqlConnection(connString);                
                conexion.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cierra()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public DataTable cargarContratoLaboral(string StrNumeroDocumento)
        {
            try
            {
                inicia();
                adaptador = new NpgsqlDataAdapter("select contratoslaborales.numerodocumento as numero_documento, tipodocumento.nombre as descripcion_documento,"
               + "contratoslaborales.primernombre as primer_nombre,"
               +  "contratoslaborales.segundonombre as segundo_nombre,"
               + "contratoslaborales.primerapellido as primer_apellido, contratoslaborales.segundoapellido as segundo_apellido,"
               + "contratoslaborales.idcontrato as numero_contrato, cargos.nombre as cargo, arl.valor valor_arl,"
               + "contratoslaborales.fechainicio fecha_inicio_contrato_laboral,"
               + "contratoslaborales.fechafin fecha_fin_contrato_laboral, contratoslaborales.salario salario_laboral " 
               + "from contratoslaborales left join arl on contratoslaborales.idarl = arl.idarl left join cargos on contratoslaborales.idcargo = cargos.idcargo "
               + "left join tipodocumento on tipodocumento.idtipodocumento = contratoslaborales.idtipodocumento where contratoslaborales.numerodocumento = '" + StrNumeroDocumento + "'", conexion);
                adaptador.Fill(tabla);
                cierra();

                return tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public DataTable cargarContratos()
        {
            try
            {
                inicia();
                adaptador = new NpgsqlDataAdapter("select idcontrato,idcontrato from contratoslaborales", conexion);
                adaptador.Fill(tabla2);
                cierra();

                return tabla2;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public DataTable cargarNovedadPorId(int idnovedadnomina)
        {
            try
            {
                inicia();
                adaptador = new NpgsqlDataAdapter("select idnovedadnomina from novedadesnomina where idnovedadnomina='"+ idnovedadnomina +"'", conexion);
                adaptador.Fill(tabla3);
                cierra();

                return tabla3;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public void insertarNomina(int idnovedanomina, int idcontrato, int horasTotalaboradas, 
            int HorasExtrasDiurnas, int HorasExtrasNocturnas, int HorasExtrasDominicales, int HorasExtrasFestivas,string periodolaborado,
            Double descuentoNomina)
        {
            try
            {
                inicia();

                comando = new NpgsqlCommand("insert into novedadesnomina (idnovedadnomina, idcontrato,horaslaboradas," +
                    "horaextradiurna,horaextranocturna,horaextradominical,horaextrafestiva,periodolaborado,descuentos,usuariocreacion,fechacreacion) " +
                    "values('" + idnovedanomina + "','" + idcontrato + "','" + horasTotalaboradas + "'," +
                    "'" + HorasExtrasDiurnas + "', '" + HorasExtrasNocturnas.ToString() + "','" + HorasExtrasDominicales + "'," +
                    "'" + HorasExtrasFestivas + "','" + periodolaborado + "', '" + descuentoNomina.ToString() + "','" + "Julian Vargas" + "', '" + DateTime.Now + "')", conexion);
                comando.ExecuteNonQuery();

                cierra();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
