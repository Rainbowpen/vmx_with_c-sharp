/*
* for vmx thing...
* must add 參照 Itri.Vmx.Host, Itri.Vmx.Cnc, Itri.Vmx.Daq in 參照
* and need using System.ComponentModel.Composition and i don't know what its.
* 
* 11/6/2020 by simonjan but copy from zzz just change a little bit.
*
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Itri.Vmx.Host;
using Itri.Vmx.Cnc;
using Itri.Vmx.Daq;
using System.IO;
using System.ComponentModel.Composition;

namespace Yong1106
{
    [Export(typeof(IVmxApp))]
    public partial class Form1 : Form,IVmxApp
    {
        public Form1()
        {
            InitializeComponent();
        }

        string IVmxApp.AppName
        {
            get
            {
                return "Yong1106";
            }
        }

        Image IVmxApp.Image
        {
            get
            {
                return Properties.Resources.images;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        CncAdaptor cnc;
        bool IVmxApp.Initialize(IVmxHost host)
        {
            cnc = host.CncAdaptors[0];
            return true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            tmrStart.Start();
            btn.Text = "系統已經啟動";
        }

        private void tmrStart_Tick(object sender, EventArgs e)
        {
            DataItem fsItem = new DataItem();
            fsItem.Path = "/Controller/FeedRate";
            cnc.ReadDataItem(ref fsItem);
            textBox1.Text = fsItem.Value.ToString();

            DataItem fsovrItem = new DataItem();
            fsovrItem.Path = "/Controller/FeedRateOverride";
            cnc.ReadDataItem(ref fsovrItem);
            tb2.Text = fsovrItem.Value.ToString();

            DataItem speedItem = new DataItem();
            speedItem.Path = "/Spindle/ActualSpeedList";
            cnc.ReadDataItem(ref speedItem);
            Array speed = speedItem.Value as Array;
            tb3.Text = speed.GetValue(0).ToString();

            DataItem speedovrItem = new DataItem();
            speedovrItem.Path = "/Spindle/SpeedOverrideList";
            cnc.ReadDataItem(ref speedovrItem);
            Array speedovr = speedovrItem.Value as Array;
            tb4.Text = speedovr.GetValue(0).ToString();

            DataItem iio = new DataItem();
            iio.Path = "/Axes/MachineryPositions";
            cnc.ReadDataItem(ref iio);
            Array ii = iio.Value as Array;
            tb5.Text = ii.GetValue(0).ToString();

            DataItem iioo = new DataItem();
            iioo.Path = "/Axes/AbsolutePositions";
            cnc.ReadDataItem(ref iioo);
            Array iie = iioo.Value as Array;
            tb6.Text = iie.GetValue(0).ToString();


            DataItem iiooo = new DataItem();
            iiooo.Path = "/Axes/RelativePositions";
            cnc.ReadDataItem(ref iiooo);
            Array iiqq = iiooo.Value as Array;
            tb7.Text = iiqq.GetValue(0).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
