using DAL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {

            try
            {

                SqlParameter[] p = {
                    new SqlParameter("@ad",ogr.ad),
                    new SqlParameter("@soyad",ogr.soyad),
                    new SqlParameter("@numara",ogr.Numara)

                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblogrenciler (ad,soyad,numara) values(@ad,@soyad,@numara) ", p) > 0;
            }

            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //if (cn !=null & cn.State!= ConnectionState.Closed)
                //{
                // cn.Close();
                // cn.Dispose();
                // }
            }
        }
    
}
}
