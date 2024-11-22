namespace proyecto_final
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;
        //timer
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            // Intervalo en milisegundos (1 segundo)
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            try
            {
                Arduino = new System.IO.Ports.SerialPort("COM6", 9600);
                Arduino.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el puerto COM: {ex.Message}");
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
    }
}
