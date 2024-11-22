using System;
using System.Data;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final
{
    public partial class Form1 : Form
    {
        private SerialPort Arduino;
        private DataTable dataTable;
        private StringBuilder dataBuffer = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();

            try
            {
                Arduino = new SerialPort("COM3", 9600);
                Arduino.DataReceived += SerialPort_DataReceived;
                Arduino.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el puerto COM: {ex.Message}");
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string incomingData = Arduino.ReadExisting();
                dataBuffer.Append(incomingData);

                // Procesar en un hilo de fondo
                Task.Run(() => ProcessBufferedData());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer del puerto serial: {ex.Message}");
            }
        }

        private void ProcessBufferedData()
        {
            try
            {
                string data = dataBuffer.ToString();
                int newLineIndex;

                while ((newLineIndex = data.IndexOf('\n')) >= 0)
                {
                    string line = data.Substring(0, newLineIndex).Trim();
                    dataBuffer.Remove(0, newLineIndex + 1);
                    ProcessIncomingData(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar datos: {ex.Message}");
            }
        }

        private void ProcessIncomingData(string data)
        {
            try
            {
                string[] parts = data.Split(',');
                if (parts.Length >= 4)
                {
                    string uid = parts[0].Replace("UID: ", "").Trim();
                    string nameOrStatus = parts[1].Trim();
                    string date = parts[2].Replace("Fecha: ", "").Trim();
                    string time = parts[3].Replace("Hora: ", "").Trim();

                    // Actualizar la UI de manera segura
                    this.Invoke(new Action(() =>
                    {
                        lbltest.Text = $"UID: {uid}\nPropietario: {nameOrStatus}\nFecha: {date}\nHora: {time}";

                        // Verificar si el UID ya existe en el DataTable
                        if (!dataTable.AsEnumerable().Any(row => row.Field<string>("ID Tarjeta") == uid))
                        {
                            dataTable.Rows.Add(uid, nameOrStatus, date, time);
                        }
                    }));

                    // Opcional: Muestra en la consola para depuración
                    Console.WriteLine($"UID: {uid}, Propietario: {nameOrStatus}, Fecha: {date}, Hora: {time}");
                }
                else
                {
                    Console.WriteLine("Formato de datos incorrecto: " + data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar datos: {ex.Message}");
            }
        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("ID Tarjeta", typeof(string));
            dataTable.Columns.Add("Propietario", typeof(string));
            dataTable.Columns.Add("Fecha", typeof(string));
            dataTable.Columns.Add("Hora", typeof(string));

            dataGridView1.DataSource = dataTable;
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            if (Arduino != null && Arduino.IsOpen)
            {
                Arduino.Write("3");
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("El puerto serial no está abierto o no está configurado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridView()
        {
            try
            {
                if (Arduino != null && Arduino.IsOpen)
                {
                    // Lee los datos del puerto serial
                    string incomingData = Arduino.ReadLine()?.Trim(); // Lee una línea de datos y elimina espacios

                    // Verifica si incomingData es nulo o vacío
                    if (!string.IsNullOrEmpty(incomingData))
                    {
                        // Procesa los datos como lo harías normalmente
                        ProcessIncomingData(incomingData);
                    }
                    else
                    {
                        MessageBox.Show("No se recibieron datos del puerto serial.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El puerto serial no está abierto o no está configurado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Arduino != null && Arduino.IsOpen)
            {
                Arduino.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Arduino != null && Arduino.IsOpen)
            {
                Arduino.Write("1");
            }
        }

        private void cerrrPuertaBtn_Click(object sender, EventArgs e)
        {
            if (Arduino != null && Arduino.IsOpen)
            {
                Arduino.Write("2");
            }
        }

        private void lbltest_Click(object sender, EventArgs e)
        {
            // Acción al hacer clic en el label (opcional)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Acción al hacer clic en el DataGridView (opcional)
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // Acción al hacer clic en la tab (opcional)
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Acción al hacer clic en el label (opcional)
        }

        private void updateDataClick(object sender, EventArgs e)
        {
            // Acción al hacer clic en el botón (opcional)
        }

        private void fecha_Click(object sender, EventArgs e)
        {
            // Acción al hacer clic en la fecha (opcional)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lógica adicional al cargar el formulario (opcional)
        }
    }
}