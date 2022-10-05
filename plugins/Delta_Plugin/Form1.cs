using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using LiveCharts.Wpf;
using LiveCharts;

namespace MissionPlanner
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer incomingDataTimer;
        private SeriesCollection series;
        private LineSeries lSeries;
        private LineSeries lSeries1;
        private Random random = new Random();
        private LiveCharts.Wpf.Axis AxisX = new LiveCharts.Wpf.Axis();

        public string text1;

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Form1 init");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            //DataGraphique.DataSource ;
            // var ressources = new List<data>();
            // ressources.Add(new data() { hauteur = 2, name = "Ali" });
            // ressources.Add(new data() { hauteur = 3, name = "test" });

            // DataGraphique.DataSource = ressources;

            incomingDataTimer = new System.Timers.Timer();
            series = new SeriesCollection();
            lSeries = new LineSeries();
            lSeries1 = new LineSeries();

            AxisX.Title = "temps";
            AxisX.LabelFormatter = value => value.ToString("0");
            //AxisX.MaxValue = 4000;

            cartesianChart1.AxisX.Add(AxisX);
            /**
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "temps",
                LabelFormatter = value => value.ToString("0"),
                MaxValue = 100
                //ValueType = ChartValueType.DateTime;
            }); ;
            **/
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Valeurs",
                LabelFormatter = value => value.ToString("0.00")
            });

            
            lSeries.Values = new ChartValues<float>();
            lSeries1.Values = new ChartValues<float>();
            series.Add(lSeries);
            series.Add(lSeries1);
            cartesianChart1.Series = series;

            

            incomingDataTimer.Elapsed += new ElapsedEventHandler(AddRandomItemToChart);
            incomingDataTimer.Interval = 100; // 1000 ms is one second
            incomingDataTimer.Start();
        }

        public void AddRandomItemToChart(object source, ElapsedEventArgs e)
        {
            // code here will run every second
            // float val = (float)CurrentState._sideslip;
            CurrentState state = new CurrentState();
            short valeur_side_slip = state.sideslip;
            short valeur_capteur_charge = state.CapteurCharge; 
            //Console.WriteLine("TEST addRandomItemToChart   :   valeur sideslip  val = : " + valeur_capteur_charge.ToString());
            // lSeries.Values.Add((float)(random.NextDouble() * 20.0));
            lSeries.Values.Add((float)(valeur_side_slip));
            lSeries1.Values.Add((float)(valeur_capteur_charge));
            // lSeries.Values.Add(sideslip);

            if (lSeries.Values.Count >= 5000)
            {
                  incomingDataTimer.Stop();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pnlNavigation_CloseClick(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxHauteur_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pnlDonnees_CloseClick(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            text1 = textBox1.Text;
            Console.WriteLine("TEST : textBox1 = " + textBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Console.WriteLine("TEST : Boutton 1 clicked : " + text1);
            textBox3.Text = text1;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void form1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void myUserControl2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }



  //  public class data
 //   {
   //     public int hauteur { get; set; }
    //    public string name { get; set; }
    //}    
}
