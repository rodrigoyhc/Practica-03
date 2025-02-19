namespace Practica_03
{
    public partial class Form1 : Form
    {
        string filePath = null;
        DataGridView dgv = new DataGridView();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNAbrir_Click(object sender, EventArgs e)
        {
            bool check = false;
            DialogResult resultado;
            resultado = openFileDialogAbrir.ShowDialog();
            int reng = 0;
            int col = 0;
            string texto = "";
            string linea = "";
            if (resultado == DialogResult.OK)
            {
                filePath = openFileDialogAbrir.FileName;
                try
                {
                    texto = File.ReadAllText(filePath);

                    char[] c = texto.ToCharArray();

                    for (int i = 0; check == false; i++)
                    {
                        if (c[i].Equals(',') || c[i].Equals('\n'))
                        {
                            col++;
                            if (c[i].Equals('\n'))
                            {
                                check = true;
                            }
                        }
                    }

                    for (int i = 0; i < c.Length; i++)
                    {
                        if (c[i].Equals('\n'))
                        {
                            reng++;
                        }
                    }

                    int[,] vec = new int[reng, col];
                    DGVTabla.RowCount = reng;
                    DGVTabla.ColumnCount = col;

                    string[] ll = texto.Split("\n");
                    int numFilas = ll.Length;
                    int numColumnas = ll[0].Split(',').Length;

                    string[,] matriz = new string[numFilas, numColumnas];
                    for (int i = 0; i < numFilas - 1; i++)
                    {
                        string[] columnas = ll[i].Split(',');
                        for (int j = 0; j < numColumnas; j++)
                        {
                            matriz[i, j] = columnas[j];
                        }
                    }

                    for (int i = 0; i < DGVTabla.Rows.Count; i++)
                    {
                        for (int j = 0; j < DGVTabla.Columns.Count; j++)
                        {
                            DGVTabla[j, i].Value = matriz[i + 1, j];
                        }
                    }

                    for (int j = 0; j < DGVTabla.Columns.Count; j++)
                    {
                        DGVTabla.Columns[j].HeaderText = matriz[0, j];
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }



            }

        }

        private void variosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
