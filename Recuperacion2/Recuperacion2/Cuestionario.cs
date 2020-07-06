using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperacion2
{
    public partial class Cuestionario : Form
    {
        
        public int a = 0;
        public Cuestionario()
        {
            InitializeComponent();
            Ejecutar();
            button4.Hide();
        }

        public void Ejecutar()
        {
            if (a == 0)
            {
                textBox1.Text = "1 ¿Que tal le parecio el servicio brindado?";
                button1.Text = "    BUENO";
                button2.Text = "    REGULAR";
                button3.Text = "   MALO";
            }


            if (a == 1)
            {
                textBox1.Text = "2 ¿Como calificaria nuestra atencion al cliente?";
                button1.Text = "    BUENO";
                button2.Text = "    REGULAR";
                button3.Text = "   MALO";

            }

            if (a == 2)
            {
                textBox1.Text = "3 ¿Que tal le parecieron nuestros productos?";
                button1.Text = "    BUENO";
                button2.Text = "    REGULAR";
                button3.Text = "   MALO";
            }


            if (a == 3)
            {
                textBox1.Text = "4 ¿Que le parece la vision de nuestra empresa?: ";
                button1.Text = "    BUENO";
                button2.Text = "    REGULAR";
                button3.Text = "   MALO";
            }
            if (a == 4)
            {
                textBox1.Text = "5 ¿Que tal calificaria la eficacia al realizar el servicio?";
                button1.Text = "    BUENO";
                button2.Text = "    REGULAR";
                button3.Text = "   MALO";
            }
            if (a == 5)
            {
                textBox1.Text = "6 ¿Como calificaria el desempeño de los trabajadores?";
                button1.Text = "    BUENO";
                button2.Text = "    REGULAR";
                button3.Text = "   MALO";
            }
            if (a == 6)
            {
                textBox1.Text = "7 ¿Que tal le parecieron la variedad del servicios?";
                button1.Text = "    BUENO";
                button2.Text = "    REGULAR";
                button3.Text = "   MALO";

            }
            if (a == 7)
            {
                textBox1.Text = "8 ¿Volveria a solicitar nuestros servicios?";
                button1.Text = "    SI";
                button2.Text = "    TALVEZ";
                button3.Text = "    NO";

            }
            if (a == 8)
            {
                textBox1.Text = "9 ¿Como calificaria nuestra empresa?";
                button1.Text = "    BUENO";
                button2.Text = "    REGULAR";
                button3.Text = "   MALO";

            }
            if (a == 9)
            {
                textBox1.Text = "10 Que le ha parecido nuestra encuesta?";
                button1.Text = "    BUENO";
                button2.Text = "    REGULAR";
                button3.Text = "   MALO";

            }
            if (a == 10)
            {
                textBox1.Height = 400;


                textBox1.Text = "Gracias por realizar la encuesta";
                button1.Text=("");
                button2.Text=("");
                button3.Text=("");
                button4.Visible = Visible;

            }
            
        }
        public void Enlances()
        {
            SqlCommand cmd = new SqlCommand("Encuestass", Class1.enlace);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Opcion", 1);
            cmd.Parameters.AddWithValue("@Preguntas", textBox1.Text);
            cmd.Parameters.AddWithValue("@Respuestas", button1.Text);

            Class1.enlace.Open();
            cmd.ExecuteNonQuery();
            Class1.enlace.Close();

        }

        public bool boton = false;
    
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Encuestass", Class1.enlace);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Opcion", 1);
            cmd.Parameters.AddWithValue("@Preguntas", textBox1.Text);
            cmd.Parameters.AddWithValue("@Respuestas", button1.Text);

            Class1.enlace.Open();
            cmd.ExecuteNonQuery();
            Class1.enlace.Close();
            a += 1;
            Ejecutar();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Encuestass", Class1.enlace);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Opcion", 1);
            cmd.Parameters.AddWithValue("@Preguntas", textBox1.Text);
            cmd.Parameters.AddWithValue("@Respuestas", button2.Text);

            Class1.enlace.Open();
            cmd.ExecuteNonQuery();
            Class1.enlace.Close();
            a += 1;
            Ejecutar();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Encuestass", Class1.enlace);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Opcion", 1);
            cmd.Parameters.AddWithValue("@Preguntas", textBox1.Text);
            cmd.Parameters.AddWithValue("@Respuestas", button3.Text);

            Class1.enlace.Open();
            cmd.ExecuteNonQuery();
            Class1.enlace.Close();
            a += 1;
            Ejecutar();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
