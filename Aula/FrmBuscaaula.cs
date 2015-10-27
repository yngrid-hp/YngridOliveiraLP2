using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aula27102015
{
    public partial class FrmBusca : Form
    {   
        
        public FrmBusca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtisbnconsulta.Text == " ")
            {
                MessageBox.Show("Insira algo na caixinha!");
                
            }

            else 
            {

            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;           
            conn.Open();
            String isbn = txtisbnconsulta.Text;
            string str = "Select * From livro Where isbn = ('@isbn')";
            command.Parameters.AddWithValue("@isbn", isbn);
            command.CommandText = str;
             MySqlDataReader reader = command.ExecuteReader();                             
                    
                if (reader.HasRows)
                     {
                            while (reader.Read())
                            {
                               FrmMain F = new FrmMain();
                               F.ShowDialog();
                               id = 
                              
                               
                                
                            }
                            reader.Close();
                        
                
                     } 
                      }
            
           


                  }
            
            

        }

       
    }
}
