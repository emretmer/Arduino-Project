using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ledprojesi
{

	public partial class Form1 : Form
	{

		float a = 7.11f;
		float b = 0;
		float c = 503;
		float d = 505;
		float red = 0;
		float green = 0;
		float blue = 0;

		float red2 = 0;
		float green2 = 0;
		float blue2 = 0;
		int red2int = 0;
		int green2int = 0;
		int blue2int = 0;


		float red3 = 0;
		float green3 = 0;
		float blue3 = 0;

		float red4 = 0;
		float green4 = 0;
		float blue4 = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//serialPort1.PortName = "COM3";
			//serialPort1.BaudRate = 9600;
			//serialPort1.Open();

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}


		private async void button1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode.ToString() == "A")
			{
				while (true)
				{

					////////// FIRST ///////////
					Bitmap foto = new Bitmap((Screen.PrimaryScreen.Bounds.Width), (Screen.PrimaryScreen.Bounds.Height));
					Graphics grafik = Graphics.FromImage(foto as Image);
					grafik.CopyFromScreen(0, 0, (foto.Width / 2), (foto.Height / 2), new Size((foto.Height/2), (foto.Width/2)));
					Bitmap resim = new Bitmap(foto);
					Color Renk;
					await Task.Delay(1);
					for (int i = (resim.Height / 2); i < resim.Height;)
					{
						for (int j = (resim.Width / 2); j < resim.Width; j++)
						{
							Renk = resim.GetPixel(j, i);
							red += Renk.R;
							green += Renk.G;
							blue += Renk.B;
							j += 10;
						}
						i += 10;
					}


					red = red / ((resim.Height) * (resim.Width)) * 770;
					green = green / ((resim.Height) * (resim.Width)) * 770;
					blue = blue / ((resim.Height) * (resim.Width)) * 770;

					textBox1.Text = red.ToString();
					textBox2.Text = green.ToString();
					textBox3.Text = blue.ToString();
										
					////////////////////SECOND////////////////////
					
					Bitmap foto2 = new Bitmap((Screen.PrimaryScreen.Bounds.Width), (Screen.PrimaryScreen.Bounds.Height));
					Graphics grafik2 = Graphics.FromImage(foto2 as Image);
					grafik2.CopyFromScreen((foto2.Width/2), 0, 0, (foto2.Height/2), new Size((foto2.Width/2), (foto2.Height/2)));
					Bitmap resim2 = new Bitmap(foto2);
					Color Renk2;

					await Task.Delay(1);
					for (int i = (resim2.Height / 2); i < (resim2.Height); i++)
					{
						for (int j = 0; j < (resim2.Width/2); j++)
						{
							Renk2 = resim2.GetPixel(j, i);
							red2 += Renk2.R;
							green2 += Renk2.G;
							blue2 += Renk2.B;
							j += 10;
						}
						i += 10;
					}

					red2 = red2 / (resim2.Height * resim2.Width)*471 ;
					green2 = green2 / (resim2.Height * resim2.Width)*471 ;
					blue2 = blue2 / (resim2.Height * resim2.Width)*471 ;

					textBox4.Text = red2.ToString();
					textBox5.Text = green2.ToString();
					//textBox6.Text = blue2.ToString();
					int red2int = (int)red2;
					int green2int = (int)green2;
					int blue2int = (int)blue2;
					textBox6.Text = red2int.ToString() + green2int.ToString() + blue2int.ToString();

					////////////////////serial denemesi////////////////////////




					//serialPort1.Write(red2int.ToString()+green2int.ToString()+blue2int.ToString());
			

					


					////////////////////////THIRD/////////////////////////

					Bitmap foto3 = new Bitmap((Screen.PrimaryScreen.Bounds.Width), (Screen.PrimaryScreen.Bounds.Height));
					Graphics grafik3 = Graphics.FromImage(foto3 as Image);
					grafik3.CopyFromScreen(0, (foto3.Height / 2), (foto3.Width / 2), 0, new Size((foto3.Width/2), (foto3.Height/2)));
					Bitmap resim3 = new Bitmap(foto3);
					Color Renk3;
					await Task.Delay(1);
					for (int i = 0; i < (resim3.Height / 2); i++)
					{
						for (int j = resim3.Width / 2; j < resim3.Width; j++)
						{
							Renk3 = resim3.GetPixel(j, i);
							red3 += Renk3.R;
							green3 += Renk3.G;
							blue3 += Renk3.B;
							j += 10;
						}
						i += 10;
					}
					red3 = red3 / (resim3.Height * resim3.Width) * c;
					green3 = green3 / (resim3.Height * resim3.Width) * c;
					blue3 = blue3 / (resim3.Height * resim3.Width) * c;

					textBox7.Text = red3.ToString();
					textBox8.Text = green3.ToString();
					textBox9.Text = blue3.ToString();

					/////////////////////////////FORTH////////////////////////

					Bitmap foto4 = new Bitmap((Screen.PrimaryScreen.Bounds.Width), (Screen.PrimaryScreen.Bounds.Height));
					Graphics grafik4 = Graphics.FromImage(foto4 as Image);
					grafik4.CopyFromScreen((foto4.Width / 2), (foto4.Height / 2), 0, 0, new Size((foto4.Width / 2), (foto4.Height / 2)));
					Bitmap resim4 = new Bitmap(foto4);
					Color Renk4;
					await Task.Delay(1);
					for (int i = 0; i < resim4.Height; i++)
					{
						for (int j = 0; j < resim4.Width / 2; j++)
						{
							Renk4 = resim4.GetPixel(j, i);
							red4 += Renk4.R;
							green4 += Renk4.G;
							blue4 += Renk4.B;
							j += 10;
						}
						i += 10;
					}

					red4 = red4 / (resim4.Height * resim4.Width) * d;
					green4 = green4 / (resim4.Height * resim4.Width) * d;
					blue4 = blue4 / (resim4.Height * resim4.Width) * d;

					textBox10.Text = red4.ToString();
					textBox11.Text = green4.ToString();
					textBox12.Text = blue4.ToString();

					/////////////////////////FINALE//////////////////////////
					
					int ired = (int)red;
					int igreen = (int)green;
					int iblue = (int)blue;

					int ired2 = (int)red2;
					int igreen2 = (int)green2;
					int iblue2 = (int)blue2;

					int ired3 = (int)red3;
					int igreen3 = (int)green3;
					int iblue3 = (int)blue3;

					int ired4 = (int)red4;
					int igreen4 = (int)green4;
					int iblue4 = (int)blue4;

					//////////////1
					if (ired >= 255)
					{
						ired = 255;
					}
					else if (igreen >= 255)
					{
						igreen = 255;
					}
					else if (iblue >= 255)
					{
						iblue = 255;
					}

					//////////////2
					else if (ired2 >= 255)
					{
						ired2 = 255;
					}
					else if (igreen2 >= 255)
					{
						igreen2 = 255;
					}
					else if (iblue2 >= 255)
					{
						iblue2 = 255;
					}

					//////////////3
					else if (ired3 >= 255)
					{
						ired3 = 255;
					}
					else if (igreen3 >= 255)
					{
						igreen3 = 255;
					}
					else if (iblue3 >= 255)
					{
						iblue3 = 255;
					}

					//////////////4
					else if (ired4 >= 255)
					{
						ired4 = 255;
					}
					else if (igreen4 >= 255)
					{
						igreen4 = 255;
					}
					else if (iblue4 >= 255)
					{
						iblue4 = 255;
					}





					pictureBox1.BackColor = Color.FromArgb(ired, igreen, iblue);
					pictureBox2.BackColor = Color.FromArgb(ired2, igreen2, iblue2);
					pictureBox3.BackColor = Color.FromArgb(ired3, igreen3, iblue3);
					pictureBox4.BackColor = Color.FromArgb(ired4, igreen4, iblue4);
					//pictureBox1.Image = resim;
					//pictureBox2.Image = resim2;
					//pictureBox3.Image = resim3;
					//pictureBox4.Image = resim4;

					red = 0;
					green = 0;
					blue = 0;
					red2 = 0;
					green2 = 0;
					blue2 = 0;
					red3 = 0;
					green3 = 0;
					blue3 = 0;
					red4 = 0;
					green4 = 0;
					blue4 = 0;
	
					await Task.Delay(1);
					GC.Collect();		
				}
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox4_Click_1(object sender, EventArgs e)
		{

		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (serialPort1.IsOpen == true)
			{
				serialPort1.Close();
				serialPort1.Write("0");
			}
		}
	}
}
