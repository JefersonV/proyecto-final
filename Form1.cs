using System.Data;
using System.Diagnostics;
using System.IO.Ports;

namespace proyecto_final
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;
        //timer
        private System.Windows.Forms.Timer timer;
        private DataTable dataTable; // Agregar esta línea para declarar dataTable

        // Variables para almacenar temporalmente los datos de un registro
        private string currentUid;
        private string currentNameOrStatus;
        private string currentDate;
        private string currentTime;

        public Form1()
        {
            //InitializeComponent();
            InitializeComponent();

            InitializeDataTable();
            //timer = new System.Windows.Forms.Timer();
            //// Intervalo en milisegundos (1 segundo)
            //timer.Interval = 1000;
            //timer.Tick += Timer_Tick;
            //timer.Start();

            try
            {
                Arduino = new System.IO.Ports.SerialPort("COM3", 9600);
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
            // Leer los datos desde el puerto serial
            string incomingData = Arduino.ReadLine().Trim();
            //string incomingData = serialPort.ReadLine().Trim();

            // Procesar los datos en el hilo principal
            Invoke(new Action(() => ProcessIncomingData(incomingData)));
        }


        private void ProcessIncomingData(string data)
        {
            try
            {
                Debug.WriteLine("Datos recibidos: " + data);
                string[] parts = data.Split(',');

                if (parts.Length >= 2)
                {
                    // Procesar UID y Nombre/Estado
                    currentUid = parts[0].Replace("UID: ", "").Trim();
                    currentNameOrStatus = parts[1].Trim();

                    // Inicializar variables para fecha y hora
                    currentDate = parts.Length > 2 && parts[2].StartsWith("Fecha:") ? parts[2].Replace("Fecha: ", "").Trim() : string.Empty;
                    currentTime = parts.Length > 3 && parts[3].StartsWith("Hora:") ? parts[3].Replace("Hora: ", "").Trim() : string.Empty;

                    // Verificar si el UID ya existe en el DataTable
                    DataRow existingRow = dataTable.AsEnumerable().FirstOrDefault(row => row.Field<string>("ID Tarjeta") == currentUid);

                    if (existingRow != null)
                    {
                        // Si existe y el estado es acceso denegado, agregar una nueva fila
                        if (currentNameOrStatus.Equals("acceso denegado", StringComparison.OrdinalIgnoreCase))
                        {
                            dataTable.Rows.Add(currentUid, currentNameOrStatus, currentDate, currentTime, string.Empty); // Hora de salida vacía
                        }
                        else
                        {
                            // Si no es acceso denegado, actualizar la hora de salida
                            existingRow["Hora Salida"] = currentTime; // Asignar la hora de salida
                        }
                    }
                    else if (!string.IsNullOrEmpty(currentUid))
                    {
                        // Agregar la fila al DataTable si no existe
                        dataTable.Rows.Add(currentUid, currentNameOrStatus, currentDate, currentTime);
                    }
                }
                else
                {
                    Console.WriteLine("Datos no reconocidos: " + data);
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
            dataTable.Columns.Add("Hora Entrada", typeof(string));
            dataTable.Columns.Add("Hora Salida", typeof(string)); // Nueva columna para la hora de salida
            dataGridView1.DataSource = dataTable; // Asignar DataTable al DataGridView
        }
        private void ProcessSerialData(string data)
        {
            // Espera datos en formato CSV: "UID,Nombre"
            string[] parts = data.Split(',');
            if (parts.Length == 2)
            {
                string uid = parts[0].Trim();
                string nombre = parts[1].Trim();

                // Verifica si el UID ya está registrado
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["UID"].ToString() == uid)
                    {
                        return; // UID ya existe, no lo agrega
                    }
                }

                // Agrega una nueva fila al DataTable
                dataTable.Rows.Add(uid, nombre);
            }
        }
        private void Timer_Tick(object? sender, EventArgs e) // Agregar el modificador de nulabilidad para resolver CS8622
        {
            // Lógica del temporizador
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fecha_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arduino.Write("1");
        }

        private void cerrrPuertaBtn_Click(object sender, EventArgs e)
        {
            Arduino.Write("2");
            //Arduino.ReadByte();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbltest_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdataData_Click(object sender, EventArgs e)
        {
            // Forzar la lectura de datos manualmente
            try
            {
                // Envía un comando al Arduino para solicitar datos
                Arduino.Write("3"); // Asegúrate de que este comando sea correcto para tu Arduino.

                // Esperar un breve momento para que Arduino envíe los datos
                System.Threading.Thread.Sleep(100); // Ajusta el tiempo según sea necesario

                // Leer y procesar los datos desde el puerto serial
                //UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar los datos: {ex.Message}");
            }
        }

        // Método para actualizar manualmente el DataGridView
        private void UpdateDataGridView()
        {
            try
            {
                // Verificar si el puerto serial está abierto
                if (Arduino.IsOpen)
                {
                    string incomingData = Arduino.ReadLine().Trim(); // Lee una línea de datos

                    // Procesa los datos como lo harías normalmente
                    ProcessIncomingData(incomingData);  // Llama a tu método para procesar y agregar los datos
                }
                else
                {
                    MessageBox.Show("El puerto serial no está abierto.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer los datos: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\UMG\ARQ PC II\data table\datos.txt"; // Ruta completa para el archivo
            ExportDataGridViewToTxt(filePath);
        }

        private void ExportDataGridViewToTxt(string filePath)
        {
            try
            {
                // Verificar si el directorio existe
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory); // Crear el directorio si no existe
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Escribir encabezados
                    writer.WriteLine("ID Tarjeta, Propietario, Fecha, Hora Entrada, Hora Salida");

                    // Escribir cada fila del DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        writer.WriteLine($"{row["ID Tarjeta"]}, {row["Propietario"]}, {row["Fecha"]}, {row["Hora Entrada"]}, {row["Hora Salida"]}");
                    }
                }

                MessageBox.Show($"Datos exportados a {filePath} exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar datos: {ex.Message}");
            }
        }
    }
}
