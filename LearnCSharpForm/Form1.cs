using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace LearnCSharpForm
{
    
    public partial class Form1 : Form
    {
        private string jsonPath =  "WelcomeGift.json";
        private int R = 0;
        private int G = 0;
        private int B = 0;
        private Color c;

        private List<string> infos = new List<string>();
        int listPointer = 0;

        public Form1()
        {
            InitializeComponent();
            int Width = this.Width;
            int Height = this.Height;
            Welcome_Info.Location = new Point(Width / 6, (Height / 3));
            
            string jsonContent = ReadFromFile(jsonPath);
            AnalyseJson(jsonContent, ref infos);
            InitWelcomeEffect();

        }

        private string ReadFromFile(string filePath)
        {
            StreamReader sr = new StreamReader(filePath, Encoding.Default);
            sr = File.OpenText(filePath);
            StringBuilder sb = new StringBuilder();
            while(sr.EndOfStream == false)
            {
                sb.AppendLine(sr.ReadLine());
            }
            string content = sb.ToString();
            
            return content;
            //throw new NotImplementedException();
        }
        
        public void AnalyseJson(string j, ref List<string> value)
        {
            var jsonObject = JsonConvert.DeserializeObject<dynamic>(j);
            for (int i = 0; i < jsonObject.Count; i++)
            {
                value.Add(jsonObject[i]["gift"].Value);
            }
        }

        private void InitWelcomeEffect()
        {
            //TODO: Read text from JSON file
            c = Color.FromArgb(R, G, B);
            Anime_Controller.Interval = 10;
            Anime_Controller.Start();

            //throw new NotImplementedException();
        }

        private void Anime_Controller_Tick(object sender, EventArgs e)
        {
            if(R == 0 && listPointer<infos.Count())
            {
                
                Welcome_Info.Text = infos[listPointer];
                listPointer++;
            }
            //Change fore color by decrease the value of RGB
            if (R < 255)
            { R++; G++; B++; }
            else if(R == 255)
            { R = 0;G = 0;B = 0; }

            c = Color.FromArgb(R, G, B);
            Welcome_Info.ForeColor = c;

        }

        //Get rgb value from an input color
        public int GetRGBFromColor(Color color)
        {
            byte r = color.R;
            byte g = color.G;
            byte b = color.B;
            //Change into 32 bit RGB value
            int rgb = (r & 0xff) | ((g & 0xff) << 8) | ((b & 0xff) << 16);
            return rgb;
        }
    }
}
