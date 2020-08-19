using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace gestion_stock
{
     public class Connexion
    {
         private String nom;
         private String mot_pass;
         private SqlConnection con;
         private SqlCommand cmd;
         private SqlDataAdapter dad;
         private DataSet ds;
         public DataTable t ;
         public Connexion(String nom , String mot_pass)
         {
             this.nom = nom;
             this.mot_pass = mot_pass;
         }
         public Boolean connecter()
         {
             Boolean ex = false;
             try 
             {
                 con =new SqlConnection ("data source=MOWGLI;initial catalog=gestion_stock;uid="+nom+";pwd="+mot_pass+";integrated security=false");
                 con.Open();
                 ex = true;
                 return ex;
              }catch(Exception m)
             {
                 return ex = false;
             }
        }
         public int execut_query(String sql_cmd)
         {
             cmd = new SqlCommand();
             cmd.Connection = con;
             cmd.CommandText = sql_cmd;
             return cmd.ExecuteNonQuery();
         }
         public String execute_valeur(String sql_cmd)
         {
             cmd = new SqlCommand();
             cmd.Connection = con;
             cmd.CommandText = sql_cmd;
             return cmd.ExecuteScalar().ToString();
         }
         public void list_deconnecter(String sql_cmd)
         {
             cmd = new SqlCommand();
             cmd.Connection = con;
             cmd.CommandText = sql_cmd;
             dad = new SqlDataAdapter(cmd);
             ds = new DataSet();
             dad.Fill(ds, cmd.CommandText);
             t = new DataTable();
              t = ds.Tables[sql_cmd];
         }
    }
}
