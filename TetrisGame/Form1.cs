using System; 
using System.Drawing; 
using System.Windows.Forms;



namespace TetrisGame;

public partial class Form1 : Form
{
    private System.Windows.Forms.Timer gameTimer; 
    private int gridWidth = 10; 
    private int gridHeight = 20;
     private int cellSize = 30;
    public Form1()
    {
        InitializeComponent();
        this.Text = "Tetris"; 
        this.ClientSize = new Size(gridWidth * cellSize, gridHeight * cellSize); 
        this.BackColor = Color.Black; 
        gameTimer = new System.Windows.Forms.Timer(); 
        gameTimer.Interval = 500; 
        // Intervalo de tiempo para mover las piezas gameTimer.Tick += GameTimer_Tick; gameTimer.Start(); this.Paint += new PaintEventHandler(TetrisForm_Paint);
        gameTimer.Tick += GameTimer_Tick; 
        gameTimer.Start(); 
        this.Paint += new PaintEventHandler(TetrisForm_Paint);
    }
        private void TetrisForm_Paint(object sender, PaintEventArgs e) 
        { 
            Graphics g = e.Graphics; // Aquí puedes dibujar la cuadrícula y las piezas del Tetris 
            for (int x = 0; x < gridWidth; x++) 
            { 
                for (int y = 0; y < gridHeight; y++) 
                { g.DrawRectangle(Pens.White, x * cellSize, y * cellSize, cellSize, cellSize); 
                } 
            } 
        } 
        private void GameTimer_Tick(object sender, EventArgs e)
        { // Lógica para mover las piezas del Tetris 
           this.Invalidate(); // Redibuja el formulario
        }
    
}
