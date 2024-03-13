namespace Tabla_de_multiplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Numero.Text, out int numero))
            {
                MostrarTabla(numero);
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarTabla(int numero)
        {
            lst_tabla.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
                lst_tabla.Items.Add($"{numero} x {i} = {resultado}");
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Numero.Clear();
            lst_tabla.Items.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
