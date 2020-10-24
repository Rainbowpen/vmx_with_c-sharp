using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// for vmx
using System.ComponentModel.Composition;
using Itri.Vmx.Host;
using Itri.Vmx.Cnc;
using Itri.Vmx.Daq;


namespace cool_app_by_simon
{

    [Export(typeof(IVmxApp))] //tell everyone we have IVmxApp.
    public partial class Form1 : Form, IVmxApp
    {
        CncAdaptor cnc;
        DaqAdaptor daq;
        DaqBuffer daq_buffer;
        bool isTimerStart = false;
        int daq_buffer_size = 44100;
        int idx = 0;

        public Form1()
        {
            InitializeComponent();
            button_show.Text = "Click to start timer";
            label_show.Text = "Input will show here";
        }

        private void label_show_Click(object sender, EventArgs e)
        {

        }

        private void button_show_Click(object sender, EventArgs e)
        {
            if (!isTimerStart)
            {
                button_show.Text = "Click to stop timer";
                timer_update.Start();
                timer_update_2.Start();
                isTimerStart = true;
            }
            else
            {
                button_show.Text = "Click to start timer";
                timer_update.Stop();
                timer_update_2.Stop();
                isTimerStart = false;
            }
            
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_update_Tick(object sender, EventArgs e)
        {

    


            DataItem progItem = new DataItem();
            progItem.Path = "/controller/program";
            cnc.ReadDataItem(ref progItem); //
            string prog_text = "Prog   : " + progItem.Value.ToString();
            label_prog.Text = prog_text;

            label_time.Text = "Date time: " + DateTime.Now.ToString();


            DataItem mposItem = new DataItem();
            mposItem.Path = "/Axes/MachineryPositions";
            cnc.ReadDataItem(ref mposItem);
            double[] mpos = mposItem.Value as double[];
            label_mpos.Text ="Mpos 1 : " + mpos[0].ToString();
            label_mpos2.Text = "Mpos 2 : " + mpos[1].ToString();
            label_mpos3.Text = "Mpos 3 : " + mpos[2].ToString();

            DataItem feedOverItem = new DataItem();
            feedOverItem.Path = "/Controller/FeedrateOverride";
            cnc.ReadDataItem(ref feedOverItem);
            double feedOvr = Convert.ToDouble(feedOverItem.Value);
            progressBar_feedOvr.Value = Convert.ToInt32(feedOvr);

           
        }

        private void label_time_Click(object sender, EventArgs e)
        {

        }

        public string AppName
        {
            get { return "cool app by simon";  }
        }

        public Image Image
        {
            get { return Properties.Resources.github_octopus; }
        }

        public bool Initialize(IVmxHost host)
        {
            
            cnc = host.CncAdaptors[0];

            daq = host.DaqAdapters[0];

            //start it when daq not working.
            if (!daq.IsStarted)
            {
                daq.Start();
            }
            daq_buffer = new DaqBuffer(daq, daq.Settings.SamplingRate);

            return true;
        }

        private void label_mpos_Click(object sender, EventArgs e)
        {

        }

        private void label_mpos2_Click(object sender, EventArgs e)
        {

        }

        private void label_mpos3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_feedOvr_Click(object sender, EventArgs e)
        {

        }

        private void timer_update_2_Tick(object sender, EventArgs e)
        {
            string text = textBox_input.Text;
            label_show.Text = text;

            double[] data = daq_buffer.CreateContainerForBufferData(); //double[44100];
            daq_buffer.GetAllData(0, data);
            

            double[] showdata = new double[100];
            for (int i = 0; i < 100; i++)
            {
                double[] tmp = new double[441];
                Array.Copy(data, i * 441, tmp, 0, 441);
                showdata[i] = tmp.Average();
            }
            chart_data.Series[0].Points.DataBindY(showdata);


            string fileName = "D:\\simon\\contents" + idx + ".csv";
            string content = string.Join(Environment.NewLine, data); // Environment.NewLine same as "\r\n"
            System.IO.File.WriteAllText(fileName, content);
            idx++;
        }

        private void chart_data_Click(object sender, EventArgs e)
        {

        }
    }
}
