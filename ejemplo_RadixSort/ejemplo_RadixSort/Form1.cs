namespace ejemplo_RadixSort
{
    public partial class Form1 : Form
    {
        int[] datos = { 170, 45, 75, 90, 802, 24, 2, 66 };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarArrayDesordenado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arreglo desordenado es :","Radix Sort");
            string datosTexto = string.Join(", ", datos);
            lbDatos.Text = datosTexto;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Usar la clase RadixSort definida en Radix_Sort.cs
            var sorter = new Radix_Sort.RadixSort();
            sorter.Sort(datos);

            // Mostrar los datos ordenados en el ListBox
            lsbDatos.Items.Clear();
            foreach (var num in datos)
            {
                
                lsbDatos.Items.Add(num);
            }
            MessageBox.Show("Arreglo ordenado con exito","Radix Sort");
        }
    }
}
